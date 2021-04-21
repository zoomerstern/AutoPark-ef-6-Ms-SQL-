using System;
using System.Linq;
using System.Windows.Forms;
using MyEF6Db;

namespace AutoPark
{
    public partial class AutoPark : Form
    {
        
        public AutoPark()
        {
            InitializeComponent();
            GridLoad();
        }


        private void GridLoad()
        {//Вывод спика машин
            dataGridView1.Rows.Clear();//Отчистка таблицы
            
            using(ParkContext Park = new ParkContext()){
                foreach (Auto auto in Park.Autos.ToList())
                {
                    dataGridView1.Rows.Add(new string[4] { auto.Id.ToString(), auto.Mark, auto.Model, 
                                                           auto.Motor!=null? auto.Motor.Name : "отсутствует"
                                                         });
                }
            }

            
        }


        private void Inform()
        {//Информация о машине          
            if (dataGridView1[0, dataGridView1.CurrentRow.Index].Value == null) //Проверка на нажатие
                return;
            //Выделение ид
            int number = int.Parse(dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString()); 
            //В форму для редактирования переносимм ид машины
            MyAuto frm = new MyAuto(number);
            if (frm.Enabled != false)
                frm.ShowDialog();
            //Обновляем список
            GridLoad();
            return;
        }
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Inform();//Запрос на информацию о товаре      
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            Inform();
        }

        private void Add_Click(object sender, EventArgs e)
        {//Добавлние машины
            Add frm = new Add();
            frm.Owner = this;
            if (frm.Enabled != false)
                frm.ShowDialog();
            GridLoad();//Обновляем список
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            //Удаление машины
            if (dataGridView1.RowCount < 2 || dataGridView1[0, dataGridView1.CurrentRow.Index].Value == null) //Проверка на нажатие
                return;
            //Определяем модель и его таблицу
            int number = int.Parse(dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString());//модель
            //Удаляем в работы машины
            using (ParkContext Park = new ParkContext())
            {
                Auto currAuto = Park.Autos.Find(number);
                Park.Jobs.RemoveRange(currAuto.Job);//сначала удаляем работы над машиноый
                Park.Autos.Remove(currAuto);//Удаляем машину
                Park.SaveChanges();
            }
            //Обновляем список
            GridLoad();
            MessageBox.Show("Инфомация о машине удалена!");
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            //Вывод окна "моторы и работы"
            MotorJobs frm = new MotorJobs();
            if (frm.Enabled != false)
                frm.ShowDialog();
            //Обновляем список
            GridLoad();
        }
        private void Close_Click(object sender, EventArgs e)
        {
            //Выход
            Close();
        }
    }
}
