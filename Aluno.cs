using System;
using System.Collections.Generic;
using System.Text;

namespace AT
{
    internal class Aluno
    {
        string nome;
        int matricula;
        string curso;
        double media;

        public Aluno(string nome, int matricula, string curso, double media)
        {
            this.nome = nome;
            this.matricula = matricula;
            this.curso = curso;
            this.media = media;
        }

        public void varificarAprovacao()
        {

            if (media >= 7)
            {
                Console.WriteLine("Aluno Aprovado");
            }
            else
            {
                Console.WriteLine("Aluno Reprovado");
            }

        }
    }
}
