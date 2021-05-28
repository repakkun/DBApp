using System;
using System.Collections.Generic;
using System.Text;

namespace DBApp
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }

        //навигационное свойство
        public List<Book> Books { get; set; } = new List<Book>();
    }
}
