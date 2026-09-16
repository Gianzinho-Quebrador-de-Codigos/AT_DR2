using System;
using System.Collections.Generic;
using System.Text;

namespace AT
{
    internal class Funcionario
    {
        private string nome;
        private string cargo;
        private double salario;

        public Funcionario(string nome, string cargo, double salario)
        {
            this.nome = nome;
            this.cargo = cargo;
            this.salario = salario;
        }

        public string GetNome()
        {
            return nome;
        }

        public string GetCargo()
        {
            return cargo;
        }

        public double GetSalario()
        {
            return salario;
        }

    }
}
