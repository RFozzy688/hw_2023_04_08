//Завдання 3: 
//Додайте до першого завдання реалізацію інтерфейсу IDisposable. 
//Додайте до другого завдання реалізацію деструктора. Напишіть 
//код для тестування нових можливостей. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shop shop_1 = new Shop("Магазин 1", "Адрес 1", "Одежда");
            Shop shop_2 = new Shop("Магазин 2", "Адрес 2", "Обувь");

            Console.WriteLine(shop_1 + "\n");
            Console.WriteLine(shop_2 + "\n");

            shop_1.Dispose();
            shop_2.Dispose();

            Console.WriteLine();

            Piece piece_1 = new Piece("Ревизор", "Николай Гоголь", "Комедия", 1836);
            Piece piece_2 = new Piece("Вишневый сад", "Антон Чехов", "Драма", 1903);

            Console.WriteLine(piece_1 + "\n");
            Console.WriteLine(piece_2 + "\n");

            piece_1.Dispose();
            piece_2.Dispose();
        }
    }
}
