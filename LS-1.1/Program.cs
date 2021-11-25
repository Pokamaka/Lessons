using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace LS_1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Observ
            ObservableCollection<string> exmplCollection = new ObservableCollection<string>();

            #endregion

            #region LiqnBase

            List<string> tmpList = new List<string>();

            var t1 = from str in tmpList orderby str select str;

            var t2 = tmpList.OrderBy(x => x);
            #endregion

            #region LINQ

            Linq2EF lq = new Linq2EF();

            #region OrderBY (string)
            //foreach (var str in lq.Example1())
            //{
            //    Console.WriteLine(str);
            //}
            #endregion

            #region OrderBY (T)
            //foreach (var str in lq.Example2())
            //{
            //    Console.WriteLine($"{str.Surname} {str.Name}");
            //}
            #endregion

            #region FirstOrDefault(pred)
            //User usr = lq.Example3();
            //Console.WriteLine($"{usr.Surname} {usr.Name}");
            #endregion

            #region Where
            //foreach (var str in lq.Example4())
            //{
            //    Console.WriteLine($"{str.Surname} {str.Name}, возраст - {str.Age}");
            //}

            //foreach (var str in lq.Example5())
            //{
            //    Console.WriteLine(str);
            //}
            #endregion

            #region Take
            //foreach (var str in lq.Example6())
            //{
            //    Console.WriteLine($"{str.Surname} {str.Name}, возраст - {str.Age}");
            //}
            #endregion

            #region Contains
            Console.WriteLine(lq.Example7());
            #endregion

            #endregion

            Console.ReadLine();
        }

    }
}
