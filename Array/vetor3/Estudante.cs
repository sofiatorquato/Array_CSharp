namespace Array.vetor3
{
    internal class Estudante
    {

        public string Name { get; set; }
        public string Email { get; set; }
        public int Quarto { get; set; }


        public Estudante (string name, string email, int quarto)
        {
            Name = name;
            Email = email;
            Quarto = quarto;
        }

        public override string ToString()
        {
            return $"{Quarto}: {Name}, {Email}";
        }
    }

}
