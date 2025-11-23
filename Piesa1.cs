using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Homework6
{
    internal class Piesa : IDisposable
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }

        private bool disposed = false;

        public Piesa(string name, string author, string genre, int year)
        {
            Name = name;
            Author = author;
            Genre = genre;
            Year = year;
        }

        public void Show()
        {
            Console.WriteLine($"П'єса: {Name}, Автор: {Author}, Жанр: {Genre}, Рік: {Year}");
        }

        public void Dispose()
        {
            if (!disposed)
            {
                Console.WriteLine($"Dispose() для п'єси: {Name}");
                disposed = true;
            }
        }

        ~Piesa()
        {
            if (!disposed)
            {
                Console.WriteLine($"Деструктор для п'єси: {Name}");
            }
        }
    }
}
