using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;


namespace Lesson3
{
    class Program
    {
        enum Exercises
        {
            complex = 1,
            amount

        }

        struct Complex
        {
            public double im;
            public double re;

            /// <summary>
            /// метод сложения комплексных чисел
            /// </summary>
            /// <param name="x"></param>
            /// <returns></returns>
            public Complex Plus(Complex x)
            {
                Complex temp;
                temp.im = im + x.im;
                temp.re = re + x.re;
                return temp;
            }

            /// <summary>
            /// метод вычитания комплексных чисел
            /// </summary>
            /// <param name="x"></param>
            /// <returns></returns>
            public Complex Minus(Complex x)
            {
                Complex temp;
                temp.im = im - x.im;
                temp.re = re - x.re;
                return temp;
            }

            /// <summary>
            /// метод умножения комплексных чисел
            /// </summary>
            /// <param name="x"></param>
            /// <returns></returns>
            public Complex Multi(Complex x)
            {
                Complex temp;
                temp.im = im * x.im + re * x.im;
                temp.re = re * x.im - im * x.re;
                return temp;
            }

            /// <summary>
            /// метод деления комплексных чисел
            /// </summary>
            /// <param name="x"></param>
            /// <returns></returns>
            public Complex Div(Complex x)
            {
                Complex temp;
                temp.re = (re * x.re + im * x.im) / (x.re * x.re + x.im * x.im);
                temp.im = (x.re * im - re * x.im) / (x.re * x.re + x.im * x.im);
                return temp;
            }


            public string ToString()
            {
                return re + "+" + im + "i";
            }
        }

        /// <summary>
        /// Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса;
        /// </summary>
        static void Ex1()
        {
            Complex complex1;
            complex1.re = 3;
            complex1.im = 6;
            Complex complex2;
            complex2.re = 1;
            complex2.im = 2;
            Console.WriteLine($"Комплексное число 1 = {complex1.re}+{complex1.im}i");
            Console.WriteLine($"\nКомплексное число 2 = {complex2.re}+{complex2.im}i");
            Complex result = complex1.Plus(complex2);
            Console.WriteLine($"\nРезультат сложения: " + result.ToString());
            result = complex1.Multi(complex2);
            Console.WriteLine($"\nРезультат Умножения: " + result.ToString());
            result = complex1.Minus(complex2);
            Console.WriteLine($"\nРезультат вычитания: " + result.ToString());
            result = complex1.Div(complex2);
            Console.WriteLine($"\nРезультат деления: " + result.ToString());
        }

        /// <summary>
        /// Требуется подсчитать сумму всех нечетных положительных чисел. Сами числа и сумму вывести на экран;
        /// Используя tryParse; 
        /// б) Добавить обработку исключительных ситуаций на то, что могут быть введены некорректные данные.
        /// При возникновении ошибки вывести сообщение.
        /// </summary>
        static void Ex2()
        {

            int a = Utils.GetValue();

            var sum = 0;
            while (a != 0)
            {

                if ((a > 0) && (a % 2 != 0))
                {
                    sum = sum + a;
                }
                a = Utils.GetValue();
            }
            Console.Write($"\nСумма всех нечетных положительных чисел = {sum}");
        }

        /// <summary>
        /// 
        /// </summary>
        static void Ex3()
        {

        }



        /// <summary>
        ///Инструменты расположены в методах класса Utils, тут производится вызов этих методов.
        /// </summary>
        static void Main()
        {
            Console.Write("Введите номер задания для проверки(1-3): ");
            Exercises Ex = (Exercises)Convert.ToInt32(Console.ReadLine());
            switch (Ex)
            {

                case Exercises.complex: Ex1(); break;
                case Exercises.amount: Ex2(); break;
                //case Exercises.amount: Ex3(); break;

                default: Console.Write($"нет такого задания! \nВведите еще раз.. "); Main(); break;
            }

            //Завершение...
            Console.Write($"\nДля выбора задания введите b, для выхода любое другое значения:");
            if (Convert.ToString(Console.ReadLine()).ToLower() == "b") { Main(); }
        }

    }
}
