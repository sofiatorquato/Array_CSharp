using Array.vetor3;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {

            Estudante e;

            int n = int.Parse(Console.ReadLine());

            Estudante[] vet = new Estudante[10];

            Console.WriteLine("Informe a quantidade de estudantes que irão alugar: ");
            int est = int.Parse(Console.ReadLine());

            for (int i = 0; i < est; i++)
            {
                Console.WriteLine("Informe o nome: ");
                string name = Console.ReadLine();

                Console.WriteLine("Informe o email: ");
                string email = Console.ReadLine();

                Console.WriteLine("Informe o número do quarto: ");
                int quarto = int.Parse(Console.ReadLine()); 

                vet[i] = new Estudante(name, email, quarto);

            }




        }
    }
}