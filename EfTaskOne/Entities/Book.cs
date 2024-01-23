using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfTaskOne.Entities
{
    public  class Book:BaseEntity
    {
        public string Name { get; set; }
        public int PageCount { get; set; }
        public ICollection<Student> Students{ get; set; }
        public int AuthorId{ get; set; }
        public Author Author{ get; set; }
        public int BookTypeId { get; set; }
        public BookType BookType { get; set; }

    }
}

