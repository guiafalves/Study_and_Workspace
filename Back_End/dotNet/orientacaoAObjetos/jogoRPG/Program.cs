using static System.Console;
using jogoRPG.src.Entities;

namespace jogoRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero hero = new Hero( "BruxoBG", 39, "Magic", 80, 83);
            Tank guardian = new Tank( "Cirino", 44, "Tank", 70, 75);
            Tower saints = new Tower( "Rony", 01, "Tower", 99, 70);
        
            
            WriteLine(hero.Attack());
            WriteLine(guardian.Attack(7));
            WriteLine(saints.Attack());
            

        }
    }
}
