using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyEF6Db;

namespace AutoPark
{
    public partial class MotorJobs : Form
    {
        int imotor = -1;//Индекс мотора
        int ijob = -1;//Индекс работы

        public MotorJobs()
        {
            InitializeComponent();
            MotorLoad();//объявляем список моторв
        }

        private void MotorLoad()
        {//Вывод данных о моторах
            dataGridView2.Rows.Clear();//Очистка моторов
            dataGridView1.Rows.Clear();//Очистка работ
            using (ParkContext Park = new ParkContext())
            {
                    foreach (Motor motor in Park.Motors.ToList())
                    { //Запись в массив   
                        dataGridView2.Rows.Add(new string[] { motor.Id.ToString(), motor.Name });
                    }
            }
            return;
        }

        private void JobLoad()
        {//Вывод данных о работах над моторами
            if (imotor == -1) 
                return; //какой индекс мотора
            dataGridView1.Rows.Clear();
            
            using (ParkContext Park = new ParkContext())
            {//Выводим моторы
                foreach (TypeJob job in Park.Motors.Where(x => x.Id == imotor).FirstOrDefault().TypeJob.ToList()) //Запись данных об работах над моторм
                {
                    dataGridView1.Rows.Add(new string[] { job.Id.ToString(), job.Name });
                }
            }
            return;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {//Событие на клик списка моторв
            if (dataGridView2.RowCount < 2 || dataGridView2[0, dataGridView2.CurrentRow.Index].Value == null)
                return;//Проверка на коректный вобор из списка моторов
            tEmotor.Text = dataGridView2[1, dataGridView2.CurrentRow.Index].Value.ToString(); //Выводим название мотора
            imotor = int.Parse(dataGridView2[0, dataGridView2.CurrentRow.Index].Value.ToString()); //Запомниаем индекс моторах
            JobLoad();//Выводим работы по мотору
            return;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {//Событие на клик списка работы
            if (dataGridView1.RowCount < 2 || dataGridView1[0, dataGridView1.CurrentRow.Index].Value == null)
                return;
            tEjob.Text = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();//Вывод названия работы
            ijob = int.Parse(dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString());//Запомниаем индекс работы
            return;
        }

        private void Bmotor_Click(object sender, EventArgs e)
        {//Добавить мотр список
            if (tEmotor.Text.ToString() == "" )
                return;
            using (ParkContext Park = new ParkContext())
            {//Добавляем мотор
                if (Park.Motors.Where(x => x.Name == tEmotor.Text.ToString()).FirstOrDefault() == null)
                {
                    Park.Motors.Add(new Motor { Name = tEmotor.Text.ToString() });
                    Park.SaveChanges();
                }
                
            }
            MotorLoad();// Обновление списка моторов
            imotor = -1;//Сброс индекса мотора
            tEmotor.Text = "";//Сброс мотора в текст боксе
            return;;
        }
        private void BEmotor_Click(object sender, EventArgs e)
        {//Измнить мотор
            if (tEmotor.Text.ToString() == "" || imotor == -1)
                return;   
            using (ParkContext Park = new ParkContext())
            {
                Motor currMotor = Park.Motors.Where(x => x.Id == imotor).FirstOrDefault();
                if (currMotor != null)//Если есть мотор
                {//меняем данные
                    currMotor.Name= tEmotor.Text.ToString();
                    Park.Entry(currMotor).State = EntityState.Modified;
                    Park.SaveChanges();
                }
            }
            
            MotorLoad();
            imotor = -1;
            tEmotor.Text = "";
        }
        private void bDmotor_Click(object sender, EventArgs e)
        {//Удаление мотора
            if (tEmotor.Text.ToString() == "" || imotor == -1)
                return;
            // Есть ли машины и работы по данному мотору
            MessageBox.Show("В случае удаления мотора будут удалены все работы связанные с этим мотором");
            DialogResult dialogResult = MessageBox.Show("Вы согласны?", "Согласие", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
                return;
            using (ParkContext Park = new ParkContext())
            {
                Motor currMotor = Park.Motors.Where(x => x.Id == imotor).FirstOrDefault();
                if (currMotor != null)//если есть мотор
                {
                    List<TypeJob> currtype = currMotor.TypeJob.ToList();
                    if (currtype.Count != 0)
                    {
                        foreach (TypeJob currjob in currtype)//Удаляение работ 
                            if (currjob.Job!=null)
                                Park.Jobs.RemoveRange(currjob.Job.ToList());
                        Park.TypeJobs.RemoveRange(currtype);//Удаляение типов работ
                    }
                    foreach (Auto currauto in currMotor.Auto.ToList())
                    {//Обнуление моторв авто
                        currauto.Motor = null;
                        Park.Entry(currauto).State = EntityState.Modified;
                    }
                    //Park.Entry(Park.Autos.Where(x=>x.MotorId==imotor)).State = EntityState.Modified;
                    Park.Motors.Remove(currMotor);//Удаление мотора
                    Park.SaveChanges();
                }
            }
            //==
            imotor = -1;//Сброс индекса мотора
            tEmotor.Text = "";//Сброс названия мотора в текст боксе
            MotorLoad();//Обновление списка моторв
        }

        private void bClose_Click(object sender, EventArgs e)
        {// закрыть окно
            Close();
        }

        private void bjob_Click(object sender, EventArgs e)
        {//Добавление работы над мотором
            if (tEjob.Text.ToString() == "" ||  imotor == -1)
                return;
            using (ParkContext Park = new ParkContext())
            {//Если такой работы нет добовляем ее
                Motor currMotor = Park.Motors.Where(x => x.Id == imotor).FirstOrDefault();
                if (currMotor.TypeJob.Where(x=>x.Name == tEjob.Text.ToString()).ToList().Count==0) {
                    Park.TypeJobs.Add(new TypeJob { Name = tEjob.Text.ToString(), MotorId = currMotor.Id });
                    Park.SaveChanges();
                }
            }

            JobLoad();
            ijob = -1;
            tEjob.Text = "";
        }

        private void bEjob_Click(object sender, EventArgs e)
        {//Редактирование работы
            if (tEjob.Text.ToString() == "" || ijob == -1)
                return;
            using (ParkContext Park = new ParkContext())
            {

                TypeJob currtype = Park.TypeJobs.Where(x => x.Id == ijob).FirstOrDefault();
                if (currtype != null)
                {
                    currtype.Name = tEjob.Text.ToString();
                    Park.Entry(currtype).State = EntityState.Modified;
                    Park.SaveChanges();
                }
            }

            JobLoad();
            ijob = -1;
            tEjob.Text = "";
        }

        private void bDjob_Click(object sender, EventArgs e)
        {//Удаление работы
            if (tEjob.Text.ToString() == "" || ijob == -1)
                return;
            using (ParkContext Park = new ParkContext())
            {

                TypeJob currtype = Park.TypeJobs.Where(x => x.Id == ijob).FirstOrDefault();
                if (currtype != null)
                {
                    Park.Jobs.RemoveRange(currtype.Job);
                    Park.TypeJobs.Remove(currtype);
                    Park.SaveChanges();
                }
            }
            JobLoad();
            ijob = -1;
            tEjob.Text = "";
        }
    }
}
