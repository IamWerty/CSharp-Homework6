using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Homework6
{
    internal class Piesa
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }


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

        ~Piesa()
        {
            Console.WriteLine($"Деструктор викликано для п'єси: {Name}");
        }
    }
}
