
var alunos = new List<Aluno>();

for (int i = 0; i < 2; i++)
{
    Console.WriteLine($"Aluno {i+1}:");
    Console.Write("digite o nome do aluno: ");
    var nome = Console.ReadLine();
    Console.Write("digite a idade do aluno: ");
    var idade = Convert.ToInt32(Console.ReadLine());
    Console.Write("digite o sexo do aluno: ");
    var sexo = Console.ReadLine();
    Console.Write("digite se o aluno foi aprovado ou reprovado: ");
    var aprovado = Console.ReadLine();
    alunos.Add(new Aluno() { nome = nome, idade = idade, sexo = sexo, aprovado = aprovado });
}

var cursos = new List<Curso>();
cursos.Add(new Curso());

foreach (var aluno in alunos)
{
    cursos[0].Resultado(aluno.nome, aluno.idade, aluno.sexo, aluno.aprovado);
}

public class Aluno
{
    public string? nome { get; set; }
    public int? idade { get; set; }
    public string? sexo { get; set; }
    public string? aprovado { get; set; }
}
public class Curso
{
    public void Resultado(string? nome, int? idade, string? sexo, string? aprovado)
    {


        Console.WriteLine($"{nome} {idade} {sexo}");
        if (aprovado == "aprovado")
        {
            System.Console.WriteLine($"{aprovado}");
        }
        else
        {
            Console.WriteLine($"o aluno foi reprovado");
        }

    }
}
