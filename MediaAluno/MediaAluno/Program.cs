using System;


namespace MediaAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            var notaDig1;
            var notaDig2;

            Aluno al1 = new Aluno();

            Console.WriteLine("PROGRAMA BÁSICO CALCULA A MÉDIA DE UM ALUNO");
            Console.WriteLine("Aplicando (ou tentando, kkk) os pilares da POO");

            Console.WriteLine("Digite o nome do aluno: ");
            al1.Nome = Console.ReadLine();

            Console.WriteLine("Digite a 1ª nota: ");
            notaDig1 = Console.ReadLine();

            Console.WriteLine("Digite a 2ª nota: ");
            notaDig2 = Convert.ToDecimal(Console.ReadLine());

            al1.ApresentarAluno();
            al1.ReceberNotas(notaDig2, notaDig2);
            al1.CalcularMedia(notaDig1, notaDig2);

        }
    }
}
