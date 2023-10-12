using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.NikolajchukVS.Sprint1.Task7.V18.Lib;

namespace Tyuiu.NikolajchukVS.Sprint1.Task7.V18
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнила: Николайчук В. С.| РПСБ-23-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнила: Николайчук Валерия Сергеевна | РПСБ-23-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                 1 + sin^2(x + y);*");
            Console.WriteLine("* z = ---------------------------------------- + x*");
            Console.WriteLine("*       2 + |             2 * x         |*");
            Console.WriteLine("*           | x - --------------------- |*");
            Console.WriteLine("*           |        1 + x^2 * y^2      |*");

            double x, y;

            Console.WriteLine("Введите значение X :");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение Y :");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.Calculate(x, y));

            Console.ReadLine();


        }
    }
}
