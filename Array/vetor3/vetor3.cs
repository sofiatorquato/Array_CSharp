using Array.vetor3;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {

            Estudante[] vet = new Estudante[10];

            Console.WriteLine("Informe a quantidade de estudantes que irão alugar: ");
            int est = int.Parse(Console.ReadLine());



            for (int i = 0; i < est; i++)
            {
                Console.WriteLine("Informe o nome: ");
                string name = Console.ReadLine();

                Console.WriteLine("Informe o email: ");
                string email = Console.ReadLine();

                Console.WriteLine("Informe o número do quarto (0-9): ");
                int quarto = int.Parse(Console.ReadLine());


                
                while (quarto<0 || quarto>9 || vet[quarto]!=null)
                {
                    Console.WriteLine("Quarto indisponível! Escolha outro quarto: ");
                    quarto = int.Parse(Console.ReadLine());
                }
                
                vet[quarto] = new Estudante (name, email);

            }

            Console.WriteLine("Quartos ocupados: ");
            for (int i = 0; i < 10; i++)
            {
                if (vet[i] != null)
                {
                    Console.WriteLine($"{i}: {vet[i]}");
                }
            }



        }
    }
}