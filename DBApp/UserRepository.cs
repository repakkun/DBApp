using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DBApp
{
    public class UserRepository
    {
        //выбор объекта из БД по его идентификатору
        public void SelectUserId()
        {
            using (AppContext db = new AppContext())
            {
                db.Users.Select(u => u.Id).FirstOrDefault();
            }
        }

        //выбор всех объектов
        public void SelectAllUsers()
        {
            using (AppContext db = new AppContext())
            {
                db.Users.ToList();
            }
        }

        //добавление объекта в БД и его удаление из БД
        public void AddAndDeleteUser()
        {
            using (AppContext db = new AppContext())
            {
                var user = new User { Name = "Ilya", Role = "Admin" };
                db.Users.Add(user);
                db.Users.Remove(user);
            }
        }

        //обновление имени пользователя
        public void UserUpdate()
        {
            using (AppContext db = new AppContext())
            {
                var firstUser = db.Users.FirstOrDefault();
                firstUser.Name = "Ilya";
            }
        }
    }
}
