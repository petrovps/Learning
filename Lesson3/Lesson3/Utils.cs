using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    public class Utils
    {


        /// <summary>
        /// Написать метод возвращающий минимальное из трех чисел.
        /// </summary>
        public static int Minimum(int a, int b, int c)
        {
            var max = (a < b && a < c) ? a : (b < c) ? b : c;
            return max;
        }

        /// <summary>
        /// Метод подсчета длины значения
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static int Quantity(int a)
        {
            var q = Convert.ToString(a).Length;
            return q;
        }



        /// <summary>
        /// Метод подсчета суммы всех нечетных положительных чисел.
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static int GetValue()
        {
            int x;
            string s;
            bool flag; 
            do
            {
                Console.WriteLine("Введите значение");
                s = Console.ReadLine();
                flag = int.TryParse(s, out x);
                if (!flag) Console.WriteLine("Введенное значение не является целым числом!");
            }
            while (!flag); 
            return x;
        }

        /// <summary>
        ///Метод проверки логина и пароля
        /// </summary>
        /// <param name="login"></param>
        /// <param name="pass"></param>
        /// <returns></returns>
        public static bool PassCheck(string login, string pass)
        {
            string log = "root";
            string password = "GeekBrains";
            bool result = false;
            if (login.ToLower() == log)
            {
                if (pass == password)
                {
                    result = true;
                }
            }
            else { result = false; }

            return result;
        }

        /// <summary>
        /// Подсчет индекса массы тела
        /// </summary>
        /// <param name="height"></param>
        /// <param name="weight"></param>
        /// <returns></returns>
        public static double IMT(Double height, Double weight)
        {
            double imt = weight / Math.Pow(height, 2);
            return imt;
        }

        /// <summary>
        /// Метод подсчета суммы цифр числа
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static int summ(int a)
        {
            var sum = 0;
            while (a > 0)
            {
                sum += a % 10;
                a /= 10;
            }
            return sum;
        }

        public static void Loop(int a, int b)
        {
            Console.Write($"\n{a}");
            if (a < b) Loop(a + 1, b);
        }

        /// <summary>
        /// Рекурсивный метод подсчета суммы
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="sum"></param>
        /// <returns></returns>
        public static long LoopSumm(int a, int b)
        {

            if (a < b) { return a + LoopSumm(a + 1, b); }
            else { return a; }
        }


    }
}
