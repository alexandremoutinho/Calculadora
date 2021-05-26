using System;
using System.Collections.Generic;

namespace Calculadora
{
    public class Menu
    {

        public static void MenuPrincial()
        {
            List<Historico> hist = new List<Historico>();
            bool menu = true;
            float acumulado = 0;
            string extrato = "";


            while (menu == true)
            {
                Console.Clear();
                System.Console.WriteLine("|--------------------------------|");
                System.Console.WriteLine("|--------< Calculadora >---------|");
                System.Console.WriteLine("|--------------------------------|");
                System.Console.WriteLine("| 01 - ( + ) Soma                |");
                System.Console.WriteLine("| 02 - ( - ) Subtração           |");
                System.Console.WriteLine("| 03 - ( * ) Mutiplicação        |");
                System.Console.WriteLine("| 04 - ( / ) Divisão             |");
                System.Console.WriteLine("| 05 - ( % ) Percentual          |");
                System.Console.WriteLine("|--------------------------------|");
                System.Console.WriteLine("| 06 - Zerar Calculadora         |");
                System.Console.WriteLine("| 07 - Extrato Lançamento        |");
                System.Console.WriteLine("| 08 - Sair                      |");
                System.Console.WriteLine("|--------------------------------|");

                System.Console.WriteLine("\n");
                System.Console.WriteLine($"Total Geral: {acumulado}");
                System.Console.WriteLine("\n");

                try
                {
                    System.Console.Write("Escolha a Opção: ");
                    string capura = Console.ReadLine();
                    int op = int.Parse(Validacao.Validar(capura));

                    switch (op)
                    {
                        case 1:
                            acumulado = acumulado = Operações.Soma(acumulado);
                            extrato = $"Op:{op} Valor: {acumulado.ToString("R2")} Hora: {DateTime.Now.ToString()}";
                            

                            break;
                        case 2:
                            acumulado = acumulado = Operações.Subtracao(acumulado);
                            extrato = $"Op:{op} Valor: {acumulado.ToString("R2")} Hora: {DateTime.Now.ToString()}";
                            ExtratoLanc.LancHist(extrato);
                            break;

                        case 3:
                            acumulado = acumulado = Operações.Mutiplicar(acumulado);
                            extrato = $"Op:{op} Valor: {acumulado.ToString("R2")} Hora: {DateTime.Now.ToString()}";
                            ExtratoLanc.LancHist(extrato);
                            break;
                        case 4:
                            acumulado = acumulado = Operações.Dividir(acumulado);
                            extrato = $"Op:{op} Valor: {acumulado.ToString("R2")} Hora: {DateTime.Now.ToString()}";
                            ExtratoLanc.LancHist(extrato);
                            break;

                        case 5:
                            acumulado = acumulado = Operações.Percentual(acumulado);
                            extrato = $"Op:{op} Valor: {acumulado.ToString("R2")} Hora: {DateTime.Now.ToString()}";
                            ExtratoLanc.LancHist(extrato);
                            break;
                        case 6:
                            acumulado = 0;
                            extrato = $"Op:{op} Valor: {acumulado.ToString("R2")} Hora: {DateTime.Now.ToString()}";
                            ExtratoLanc.LancHist(extrato);
                            break;
                        case 7:

                            ExtratoLanc.PrintExtrato();

                            break;
                        case 8:
                            finalizarsys.Exit();
                            menu = false;
                            break;
                        default:
                            System.Console.WriteLine("Opção Invalida !!!!");
                            Console.ReadKey();
                            Menu.MenuPrincial();
                            break;
                    }

                }
                catch (System.Exception)
                {
                    System.Console.WriteLine("Opção Invalida, não permitido valor nulo!!");
                    Console.ReadKey();
                    Console.Clear();
                    MenuPrincial();


                }

            }



        }



    }
}