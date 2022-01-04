using System;
using Classes.Aluno;

namespace MediaAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno1 = new Aluno();

            Console.WriteLine("Digite o nome do aluno: ");
            aluno1.nome = Console.ReadLine();

            Console.WriteLine("Digite o sobrenome do aluno: ");
            aluno1.sobrenome = Console.ReadLine();

            Console.WriteLine("Digite a turma: ");
            aluno1.turma = Console.ReadLine();

            Console.WriteLine("Digite a Nota bimestre 1: ");
            string nota1 = Console.ReadLine();
            int num_nota1 = Int32.Parse(nota1);

            
            //aluno1.nota1 = nota1;
            //aluno1.nota2 = 6;

            Console.WriteLine($"O nome do aluno completo: {aluno1.nome} {aluno1.sobrenome}");
            //Console.WriteLine($"O sobrenome do aluno é: {aluno1.sobrenome}");
            Console.WriteLine($"A turma é: {aluno1.turma}");
            Console.WriteLine($"Anota no Bimestre 1 foi: {num_nota1}");




        }
    }
}
