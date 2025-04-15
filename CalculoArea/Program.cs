namespace CalculoArea
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Calculo c = new Calculo();
            int x;
            Console.WriteLine("Vamos calcular a área de uma figura retangular:");
            Console.WriteLine("Digite a altura em metros:");
            c.AlturaRetangulo = Convert.ToDouble( Console.ReadLine());
            Console.WriteLine("Digite a base em metros:");
            c.BaseRetangulo = Convert.ToDouble( Console.ReadLine());
            c.CalculoArea();
            Console.WriteLine("Caso queira exibir o valor da àrea digite 1;\nCaso queira ver os valores armazenados digite 2;");
            x = int.Parse( Console.ReadLine() );
            switch (x) 
            {
                case 1:
                    c.ExibirArea();
                    break;

                case 2:
                    c.ExibirValores();
                    break;
                default:
                    Console.WriteLine("Opção Invalida");
                    break;
            }


        }
    }
}