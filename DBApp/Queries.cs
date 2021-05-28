using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DBApp
{
    public class Queries
    {
        public void Query1()
        {
            using (AppContext db = new AppContext())
            {
                db.Books.Where(b => b.Genre == "Poem" && b.Year < 2000).ToList();
            }
        }

        public void Query2()
        {
            using (AppContext db = new AppContext())
            {
                db.Books.GroupBy(b => b.Author).Select(g => new { Author = g.Key, BooksCount = g.Count() }).ToList();
            }
        }
        public void Query3()
        {
            using (AppContext db = new AppContext())
            {
                db.Books.GroupBy(b => b.Genre).Select(g => new { Genre = g.Key, BooksCount = g.Count() }).ToList();
            }
        }
        public bool Query4()
        {
            using (AppContext db = new AppContext())
            {
                if (db.Books.Select(b => b.Author).Contains("Pushkin"))
                {
                    return true;
                }
                return false;
            }
        }
        public bool Query5()
        {
            using (AppContext db = new AppContext())
            {
                if (db.Books.GroupBy(b => b.Title).Select(g => new { Title = g.Key, UsersCount = g.Count() }).Where(g => g.UsersCount > 0).ToList() != null)
                {
                    return true;
                }
                return false;
            }
        }
        public void Query6()
        {
            using (AppContext db = new AppContext())
            {
                db.Books.GroupBy(b => b.UserId).Select(g => new { IdUser = g.Key, BooksCount = g.Count() }).ToList();
            }
        }
        public void Query7()
        {
            using (AppContext db = new AppContext())
            {
                db.Books.Max(b => b.Year);
            }
        }
        public void Query8()
        {
            using (AppContext db = new AppContext())
            {
                db.Books.OrderBy(b => b.Title).ToList();
            }
        }
        public void Query9()
        {
            using (AppContext db = new AppContext())
            {
                db.Books.OrderByDescending(b => b.Year).ToList();
            }
        }

    }
}
