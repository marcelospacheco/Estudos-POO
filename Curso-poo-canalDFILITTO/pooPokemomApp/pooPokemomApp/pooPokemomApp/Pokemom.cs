using System;
using System.Collections.Generic;
using System.Text;

namespace pooPokemomApp
{
    public class Pokemom
    {
        public Pokemom()//CONSTRUTOR
        {
            this.Nome = "";
            this.Descricao = "";
        }
        private String nome;

        public String Nome
        {
            get { 
                return this.nome;
            }
            set {
                String texto = value.ToUpper();
                nome = texto;
            }
        }

        private String descricao;//Armazena o valor de propriedade descricao

        public String Descricao//representa a caractristca Descricao do meu pokemom
        {
            get { return this.descricao; }
            set { 
                this.descricao = value.ToUpper();
            }
        }

        public void ExibirDadosPokemom()
        {
            Console.WriteLine($"Nome do Pokémom {this.Nome}");
            Console.WriteLine($"Descrição do Pokémom {this.Descricao}");
        }

    }
}
