using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Barbu_Nicoleta_Lab9.Models
{
    public class BookCategory
    {
        public int ID { get; set; }
        public int BookID { get; set; }
        public Book Book { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }

    }
}
