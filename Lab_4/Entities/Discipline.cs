using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4.Entities
{
    public class Discipline
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public int Hours { get; set; }
        [ForeignKey("Teacher")]
        public string TeacherId { get; set; }

        public Discipline()
        {
            Id = string.Empty;
            Title = string.Empty;
            Hours = 0;
        }
        public Discipline(string title, int hours)
        {
            Title = title;
            Hours = hours;
        }
        public Discipline(string title, int hours, string teacherid)
        {
            Title = title; 
            Hours = hours;
            TeacherId = teacherid;
        }
        public Discipline(string id, string title, int hours, string teacherid)
        {
            Id = id;
            Title = title;
            Hours = hours;
            TeacherId = teacherid;
        }
    }
}
