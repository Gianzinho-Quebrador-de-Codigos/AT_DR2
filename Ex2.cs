using System;
using System.Collections.Generic;
using System.Text;

namespace AT
{
    internal class Ex2
    {
        static void Main(string[] args)
        {
            char[] letrasMin = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            char[] letrasMai = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

            Console.WriteLine("Digite seu nome completo:");
            string nome = Console.ReadLine();

            char[] caracteres = nome.ToCharArray();

            for(int i = 0; i < caracteres.Length; i++)
            {
                for(int j = 0; j < letrasMai.Length; j++)
                {
                    if (caracteres[i] == letrasMai[j])
                    {
                        caracteres[i] = letrasMai[(j + 2) % letrasMai.Length];
                        break;
                    }
                    if (caracteres[i] == letrasMin[j])
                    {
                        caracteres[i] = letrasMai[(j + 2) % letrasMai.Length];
                        break;
                    }
                }
            }

            string nomeCriptografado = new string(caracteres);
            Console.WriteLine(nomeCriptografado);
        }
    }
}
