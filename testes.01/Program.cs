using System;

namespace Diamond
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {

                #region variaveis
                string alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                char[] letras = alfabeto.ToCharArray();
                int contadorLetras = 0, espacoInterno = 0;
                // declaração local
                char letrasDiamante;
                #endregion
                Console.WriteLine("Insira uma letra do alfabeto, só funciona com (E) kkkkkkkkkkkk)");
                letrasDiamante = Convert.ToChar(Console.ReadLine());


                #region contador
                for (int i = 0; i <= letras.Length; i++)
                {
                    if (letrasDiamante == letras[i])
                    {
                        contadorLetras++;
                        break;
                    }
                    else contadorLetras++;
                }
                #endregion

                #region espaços da parte de cima:

                for (int linha = 0; contadorLetras > 0; linha++)
                {
                    //espaços
                    for (int i = 0; i < contadorLetras - 1; i++)
                    {
                        Console.Write(" ");
                    }

                    //letras
                    Console.Write(letras[linha]);

                    //espaço dentro
                    for (int i = 1; i < espacoInterno; i++)
                    {
                        Console.Write(" ");
                    }

                    //p/ nao mostrar a letra duas vezes na 1 linha
                    if (linha != 0)
                        Console.Write(letras[linha]);

                    contadorLetras--;
                    espacoInterno += 2;
                    Console.WriteLine();
                    Console.WriteLine();
                    #endregion
                }
                int letra = 3;
                contadorLetras = 1;
                espacoInterno = 7;

                for (int linha = 1; espacoInterno > 0; linha++)
                {
                    for (int i = 1; i <= contadorLetras; i++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(letras[letra]);
                    //espaço de dentro
                    for (int i = 1; i <= espacoInterno - 2; i++)    
                    {
                        Console.Write(" ");
                    }
                //mostras a letra com a condição de nao repetir
                if(linha != 4)
                        Console.Write(letras[letra]);

                    letra--;
                    contadorLetras++;
                    espacoInterno -= 2;
                    Console.WriteLine();
                    Console.WriteLine();

                    
                        
                }
                Console.ReadKey();


            }

        }

    }
         
           
    }
    


