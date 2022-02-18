using System;

namespace Teste2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string alfabeto = "abcdefghijklmnopqrstuvwxyz";
            char [] letras = alfabeto.ToCharArray();
            char letrasDiamante;
            Console.WriteLine("Digite alguma letra do alfabeto");
            letrasDiamante = Convert.ToChar(Console.ReadLine());
            // contadores
            int contadorletras = 0, contadorespaco = 0;

            #region contador
            for (int i = 0; i <= letras.Length; i++)
            {
                if (letrasDiamante == letras[i])
                {
                    contadorletras++;
                    break;
                }
                else contadorletras++;
            }
            #endregion

            #region espaços da parte de cima:

            for (int linha = 0; contadorletras > 0; linha++)
            {
                //espaços
                for (int i = 0; i < contadorletras - 1; i++)
                {
                    Console.Write(" ");
                }

                //letras
                Console.Write(letras[linha]);

                //espaço dentro
                for (int i = 1; i < contadorespaco; i++)
                {
                    Console.Write(" ");
                }

                //p/ nao mostrar a letra duas vezes na 1 linha
                if (linha != 0)
                    Console.Write(letras[linha]);

                contadorletras--;
                contadorespaco += 2;
                Console.WriteLine();
                Console.WriteLine();
                #endregion
            }




            Console.ReadKey();
        }
    }
}
