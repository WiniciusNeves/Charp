class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Calculadora");

        Console.WriteLine("Informe um valor de x: ");
        float valor = int.Parse(Console.ReadLine());

        Console.WriteLine("Informe um valor de y: ");
        float valor1 = int.Parse(Console.ReadLine());

        Console.WriteLine($"a soma e: {valor + valor1}");
        Console.WriteLine($"a subtracao e: {valor - valor1}");
        Console.WriteLine($"a multiplicacao e: {valor * valor1}");

        double divisao = (double)valor / valor1;
        Console.WriteLine($"a divisao e: {divisao}");

        float media = (valor + valor1) / 2;
        Console.WriteLine($"a media e: {media}");

        Console.WriteLine($"o resto da divisao e: {valor % valor1}");

        Console.WriteLine($"a raiz quadrada de x: {Math.Sqrt(valor)}");
        Console.WriteLine($"a potencia de x: {Math.Pow(valor, valor1)}");
        Console.WriteLine($"Valor minino : {Math.Min(valor, valor1)}");
        Console.WriteLine($"Valor maximo : {Math.Max(valor, valor1)}");
        Console.WriteLine($"Conseno de x : {Math.Cos(valor)}");
        Console.WriteLine($"Seno de x : {Math.Sin(valor)}");
        Console.WriteLine($"Exponencial de x : {Math.Exp(valor)}");



    }
}
