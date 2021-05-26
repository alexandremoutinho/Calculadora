using System;
using System.Collections.Generic;

namespace Calculadora
{
    public class ExtratoLanc
    {

        public List<Historico> historicos = new List<Historico>();

        public static void LancHist(string texto)
        {
            var hist = new ExtratoLanc();
            var h = new Historico();
            h.HistoricoLanc = texto;
            hist.historicos.Add(new Historico { HistoricoLanc = texto });


        }

        public static void PrintExtrato()
        {
            var hist = new ExtratoLanc();


            System.Console.Clear();
            System.Console.WriteLine("|--------------------------------------------------------|");
            System.Console.WriteLine("|----------------< Histórico de Lançamento >-------------|");
            System.Console.WriteLine("|--------------------------------------------------------|");
            if (hist.historicos.Count > 0)
            {
                foreach (var item in hist.historicos)
                {
                    System.Console.WriteLine($"Movimento:  {item.HistoricoLanc}");
                    System.Console.WriteLine("|------------------------------------------------------|");


                }
                System.Console.WriteLine($"Total de Lançamento:  {hist.historicos.Count}");
            }
            else
            {

                System.Console.WriteLine("|----------------< Não Possui Lançamento >--------------|");

            }

            Console.ReadKey();


        }


    }
}