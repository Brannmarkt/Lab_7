using Lab_4.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4.Data
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext() : base()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder options) 
        {
            options.UseSqlServer("Data Source=DESKTOP-G89E2KT\\SQLEXPRESS;Initial Catalog=Csharp_Lab_7;Integrated Security=True");
        }

        public DbSet<Discipline> Disciplines { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
    }
}
