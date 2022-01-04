using System;
using System.Collections.Generic;
using System.Text;

namespace ControleDeAnimais
{
    class Animal
    {
        private String nome;

        public String Nome
        {
            get { return this.nome; }
            set { this.nome = value.ToUpper(); }
        }

        private String tipo;

        public String Tipo
        {   //valores prédefinidos pelo proprietário - Gato, Cachorro, Peixe
            get { return this.tipo; }
            set {
                    if (value == "Cachorro" || value == "Gato" || value == "Peixe")
                    {
                        tipo = value;
                    } 
                    else
                    {
                        tipo = "Peixe";
                    }
            }

        }
    }
}
