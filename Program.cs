using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palidromo
{
    class Program
    {
        public static bool Palidromo(string palavra, int posicaoInicial, int posicaoFinal)
        {
            if (palavra.Length < 3)
            {
                return false;
            }
            else if (palavra[posicaoInicial] != palavra[posicaoFinal])
            {
                return false;
            }
            else if (posicaoInicial > posicaoFinal)
            {
                return true;
            }
            else
            {
                return Palidromo(palavra, posicaoInicial + 1, posicaoFinal - 1);
            }

        }

        static void Main(string[] args)
        {
            string palavra;

            Console.WriteLine("Digite aqui uma palavra: ");
            palavra = Console.ReadLine().Replace(" ", null);

            bool resultado = Palidromo(palavra, 0, palavra.Length - 1);

            if (resultado == false)
            {
                Console.WriteLine("Não é palindromo!");
            }
            else
            {
                Console.WriteLine("É palindromo!");
            }

            Console.ReadKey();
        }
    }
}
