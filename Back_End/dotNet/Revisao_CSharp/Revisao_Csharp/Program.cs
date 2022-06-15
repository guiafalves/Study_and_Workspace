using System;

namespace Revisao_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            aluno[] alunos = new aluno[5];
            var indiceAluno = 0;
            string opcaoUsuario = obterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                    Console.WriteLine("Informe o nome do aluno:");
                    aluno aluno = new aluno();
                    aluno.Nome = Console.ReadLine();
                    Console.WriteLine("Informe a nota do aluno:");
                    if (decimal.TryParse(Console.ReadLine(), out decimal nota))
                    {
                    aluno.Nota = nota;
                    }
                    else
                    {
                        throw new ArgumentException("O valor da nota deve ser decimal.");
                    }
                    alunos[indiceAluno] = aluno;
                    indiceAluno++;
                        //TODO: adiconar aluno
                        break;
                    case "2":
                        foreach(var a in alunos)
                        {
                            if (!string.IsNullOrEmpty(a.Nome))
                            {
                            Console.WriteLine($"ALUNO: {a.Nome} - NOTA: {a.Nota}");
                            }
                        }
                        //TODO: listar alunos
                        break;
                    case "3":
                    decimal notaTotal = 0;
                    var nrAlunos = 0;
                    for (int i=0; i < alunos.Length; i++)
                    { 
                        if(!string.IsNullOrEmpty(alunos[i].Nome))
                        { 
                            notaTotal = notaTotal + alunos[i].Nota;
                            nrAlunos++;
                        }
                    }
                    var mediaGeral = notaTotal / nrAlunos;
                    Console.WriteLine($"Média Geral: {mediaGeral}");
                        //TODO: calcular media geral
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                } 
            
                opcaoUsuario = obterOpcaoUsuario();

            }
        }

        private static string obterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine("1- Inserir novo aluno");
            Console.WriteLine("2- Listar alunos");
            Console.WriteLine("3- Calcular média geral");
            Console.WriteLine("X - sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}
