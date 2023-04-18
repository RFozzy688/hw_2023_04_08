//Завдання 1: 
//Створіть клас «П'єса», який має зберігати таку інформацію: 
//  назва п'єси; 
//  П.І.Б. автора; 
//  жанр; 
//  рік.
//Реалізуйте у  класі  методи  та  властивості, необхідні  для 
//функціонування класу. 
//Додайте  до  класу  деструктор.  Напишіть  код  для  тестування 
//функціональності класу. 
//Напишіть код для деструктора.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Piece piece_1 = new Piece("Ревизор", "Николай Гоголь", "Комедия", 1836);
            Piece piece_2 = new Piece("Вишневый сад", "Антон Чехов", "Драма", 1903);

            Console.WriteLine(piece_1);
            Console.WriteLine();
            Console.WriteLine(piece_2);
        }
    }
}
