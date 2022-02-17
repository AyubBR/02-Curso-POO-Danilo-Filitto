namespace AreaRetangulo
{
    public class AreaRetangulo
    {
        static void Main (string[] args)
        {
            Retangulo retangulo = new Retangulo();
            Console.WriteLine("Programa Cálculo Área");
            Console.WriteLine("Infome o valor da base do retângulo");
            retangulo.Baseretangulo = Convert.T (Console.ReadLine());
            Console.WriteLine("Infome o valor da altura do retângulo");
            retangulo.Alturaretangulo = Console.ReadLine();
        }
    }
}
