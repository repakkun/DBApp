using System;
using System.Linq;

namespace DBApp
{
    public class Program
    {
        static void Main(string[] args)
        {           
            using (var db = new AppContext())
            {
                var user1 = new User { Name = "Arthur", Role = "Admin" };
                var user2 = new User { Name = "Bob", Role = "Admin" };
                var user3 = new User { Name = "Clark", Role = "User" };

                db.Users.Add(user1);
                db.SaveChanges();

                var book1 = new Book { Author = "Pushkin", Title = "Qwe", Year = 1999, Genre = "Poem" };
                var book2 = new Book { Author = "Lermontov", Title = "Qeee", Year = 2005, Genre = "Prose" };
                var book3 = new Book { Author = "Esenin", Title = "Qtttt", Year = 1890, Genre = "Poem" };

                book1.User = user1;
                book2.User = user2;
                book3.User = user3;

                db.Users.AddRange(user2, user3);
                db.Books.AddRange(book1, book2, book3);
                db.SaveChanges();

            }           
        }
    }
}
