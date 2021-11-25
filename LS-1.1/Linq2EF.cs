using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LS_1._1
{
    public class Linq2EF
    {
        private static readonly List<string> nameList = new List<string> { "Иван", "Владимир", "Антон", "Арсен", "Илья", "Закир", "Эмир", "Дамир", "Кирилл", "Данил", "Григорий", "Никита" };
        private static readonly List<string> surnameList = new List<string> { "Иванов", "Сидоров", "Тимощюк", "Березовой", "Петров", "Романов", "Павлов", "Маслов", "Соболев", "Кондратьев", "Иванюк" };

        public IEnumerable<string> Example1()
        {
            return nameList.OrderBy(x => x);
        }

        public IEnumerable<User> Example2()
        {
            List<User> userList = new List<User>(GetRandomUserList(11));

            return userList.OrderBy(x => x.Surname);
        }

        public User Example3()
        {
            return new List<User>(GetRandomUserList(11)).FirstOrDefault(x => x.Name == "Антон");
        }

        public IEnumerable<User> Example4()
        {
            return new List<User>(GetRandomUserList(11)).Where(x => x.Age > 18).OrderBy(x => x.Surname).ThenBy(x => x.Age);
        }

        public IEnumerable<string> Example5()
        {
            return new List<User>(GetRandomUserList(11)).Where(x => x.Age > 18 && x.Age < 50).Select(x => x.Surname).OrderBy(x => x);
        }

        private List<User> usrExmapleList = new List<User>(GetRandomUserList(30));
        public IEnumerable<User> Example6()
        {
            return usrExmapleList.OrderBy(x => x.Surname).ThenBy(x => x.Age).Take(10);
        }

        public string Example7()
        {
            if (nameList.Contains("Иван"))
            {
                return "Да";
            }
            else
            {
                return "Нет";
            }
        }

        /// <summary>
        /// Метод наполнения листа пользователей рандомными данными
        /// </summary>
        /// <param name="count">Принимает колличество объектов в листе</param>
        /// <returns>Взращает неупорядоченый лист объектов</returns>
        private static List<User> GetRandomUserList(int count)
        {
            List<User> resultList = new List<User>();
            Random rnd = new Random();

            for (int i = 0; i < count; i++)
            {
                User usr = new User();
                
                usr.Name = nameList[rnd.Next(12)];
                usr.Surname = surnameList[rnd.Next(11)];
                usr.Age = (uint)rnd.Next(100);

                resultList.Add(usr);
            }

            return resultList;
        }
    }

    public class User
    { 
        public string Name { get; set; }

        public string Surname { get; set; }

        public uint Age { get; set; }
    }

}
