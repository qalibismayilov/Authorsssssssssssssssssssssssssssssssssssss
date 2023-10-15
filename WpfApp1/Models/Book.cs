using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Models
{
    public class Book:BaseEntity
    {
        public string Name {get;set;}
        public int Pages {get;set;}
        public int YearPress {get;set;}
        public int Id_Themes {get;set;}
        public int CCategory {get;set;}
        public int Id_Author {get;set;}
        public int Id_Press {get;set;}
        public string comment {get;set;}
        public int Quantity {get;set;}
    }
}
