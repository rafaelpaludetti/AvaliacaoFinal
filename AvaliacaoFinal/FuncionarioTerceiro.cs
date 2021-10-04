using System;
using System.Collections.Generic;
using System.Text;

namespace AvaliacaoFinal
{
    class FuncionarioTerceiro : Funcionario
    {
        public string EmpresaOrigem { get; set; }
        public double TaxaServico { get; set; }

        public FuncionarioTerceiro(string nome, int cargaHoraria, double valorHora, string empresaOrigem, double taxaServico) 
            : base(nome, cargaHoraria, valorHora)
        {
            EmpresaOrigem = empresaOrigem;
            TaxaServico = taxaServico;
        }

        public FuncionarioTerceiro()
        {

        }

        public override double CalculaSalario()
        {
            return base.CalculaSalario() * (TaxaServico / 100 + 1);
        }

        public override void ImprimeDados()
        {
            base.ImprimeDados();
            Console.WriteLine("Empresa Origem: " + EmpresaOrigem);
        }



    }
}
