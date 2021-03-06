using System;
using System.Collections.Generic;
using System.Text;

namespace MediaAluno
{
    class Aluno
    {
        public Aluno()
        {
            this.Nome = "";
            this.Nota1 = 0;
            this.Nota2 = 0;
        }

        public string Nome { get; set; }
        private string Nota1, Nota2;
        

        public void ApresentarAluno()
        {
            Console.WriteLine($"Boa tarde, sou o aluno {Nome.ToUpper()}"); 
        }

        public void ReceberNotas(string Nota1, string Nota2)
        {
            Console.WriteLine($"A nota do 1º semestre foi: {Nota1}");
            Console.WriteLine($"A nota do 2º semestre foi: {Nota2}");
        }

        public void CalcularMedia(decimal Nota1, decimal Nota2)
        {
            if(Nota1>0 && Nota2 > 0)
            {
                var media = (Nota1 + Nota2) / 2;
                Console.WriteLine(media);
            }
            else
            {
                Console.WriteLine("Insira valores VÁLIDOS");
            }
            
        }
        

        
    }
}
