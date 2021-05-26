namespace Calculadora
{
    public class Validacao
    {
        public static string Validar(string op)
        {

            if (op == "+" || op == "01" || op == "1") { op = 1.ToString(); }
            else if (op == "-" || op == "02" || op == "2") { op = 2.ToString(); }
            else if (op == "*" || op == "03" || op == "3") { op = 3.ToString(); }
            else if (op == "/" || op == "04" || op == "4") { op = 4.ToString(); }
            else if (op == "%" || op == "05" || op == "5") { op = 5.ToString(); }

            return op;
        }
    }
}