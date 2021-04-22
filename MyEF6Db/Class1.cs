using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace MyEF6Db
{
    //class MyContextInitializer : DropCreateDatabaseIfModelChanges<ParkContext>
    //{
    //    protected override void Seed(ParkContext db)
    //    {
    //        Motor m1 = new Motor { Name = "Бензин" };
    //        Motor m2 = new Motor { Name = "Дизель" };

    //        db.Motors.Add(m1);
    //        db.Motors.Add(m2);

    //        TypeJob t1 = new TypeJob { Name = "Расточка блока", Motor = m1};
    //        TypeJob t2 = new TypeJob { Name = "Замена поршней (дизель)", Motor=m2 };

    //        db.TypeJobs.Add(t1);
    //        db.TypeJobs.Add(t2);

    //        Auto p1 = new Auto { Mark = "Toyta", Model = "Delica", Motor=m1 };
    //        Auto p2 = new Auto { Mark = "Lada", Model = "Niva", Motor = m2 };

    //        db.Autos.Add(p1);
    //        db.Autos.Add(p2);

    //        Job j1 = new Job { TypeJob = t1, Date = "23.01.21 12:23:23" , Auto= p1 };
    //        Job j2 = new Job { TypeJob = t2, Date = "26.01.21 12:23:23", Auto = p2 };

    //        db.Jobs.Add(j1);
    //        db.Jobs.Add(j2);

    //        db.SaveChanges();
    //    }
    //}
    public class ParkContext : DbContext
    {
        //static ParkContext()
        //{
        //    Database.SetInitializer<ParkContext>(new MyContextInitializer());
        //}
        public ParkContext()
            : base("ParkDB")
        { }
        public DbSet<Auto> Autos { get; set; }//Авто
        public DbSet<Motor> Motors { get; set; }//Моторы
        public DbSet<TypeJob> TypeJobs { get; set; }//Типы работ
        public DbSet<Job> Jobs { get; set; }//Работы
    }
    //Машины
    [Table("Auto")]
    public class Auto
    {
        public int Id { get; set; }//Ид
        public string Mark { get; set; }//Марка
        public string Model { get; set; }//Модель
        public int? MotorId { get; set; }
        public virtual Motor Motor { get; set; }//Мотор машины
        public virtual ICollection<Job> Job { get; set; }//Список работ с машиной


    }
    //Моторы
    [Table("Motor")]
    public class Motor
    {
        //[ForeignKey("Auto")]
        public int Id { get; set; }//Ид
        public string Name { get; set; }//Тип мотора
        public virtual ICollection<Auto> Auto { get; set; }//У каких машин
        public virtual ICollection<TypeJob> TypeJob { get; set; }//Какие работы для этого мотора
    }
    //Тип работ
    [Table("TypeJob")]
    public class TypeJob
    {
        public int Id { get; set; }//Ид
        public int? MotorId { get; set; }//Для какого типа мотора
        //public virtual Motor Motor { get; set; }//Мотор машины (для инициализации)
        public string Name { get; set; }//Название работы

        public virtual ICollection<Job> Job { get; set; }//Работы с машинами
    }
    //Работы
    [Table("Job")]
    public class Job
    {
        public int Id { get; set; }//Ид
        public int? AutoId { get; set; }//Номер машины
        //public virtual Auto Auto { get; set; }//Авто (для инициализации)
        public int? TypeJobId{ get; set; }//Номер работы
        public virtual TypeJob TypeJob { get; set; }//Ссылка тип работы
        public string Date { get; set; }//Марка
        

    }
}
