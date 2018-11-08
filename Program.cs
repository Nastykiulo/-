using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace v4
{
    static class Program
    {


        static void Main()
        {   //вывести максимальное число для ushort
            ushort maxushort = (ushort)65.535;
            Console.Write(maxushort);

            //поиск подстроки в строке
            string str = "стр123 строка содержит";
            string str2 = "123";
            int index = str.IndexOf(str2);
            if (index == -1)
            {
                Console.WriteLine("Строка не содержит 123");
            }
            else
            {
                Console.WriteLine("Строка содержит 123");
            }


            //массивы 
            // Объявляем двумерный массив
            int[,] myArr = new int[4, 5];

            Random ran = new Random();

            // Инициализируем данный массив
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    myArr[i, j] = ran.Next(1, 15);
                    Console.Write("{0}\t", myArr[i, j]);
                }
                Console.WriteLine();

                Date iv = new Date();
                Date ol = new Date();
                Console.WriteLine(ol.Equals(iv));
            }
            // создать класс 

        }
        class Date
        {
            public int day { get; set; }
            public int month { get; set; }
            readonly public int year;

            //переопределение 
            public override bool Equals(object obj)
            {
                if (obj == null) return false;
                if (obj.GetType() != this.GetType()) return false;
                Date stud = (Date)obj;
                return (this.day == stud.day && this.month == stud.month);
            }

        }

        //Задание 3
        interface IGood { void plus(); }
        interface IBad { void minus(); }
        public abstract class People
        {

        }
        class Student : People, IGood, IBad
        {
            public void plus()
            {

            }
            public void minus()
            {

            }
            void IGood.plus()
            {
                Console.Write("plus");
            }
            void IBad.minus()
            {
                Console.Write("minus");
            }
        }
        class Prepod : People, IGood, IBad
        {
            public void plus()
            {

            }
            public void minus()
            {

            }
            void IGood.plus()
            {
                Console.Write("plus2");
            }
            void IBad.minus()
            {
                Console.Write("minus2");
            }
        }
    }
}
