using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ShabanovMS.Sprint1.Task2.V23.Lib;

//ЗАДАНИЕ
//Написать программу, которая запрашивает у пользователя исходные данные, выполняет указанные расчёты и печатает результат на экране.
//Формулировка задания: Задано количество минут. Перевести время в секунды.
//Что пользователь вводит? Время в минутах (целое число)
//Что программа печатает на экране? Время в секундах (целое число)

namespace Tyuiu.ShabanovMS.Sprint1.Task2.V23
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Шабанов М.С. | АСОиУб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт 1                                                                *");
            Console.WriteLine("* Тема: Арифметические операторы в C#                                     *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #23                                                             *");
            Console.WriteLine("*Выполнил: Шабанов Мирон Сергеевич | АСОиУб-23-1                          *");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Задано количество минут. Перевести время в секунды.                     *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double a;
            double x = 60;

            Console.WriteLine("Введите количество минут:");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
            Console.WriteLine("***************************************************************************");



            Console.WriteLine("Количество секунд в " + a + " минутах равно " + ds.Calculate(a, x));
            Console.ReadKey();
        }

    }
}
