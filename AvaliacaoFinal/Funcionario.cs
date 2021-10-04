using System;
using System.Collections.Generic;
using System.Text;

namespace AvaliacaoFinal
{
    class Funcionario
    {
        private string _nome;
        private int _cargaHoraria;
        private double _valorHora;
        
        public string Nome { get => _nome; set => _nome = value; }
        public int CargaHoraria { get => _cargaHoraria;  private set => _cargaHoraria = value; }
        public double ValorHora { get => _valorHora; private set => _valorHora = value; }

        public Funcionario(string nome, int cargaHoraria, double valorHora)
        {
            Nome = nome;
            CargaHoraria = cargaHoraria;
            ValorHora = valorHora;
        }

        public Funcionario()
        {

        }

        public virtual double CalculaSalario()
        {
            return ValorHora * CargaHoraria;
        }

        public virtual void ImprimeDados()
        {
            string msg = $"\nNome: {Nome} \nSalário: {CalculaSalario()}";
            //string msg = "Nome: " + Nome + 
            //             "Salário: " + CalculaSalario(); 
            Console.WriteLine(msg);
        }
    }
}
