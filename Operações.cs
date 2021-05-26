using System;

namespace Calculadora
{
    public class Operações
    {

        public static float Soma(float valor)
        {
            Console.Clear();
            float v1 = 0;
            System.Console.WriteLine("|--------------------------------------------------------|");
            System.Console.WriteLine("|---------------------< ( + ) Soma >---------------------|");
            System.Console.WriteLine("|--------------------------------------------------------|");

            if (valor == 0)
            {
                System.Console.Write($"Informe o Primeiro Valor: ");
                v1 = float.Parse(Console.ReadLine());
            }
            else
            {
                v1 = valor;
                System.Console.Write($"Informe o Primeiro Valor: {v1} ");
            }

            System.Console.Write($"Informe o Segundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());
            float resultado = v1 + v2;
            System.Console.WriteLine($"Valor 1: {v1}  e Valor 2: {v2} Soma é  ==> {resultado}");
            return resultado;
        }


        public static float Subtracao(float valor)
        {
            Console.Clear();
            float v1 = 0;
            System.Console.WriteLine("|--------------------------------------------------------|");
            System.Console.WriteLine("|------------------< ( - ) Subitração >------------------|");
            System.Console.WriteLine("|--------------------------------------------------------|");

            if (valor == 0)
            {
                System.Console.Write($"Informe o Primeiro Valor: ");
                v1 = float.Parse(Console.ReadLine());
            }
            else
            {
                v1 = valor;
                System.Console.Write($"Informe o Primeiro Valor: {v1} ");
            }

            System.Console.Write($"Informe o Segundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());
            float resultado = v1 - v2;
            System.Console.WriteLine($"Valor 1: {v1}  e Valor 2: {v2} Subitração é  ==> {resultado}");
            return resultado;
        }

        public static float Mutiplicar(float valor)
        {
            Console.Clear();
            float v1 = 0;
            System.Console.WriteLine("|--------------------------------------------------------|");
            System.Console.WriteLine("|------------------< ( * ) Mutiplicação >----------------|");
            System.Console.WriteLine("|--------------------------------------------------------|");

            if (valor == 0)
            {
                System.Console.Write($"Informe o Primeiro Valor: ");
                v1 = float.Parse(Console.ReadLine());
            }
            else
            {
                v1 = valor;
                System.Console.Write($"Informe o Primeiro Valor: {v1} ");
            }

            System.Console.Write($"Informe o Segundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());
            float resultado = v1 * v2;
            System.Console.WriteLine($"Valor 1: {v1}  e Valor 2: {v2} Mutiplicação é  ==> {resultado}");
            return resultado;
        }

        public static float Dividir(float valor)
        {
            Console.Clear();
            float v1 = 0;
            System.Console.WriteLine("|--------------------------------------------------------|");
            System.Console.WriteLine("|---------------------< ( / ) Divisão >------------------|");
            System.Console.WriteLine("|--------------------------------------------------------|");

            if (valor == 0)
            {
                System.Console.Write($"Informe o Primeiro Valor: ");
                v1 = float.Parse(Console.ReadLine());
            }
            else
            {
                v1 = valor;
                System.Console.Write($"Informe o Primeiro Valor: {v1} ");
            }

            System.Console.Write($"Informe o Segundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());
            float resultado = v1 / v2;
            System.Console.WriteLine($"Valor 1: {v1}  e Valor 2: {v2} Divisão é  ==> {resultado}");
            return resultado;
        }

        public static float Percentual(float valor)
        {
            Console.Clear();
            float v1 = 0;
            System.Console.WriteLine("|--------------------------------------------------------|");
            System.Console.WriteLine("|------------------< ( % ) Percentual >------------------|");
            System.Console.WriteLine("|--------------------------------------------------------|");

            if (valor == 0)
            {
                System.Console.Write($"Informe Valor: ");
                v1 = float.Parse(Console.ReadLine());
            }
            else
            {
                v1 = valor;
                System.Console.Write($"Valor Informado: {v1} ");
            }

            System.Console.Write($"Informe o ( % ) Percentual: ");
            float v2 = float.Parse(Console.ReadLine());
            float resultado = v1 * (v2 / 100);
            System.Console.WriteLine($"Valor 1: {v1}  e Valor 2: {v2} % é  ==> {resultado}");
            return resultado;
        }



    }
}