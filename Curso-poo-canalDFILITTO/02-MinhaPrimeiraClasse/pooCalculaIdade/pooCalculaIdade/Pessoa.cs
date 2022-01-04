using System;
using System.Collections.Generic;
using System.Text;

namespace pooCalculaIdade
{
    public class Pessoa
    {
        public Pessoa(String nomePessoa, int anoNascimentoPessoa)
        {
            this.Nome = nomePessoa;
            this.AnoNascimento = anoNascimentoPessoa;
            this.CalcularIdade();
        }

        //proriedades class pessoa
        private int anoNascimento;//variavel private que armazena uma propriedade do OBJ pessoa;
        public int AnoNascimento //cria a propriedade AnoNascimento
        {
            get { return this.anoNascimento; }
            set { this.anoNascimento = value; }
        }

        private String nome;
        public String Nome
        {
            get { return this.nome; }
            set { this.nome = value.ToUpper(); }
        }

        //vamos melhorar
        private int idade;

        public int Idade
        {
            get {
                this.CalcularIdade();
                return this.idade; 
            }
            
        }

        public void ExibirDados() 
        {
            Console.WriteLine("Nome: " + this.Nome);
            Console.WriteLine("Ano de Nascimento: " + this.AnoNascimento);
            this.CalcularIdade();
            Console.WriteLine("Idade: " + this.Idade);
        }

        private void CalcularIdade()
        {
            DateTime data = DateTime.Now;
            int ano = data.Year;
            this.idade = ano - this.AnoNascimento;


        }


    }
}
