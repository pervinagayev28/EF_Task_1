

using EfTaskOne.Entities;
using Microsoft.EntityFrameworkCore;

namespace EfTaskOne.DbContexts
{
    public class MyLibraryDbContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-47DGCU6\\SQL;Initial Catalog=MyLibrary;User ID=MySql;Password=pervina9266_1;Connect Timeout=30;");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Author> Authors{ get; set; }
        public DbSet<Book> Books{ get; set; }
        public DbSet<Student> Students{ get; set; }
        public DbSet<BookType> BookTypes{ get; set; }






    }
}
