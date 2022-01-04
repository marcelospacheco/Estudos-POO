using System;

namespace pooMensagem
{
    class Program
    {
        static void Main(string[] args)
        {
            Mensagem msg1, msg2;
            msg1 = new Mensagem();
            msg1.TextoMensagem = "Alô mundo!";
            msg1.ExibirMensagem();

            //msg2 = new Mensagem();
            ////msg2.TextoMensagem = "Segundo OBJ!";
            //msg2.ExibirMensagem();
            
            Console.ReadKey();
        }
    }
}
