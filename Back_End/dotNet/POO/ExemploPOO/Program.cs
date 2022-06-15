using static System.Console;
using System;
using ExemploPOO.Models;

namespace ExemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            // Person p1 = new Person();
            // p1.Name = "Bob";
            // p1.Age = 20;

            // p1.Apresentar();

            rectangle r = new rectangle();
            r.measurements(30, 30);

            WriteLine($"Área: {r.getArea()}");
        }
    }
}