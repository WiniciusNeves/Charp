using System;

class Program
{
    static void Main()
    {
        var nome = "Paulo";
        var idade = 17;
        var nota = 7.5f;

        Console.WriteLine($"Nome: {nome},\nIdade: {idade},\nNota: {nota}");


        Console.WriteLine("Por favor, digite três letras.");

        Console.Write("Digite a primeira letra: ");
        char letra1 = Console.ReadKey().KeyChar;
        Console.WriteLine();
            
        Console.Write("Digite a segunda letra: ");
        char letra2 = Console.ReadKey().KeyChar;
        Console.WriteLine();
            
        Console.Write("Digite a terceira letra: ");
        char letra3 = Console.ReadKey().KeyChar;
        Console.WriteLine();

        string ordemReversaConcatenacao = letra3.ToString() + letra2 + letra1;
        string ordemReversaInterpolacao = $"{letra3}{letra2}{letra1}";

        Console.WriteLine("\nAs letras digitadas em ordem reversa são:");
        Console.WriteLine($"Usando concatenação: {ordemReversaConcatenacao}");
        Console.WriteLine($"Usando interpolação: {ordemReversaInterpolacao}");



        int num1 = 0, num2 = 0, num3 = 0, maior = 0;
        Console.WriteLine("Por favor, digite três números.");
        num1 = int.Parse(Console.ReadLine());
        num2 = int.Parse(Console.ReadLine());
        num3 = int.Parse(Console.ReadLine());

        maior = num1;
        if (num2 > maior){
            maior = num2;
        }else if (num3 > maior){
            maior = num3;
        }
        Console.WriteLine("O maior número é: " + maior);

        Console.WriteLine("calculo de equação de segundo grau");
        int a, b, c;
        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());
        c = int.Parse(Console.ReadLine());

        double delta = Math.Pow(b, 2) - (4 * a * c);
        if (delta > 0)
        {

            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine("Ambas as raízes são reais e diferentes");
            Console.WriteLine($"Primeira raiz x1= {x1}");
            Console.WriteLine($"Segunda raiz x2= {x2}");
        }
        else if (delta == 0)
        {
         
            double x1 = -b / (2 * a);
            Console.WriteLine("Existe uma única raiz real");
            Console.WriteLine($"Raiz x1= {x1}");
        }
        else
        {
           
            Console.WriteLine("As raízes são imaginárias;");
            Console.WriteLine("Sem solução para os números reais.");}
    }
}
