using System;
using System.Collections.Generic;
using System.Text;

namespace AT
{
    internal class Ex6
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno("João", 12345, "Computação", 8.5);

            aluno.varificarAprovacao();
        }
    }
}
