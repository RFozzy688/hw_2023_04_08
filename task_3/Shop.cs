using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    internal class Shop : IDisposable
    {
        public string NameShop { get; set; }
        public string Address { get; set; }
        public string TypeShop { get; set; }
        public Shop(string name, string address, string typeShop)
        {
            NameShop = name;
            Address = address;
            TypeShop = typeShop;
        }
        public override string ToString()
        {
            return $"Название: {NameShop}\nАдрес: {Address}\nТип магазина: {TypeShop}";
        }
        public void Dispose()
        {
            Console.WriteLine("Очистка ресурсов метод Dispose() class Shop");
        }
        ~Shop() 
        {
            Console.WriteLine("Отработал финализатор class Shop");
        }
    }
}
