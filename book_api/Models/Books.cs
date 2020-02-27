using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace book_api.Models
{
    public class Books
    {
        public int ID { get; set; }
        public String Title { get; set; }
        public String Author { get; set; }
        public int NumberOfPages { get; set; }
    }
}
