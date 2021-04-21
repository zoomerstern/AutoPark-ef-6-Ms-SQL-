using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using MyEF6Db;

namespace AutoPark
{
    public partial class MyAuto : Form
    {
        private Auto currAuto;//Авто
        private List<TypeJob> TypeJobs;//Тип работ с машиной
        int number;//Ид машины
        public MyAuto(int number)
        {
            this.number = number;
            InitializeComponent();
            insAuto();//Инициализируем машину

            ////Выводим данные о машине
            tMark.Text = currAuto.Mark;//Марка
            tModel.Text = currAuto.Model;//Модель
            dateTime.Format = DateTimePickerFormat.Custom;
            dateTime.CustomFormat = "yyyy.MM.dd HH:mm";//Форматы даты работы
            TypeJobData();//Загружаем работы о машине
        }
   
        private void insAuto()
        {//Инициализация машины
            using (ParkContext Park = new ParkContext())
            {
                currAuto = Park.Autos.Find(number);//Вывод машины
            }

            motorBox.Items.Clear();//очищение списка моторов
            using (ParkContext Park = new ParkContext())
            {//вывод моторов
                foreach (Motor motor in Park.Motors.ToList()) //Запись данных об моторах
                {
                    motorBox.Items.Add(motor.Name);
                }
                Park.Autos.Attach(currAuto);
                if (currAuto.Motor != null)
                    motorBox.SelectedItem = currAuto.Motor.Name;
            }
        }
    
        private void TypeJobData()
        {//Вывод типо работ мотора
            jobsBox.SelectedItem = null;
            jobsBox.Items.Clear();//очистка списка работ
            if (currAuto.MotorId != null)
            {
                using (ParkContext Park = new ParkContext())
                {
                    Park.Autos.Attach(currAuto);
                    //Park.Entry(currAuto).Collection("Job").Load();
                    TypeJobs = currAuto.Motor.TypeJob.ToList();
                    foreach (TypeJob name in TypeJobs)
                        jobsBox.Items.Add(name.Name);
                }
            }
            JobData();
            return;
        }

        private void JobData()
        {//Вывод данных о работах
            dataGridView1.Rows.Clear();
            using (ParkContext Park = new ParkContext())
            {
                Park.Autos.Attach(currAuto);
                foreach (Job job in currAuto.Job)
                {
                    dataGridView1.Rows.Add(new string[] { job.Id.ToString(), job.TypeJob.Name, job.Date });
                }
            }
            return;
        }




        private void JobAdd_Click(object sender, EventArgs e)
        {//Добавлеие работы
            if (jobsBox.Text.ToString() == "")
            {//Проверка на пустые поля
                MessageBox.Show("Заполненны не все полей");
                return;
            }
            using (ParkContext Park = new ParkContext())
            {
                //Ид Типа работы
                int TypeId = TypeJobs.Where(x => x.Name == jobsBox.Text.ToString()).Select(x=>x.Id).FirstOrDefault();
                //Добавляем работу
                Park.Jobs.Add(new Job { AutoId=currAuto.Id,TypeJobId=TypeId, Date= dateTime.Value.ToString("dd.MM.yyyy HH:mm") }
                              );
                Park.SaveChanges();
            }
            //Обнавим данные
            insAuto();
            JobData();
        }

        private void Close_Click(object sender, EventArgs e)
        {//Закрытие
            Close();
        }

        private void Update_Click(object sender, EventArgs e)
        {//обновление информации о машине
            if (tModel.Text.ToString() == currAuto.Model && currAuto.Motor!=null &&
                motorBox.SelectedItem.ToString() == currAuto.Motor.Name &&
                tMark.Text.ToString() == currAuto.Mark)//Проверка на заполнение полей
                return;
            using (ParkContext Park = new ParkContext())
            {
                Park.Autos.Attach(currAuto);
                if (currAuto.Motor==null || motorBox.SelectedItem.ToString() != currAuto.Motor.Name)
                {// если изменить мотор
                 //будт удалены все работы с этим моторм
                    MessageBox.Show("В случае замены мотора будут удалены все работы с машиной, т.к. они ориентированны на другой тип двигателя.");
                    DialogResult dialogResult = MessageBox.Show("Вы согласны?", "Согласие", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)//если согласны
                    {
                        Park.Jobs.RemoveRange(currAuto.Job);//Удаляем работы
                        //Ставим новый мотор
                        currAuto.Motor = Park.Motors.Where(x => x.Name == motorBox.SelectedItem.ToString()).FirstOrDefault();
                    }
                }
                currAuto.Mark = tMark.Text.ToString();//Марка
                currAuto.Model = tModel.Text.ToString();//Модель
                Park.Entry(currAuto).State = EntityState.Modified;//Редактирование
                Park.SaveChanges();
            }
            insAuto();//Обновляем машину
            TypeJobData();//обновляем работы
            MessageBox.Show("Изменения внесены");
        }

        private void JobDelete_Click(object sender, EventArgs e)
        {//Удаление Работы
            if (dataGridView1.RowCount < 2 || dataGridView1[0, dataGridView1.CurrentRow.Index].Value == null) //Проверка на нажатие
                return;
            //Определяем ид
            int id = int.Parse(dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString());
            using (ParkContext Park = new ParkContext())
            {
                Park.Autos.Attach(currAuto);
                Park.Jobs.Remove(currAuto.Job.Where(x=>x.Id== id).FirstOrDefault());//Удаляем работы
                Park.SaveChanges();
            }
            //Обновление данных
            insAuto();
            JobData();
        }

    }
}
