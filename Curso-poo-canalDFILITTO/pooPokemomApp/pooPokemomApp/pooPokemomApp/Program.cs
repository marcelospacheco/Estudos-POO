using System;

namespace pooPokemomApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Pokemom p = new Pokemom();
            p.Nome = "Bulbassauro";
            p.Descricao = "Bulbassauro é um pokémom tipo planta...";
            p.ExibirDadosPokemom();

            Console.ReadKey();
        }
    }
}
