using System;
using System.Collections.Generic;

namespace AvaliacaoFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> lstFuncionario = new List<Funcionario>();
            Boolean finish = false;

            while (!finish)
            {
                Console.WriteLine("\nSelecione uma ação para continuar");
                Console.WriteLine("Digite 1 para cadastrar um funcionário" + "\n" + "Digite 2 para visualizar os dados de um funcionário" + "\n" + "Digite 3 para sair: ");
                string selectedOption = Console.ReadLine();

                if(string.IsNullOrEmpty(selectedOption) || (selectedOption != "1" && selectedOption != "2" && selectedOption != "3"))
                {
                    Console.WriteLine("Por favor, selecione uma opção válida");
                }
                else
                {
                    switch (selectedOption)
                    {
                        case "1":
                            Console.WriteLine("\nDigite o nome do funcionário: ");
                            string nome = Console.ReadLine();
                            Console.WriteLine("Digite a carga horária do funcionario: ");
                            int cargaHoraria = int.Parse(Console.ReadLine());
                            Console.WriteLine("Digite o valor da hora do funcionario: ");
                            int valorHora = int.Parse(Console.ReadLine());
                            Console.WriteLine("Este funcionário é terceiro? Digite 1 para sim e 2 para não: ");
                            string isTerceiro = Console.ReadLine();
                            if(string.IsNullOrEmpty(isTerceiro) || (isTerceiro != "1" && isTerceiro != "2"))
                            {
                                Console.WriteLine("\nPor favor, selecione uma opção válida");
                            }
                            else
                            {
                                switch (isTerceiro)
                                {
                                    case "1":
                                        Console.WriteLine("Digite a empresa deste terceiro: ");
                                        string empresaOrigem = Console.ReadLine();
                                        Console.WriteLine("Digite a taxa de serviço: ");
                                        double taxaServico = double.Parse(Console.ReadLine());
                                        Funcionario objFuncionario = new FuncionarioTerceiro(nome, cargaHoraria, valorHora, empresaOrigem, taxaServico);
                                        lstFuncionario.Add(objFuncionario);
                                        Console.WriteLine("\nFuncionário terceiro adicionado com sucesso");
                                        break;
                                    case "2":
                                        Funcionario objFuncionario2 = new Funcionario(nome, cargaHoraria, valorHora);
                                        lstFuncionario.Add(objFuncionario2);
                                        Console.WriteLine("\nFuncionário interno adicionado com sucesso");
                                        break;
                                }
                            }
                            break;
                        case "2":
                            Console.WriteLine("\nDigite o nome do funcionario que deseja visualizar: ");
                            string nomePesquisa = Console.ReadLine();
                            Funcionario objFuncionarPesquisa = lstFuncionario.Find(x => x.Nome == nomePesquisa);
                            if(objFuncionarPesquisa != null)
                            {
                                objFuncionarPesquisa.ImprimeDados();
                            }
                            else
                            {
                                Console.WriteLine("\nFuncionário não encontrado");
                            }
                                
                            break;
                        case "3":
                            finish = true;
                            break;
                    }
                }
            }

        }
    }
}
