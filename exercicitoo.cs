namespace exercicito
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            float anosServindo;

            Console.WriteLine("Digite seu nome: ");
            nome =  Console.ReadLine();


            Console.WriteLine("Digite a quantidade de anos servidos, " + nome + " : ");
            anosServindo = int.Parse(Console.ReadLine());

            if (anosServindo == 2)
            {
                Console.WriteLine("Caro," + nome + " sua patente é a de:  soldado de 1ª classe. ");
            }
            else if (anosServindo == 1)
            {
                Console.WriteLine("Caro," + nome + " sua patente é a de: CABO DO EXERCITO. ");

            }
            else if(anosServindo >= 15)
            {
                Console.WriteLine("Caro, " + nome + " sua patente é a de: Major, Tenente-Coronel ou Coronel. ");
            }
        }
    }
}