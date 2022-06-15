using System;
using static System.Console;

class Program
{
    static void Main(string[] args)
{
    int valor = int.Parse(ReadLine());
    int [] notas = { 100, 50, 20, 10, 5, 2, 1};
    int total = 0;
    WriteLine(valor);

    for (int i=0; i < notas.Length; i++)
    {
        total = valor / notas[i];
        WriteLine($"{total} notas(s) de R$ {notas[i]}, 00");
        valor %= notas[i];
    }
}
}


using System;

class MinhaClasse {
  public static void Main (string[] args) {
    var totalDeCasosDeTeste = int.Parse(Console.ReadLine());
    // Implemente a solução aqui