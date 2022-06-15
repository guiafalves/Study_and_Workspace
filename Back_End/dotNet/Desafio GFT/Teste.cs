using System;



namespace DIO

{

  class Program

  {

    static void Main(string[] args)

    {

      int n, nota, quociente, resto;



      n = int.Parse(Console.ReadLine());

      Console.WriteLine(n);



      resto = n;

      nota = 100;

      quociente = resto / 100;

      Console.WriteLine($"{quociente} nota(s) de R$ {nota},00");

      resto = resto % 100;

    resto = n;

      nota = 50;

      quociente = resto /50;

      Console.WriteLine($"{quociente} notas(s) de R$ {nota},00");

      resto = resto % 50;

       

      resto = n;

      nota = 20;

      quociente = resto /20;

      Console.WriteLine($"{quociente} notas(s) de R$ {nota},00");

      resto = resto % 20;

       

      resto = n;

      nota = 10;

      quociente = resto /10;

      Console.WriteLine($"{quociente} notas(s) de R$ {nota},00");

      resto = resto % 10;

       

      resto = n;

      nota = 05;

      quociente = resto /05;

      Console.WriteLine($"{quociente} notas(s) de R$ {nota},00");

      resto = resto % 05;

       

      resto = n;

      nota = 02;

      quociente = resto /02;

      Console.WriteLine($"{quociente} notas(s) de R$ {nota},00");

      resto = resto % 02;

       

      resto = n;

      nota = 01;

      quociente = resto /01;

      Console.WriteLine($"{quociente} notas(s) de R$ {nota},00");

      resto = resto % 01;

    }

  }

}