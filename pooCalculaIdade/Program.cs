namespace pooCalculaIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para calcular idade");
            Pessoa person = new Pessoa();
            Console.WriteLine("Digite o nome da pessoa:");
            person.Nome = Console.ReadLine();
            Console.WriteLine("Digite o ano de nascimento da pessoa:");
            person.AnoNascimento = Convert.ToInt32(Console.ReadLine());
            person.ExibirDados();

        }
    }
}
