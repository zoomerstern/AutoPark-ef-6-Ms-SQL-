using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace MyEF6Db
{
    public class ParkContext : DbContext
    {
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
        //[MaxLength(1000)]
        public string Model { get; set; }//Модель
       // [ForeignKey("Motor")]
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
        //[MaxLength(1000)]
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
        public string Name { get; set; }//Название работы

        public virtual ICollection<Job> Job { get; set; }//Работы с машинами
    }
    //Работы
    [Table("Job")]
    public class Job
    {
        public int Id { get; set; }//Ид
        public int? AutoId { get; set; }//Номер машины
        public int? TypeJobId{ get; set; }//Номер работы
        public virtual TypeJob TypeJob { get; set; }//Ссылка тип работы
        public string Date { get; set; }//Марка
        

    }
}
