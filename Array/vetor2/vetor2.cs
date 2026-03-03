//using Array.vetor2;
//using System.Globalization;

//namespace Array
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {

//            int n = int.Parse(Console.ReadLine());

//            Product[] vet = new Product[n];
//            for (int i = 0; i < n; i++)
//            {
//                string name = Console.ReadLine();
//                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//                vet[i] = new Product { Name = name, Price = price };
//            }
//            double suma = 0.0;
//            for (int i = 0; i < n; i++)
//            {
//                suma += vet[i].Price;
//            }
//            double avg = suma / n;
//            Console.WriteLine($"Preço medio = {avg.ToString("F2", CultureInfo.InvariantCulture)}");

//        }

//    }
//}
