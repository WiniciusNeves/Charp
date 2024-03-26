class Program
{
    static void Main(string[] args)
    {
        double raio, perimetro, area;
        const double PI = 3.14159;

        Console.WriteLine("Digite o valor do raio: ");
        raio = double.Parse(Console.ReadLine());
        perimetro = 2 * PI * raio;
        area = PI * raio * raio;
        Console.WriteLine("Perimetro=" + perimetro.ToString("F4"));
        Console.WriteLine("A=" + area.ToString("F4"));
    }
}
