using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyEF6Db;

namespace AutoPark
{
    public partial class Add : Form
    {

        public Add()
        {
            InitializeComponent();
            Insert();
        }
        void Insert()
        {//Вывод списка моторв
            motorBox.Items.Clear();
            using (ParkContext Park = new ParkContext())
            {
                foreach (Motor motor in Park.Motors.ToList())
                { //Запись в бокс 
                    motorBox.Items.Add(motor.Name);
                }
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {//Добавление машины
            if (tBmark.Text.ToString() == "" || tBmodel.Text.ToString() == ""
                || motorBox.Text.ToString() == "")//Проверка
            {
                MessageBox.Show("Заполненны не все поля");
                return;
            }
            using (ParkContext Park = new ParkContext())
            {//Находим мотор
                Motor currmotor = Park.Motors.Where(x => x.Name == motorBox.Text.ToString()).FirstOrDefault();
                //Добавляем машину
                Park.Autos.Add(new Auto
                {
                    Mark = tBmark.Text.ToString(),//Марка
                    Model = tBmodel.Text.ToString(),//Модель
                    Motor = currmotor//Мотор
                });
                Park.SaveChanges();
            }
               
            Close();
        }

        private void Close_Click(object sender, EventArgs e)
        {//Закрыть
            Close();
        }

        
    }
}
