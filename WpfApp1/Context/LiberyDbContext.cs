using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Models;

namespace WpfApp1.Context
{
    public class LiberyDbContext:DbContext

    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public List <Authors> Authors { get; set; }
        public List <Authors> Book { get; set; }
        public List <Authors> Category { get; set; }
        public List <Authors> Department { get; set; }
        public List <Authors> faculty { get; set; }
        public List <Authors> Group { get; set; }
        public List <Authors> Lib { get; set; }
        public List <Authors> Press { get; set; }
        public List <Authors> S_Card { get; set; }
        public List <Authors> Student { get; set; }
        public List <Authors> T_Card { get; set; }
        public List <Authors> Teacher { get; set; }
        public List <Authors> Theme { get; set; }
    }
}
