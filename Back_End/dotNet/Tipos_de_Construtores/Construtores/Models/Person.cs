namespace Construtores.Models
{
    public class Person
    {
        private string name;
        private string lastname;

        public Person()
        {
           name = string.Empty;
           lastname = string.Empty; 
        }
        public Person(string name, string lastname)
        { 
            this.name = name;
            this.lastname = lastname;
            }
        public void Apresentar()
        { 
            System.Console.WriteLine($"Olá, meu nome é: {name} {lastname}");

        }
        }
}