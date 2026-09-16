using System;
using System.Collections.Generic;
using System.Text;

namespace AT
{
    internal class Gerente : Funcionario
    {
        public Gerente(string nome, string cargo, double salario) : base(nome, cargo, salario * 1.2)
        {

        }
    }
}
