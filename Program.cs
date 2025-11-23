using CSharp_Homework6;
using System;
using System.Text;

Console.OutputEncoding = System.Text.Encoding.UTF8;

Piesa p = new Piesa("Наталка Полтавка", "Котляревський", "Драма", 1819);
p.Show();
Magazin m = new Magazin("Аврора", "Мікроампер", "Епіцентр");
m.Show();
m.Dispose();
