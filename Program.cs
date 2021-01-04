using System;
using Aula_POO_Estaticos.Classes;

namespace Aula_POO_Estaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Math.Pow(2,5));

            Console.WriteLine("Digite um valor");
            Conversor.valorUsuario = float.Parse(Console.ReadLine());
            Console.WriteLine("valor de dolar para real é : ");
            Console.WriteLine(Conversor.ConverterDolarParaReal());
            Console.WriteLine("valor de real para dolar é : ");
            Console.WriteLine(Conversor.ConverterRealParaDolar());
            Console.WriteLine("valor de euro para para real é : ");
            Console.WriteLine(Conversor.CoverterEuroParaReal());
            Console.WriteLine("valor de real para euro é : ");
            Console.WriteLine(Conversor.ConverterRealParaEuro());
        }
    }
}
