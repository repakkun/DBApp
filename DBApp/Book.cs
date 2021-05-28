using System;
using System.Collections.Generic;
using System.Text;

namespace DBApp
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }

        public string Author { get; set; }

        //внешний ключ
        public int UserId { get; set; }
        //навигационное свойство
        public User User { get; set; }
    }
}
