//Выполнил: Рыстаков Никита
//Вариант: 7
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая__5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
            uint v2, v3, v4, v5, v6;
            Console.Write("Введите количество яиц а = ");
            uint a = Convert.ToUInt32(Console.ReadLine());
            Console.Write("Введите количество коробок b = ");
            uint b = Convert.ToUInt32(Console.ReadLine());
            v2 = b * 300;//общая вместимость всех коробок
            if (a <= v2)
            {

                v3 = (a + 300 - 1) / 300;
                v4 = b - v3;//расчёт коробок

                if (v4 > 0)
                {
                    Console.WriteLine($"Яйца поместятся. Останется {v4} коробок.");
                }
                else
                {
                    Console.WriteLine("Яйца поместятся. Коробок хватит точно.");
                }
            }
            else
            {

                v5 = (a - v2 + 300 - 1) / 300;//расчёт коробок
                v6 = ((a - v2) + 29) / 30;//расчёт ячеек

                Console.WriteLine($"Яйца не поместятся. Нужно ещё:");
                Console.WriteLine($"{v5} коробок");
                Console.WriteLine($"{v6} ячеек");
            }
            Console.ReadKey();
        }
    }

}


