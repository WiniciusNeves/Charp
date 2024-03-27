using System;
using System.Data;

class Exercicios_1
{
    static void Main()
    {
        int idade = 35;
        string nome = "Maria";
        float altura = 3.45f;
        DateTime data = new DateTime(1999, 9, 4);

        Console.WriteLine("Olá, eu tenho {0} anos, meu nome é {1}, minha altura é {2}, minha data de nascimento é {3}", idade, nome, altura, data.ToString("dd/MM/yyyy"));

        int ano = 12;
        double? nota = null;
        nota = 7.80;

        Console.WriteLine("O ano {0} e a nota {1}", ano, nota);

        int x = 77, y = 66;
        Console.WriteLine("A Soma é: {0}", x + y);
    }
}
