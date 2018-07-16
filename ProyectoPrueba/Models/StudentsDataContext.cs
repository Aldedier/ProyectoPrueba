using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoPrueba.Models
{
    public class StudentsDataContext : DbContext
    {
        public DbSet<Student> Student { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Data Source = (localdb)\.; Initial Catalog = StudentsDB; Integrated Security = true "
                );
            base.OnConfiguring(optionsBuilder);
        }


    }

    public class Student
    {
        [DatabaseGenerated(
            DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Edad { get; set; }
    }

}
