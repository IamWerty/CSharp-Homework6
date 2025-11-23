using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Homework6
{
    internal class Magazin : IDisposable
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Type { get; set; }

        private bool disposed = false;

        public Magazin(string name, string address, string type)
        {
            Name = name;
            Address = address;
            Type = type;
        }

        public void Show()
        {
            Console.WriteLine($"Магазин: {Name}, Адреса: {Address}, Тип: {Type}");
        }

        public void Dispose()
        {
            if (!disposed)
            {
                Console.WriteLine($"Викликано Dispose() для магазину: {Name}");
                disposed = true;
            }
        }
    }
}
