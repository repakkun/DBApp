using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DBApp
{
    public class BookRepository
    {
        //выбор объекта из БД по его идентификатору
        public void SelectBookId()
        {
            using (AppContext db = new AppContext())
            {
                db.Books.Select(b => b.Id).FirstOrDefault();
            }
        }

        //выбор всех объектов
        public void SelectAllBooks()
        {
            using (AppContext db = new AppContext())
            {
                db.Books.ToList();
            }
        }

        //добавление объекта в БД и его удаление из БД
        public void AddAndDeleteBook()
        {
            using (AppContext db = new AppContext())
            {
                var books = new Book { Title = "1q84", Year = 2000};
                db.Books.Add(books);
                db.Books.Remove(books);
            }
        }

        //обновление названия книги
        public void UserUpdate()
        {
            using (AppContext db = new AppContext())
            {
                var firstBook = db.Books.FirstOrDefault();
                firstBook.Title = "1984";
            }
        }
    }
}
