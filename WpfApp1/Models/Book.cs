using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Models;

namespace WpfApp1.Model
{
    public class Books : BaseEntity
    {

        public string Name { get; set; }
        public int Pages { get; set; }
        public int YearPress { get; set; }
        public int ThemesID { get; set; }
        public int CategoryID { get; set; }
        public int AuthorID { get; set; }
        public int PressID { get; set; }
        public string Comment { get; set; }
        public string Quantity { get; set; }
    }
}
