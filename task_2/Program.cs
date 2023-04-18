//Завдання 2: 
//Створіть клас «Магазин», який має зберігати таку інформацію: 
//  назва магазину; 
//  адреса магазину; 
//  тип магазину: 
//o продовольчий,
//o  господарський,
//o  одяг,
//o  взуття. 
//Реалізуйте  у  класі  методи  та  властивості, необхідні  для функціонування класу. 
//Клас має реалізовувати інтерфейс IDisposable. Напишіть код для тестування функціональності класу. 
//Напишіть код для виклику методу Dispose. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shop shop_1 = new Shop("Магазин 1", "Адрес 1", "Одежда");
            Shop shop_2 = new Shop("Магазин 2", "Адрес 2", "Обувь");

            Console.WriteLine(shop_1 + "\n");
            Console.WriteLine(shop_2 + "\n");
        }
    }
}
