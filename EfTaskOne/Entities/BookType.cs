using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfTaskOne.Entities
{
    public  class BookType:BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Book>Books { get; set; }
    }
}
