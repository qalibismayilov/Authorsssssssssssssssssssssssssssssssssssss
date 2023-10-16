using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Models
{
    public class S_Card:BaseEntity
    {
        public int StudentId { get; set;}
        public int BookId {get; set;}
        public DateTime DateOut {get; set;}
        public DateTime DateIn {get; set;}
        public int Id_Lib {get; set;}
    }
}
