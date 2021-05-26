namespace Calculadora
{
    public class finalizarsys
    {
        public static void Exit()
        {
            System.Console.Clear();
            System.Console.WriteLine("|--------------------------------------------------------|");
            System.Console.WriteLine("|------------------< Sistema Finalizado >----------------|");
            System.Console.WriteLine("|--------------------------------------------------------|");
            System.Environment.Exit(0);
        }
    }
}