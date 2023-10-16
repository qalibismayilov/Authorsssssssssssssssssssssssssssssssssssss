    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Models
{
    public class Student:BaseEntity
    {
        public int FirstName { get; set; }
        public int LastName { get; set; }
        public int Id_Group { get; set; }
        public string Term { get; set; }


    }
}
