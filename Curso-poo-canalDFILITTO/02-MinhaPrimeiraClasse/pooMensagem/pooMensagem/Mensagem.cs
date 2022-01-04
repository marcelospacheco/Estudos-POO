using System;
using System.Collections.Generic;
using System.Text;

namespace pooMensagem
{
    public class Mensagem
    {
        //private string TextoMensagem;

        // public void ExibirMensagem() 
        // {
        //     Console.WriteLine(this.TextoMensagem);
        // }

        // public String getTextoMensagem() 
        // {
        //     return this.TextoMensagem;
        // }

        // public void setTextoMensagem(string valor) 
        // {
        //     this.TextoMensagem = valor.ToUpper();
        // }

        private String textoMensagem;
        public String TextoMensagem 
        {
            get 
            {
                return
                     this.textoMensagem;
            }

            set
            {
                this.textoMensagem = value.ToUpper();
            }
        }

        public void ExibirMensagem()
        {
            Console.WriteLine(this.TextoMensagem);
        }
    }
}
