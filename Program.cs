decimal salariohora, salario, salariohoraextra, salariohoraextratotal, salariototal;
int hora, horaextra;

Console.Clear();

Console.WriteLine("Digite seu salário-hora base:");
salariohora = Convert.ToDecimal(Console.ReadLine()!);

Console.WriteLine("Digite seu total de horas trabalhadas:");
hora = Convert.ToInt32(Console.ReadLine()!);

Console.WriteLine("Digite sua quantidade de horas-extras trabalhadas:");
horaextra = Convert.ToInt32(Console.ReadLine()!);

calculaSalario(salariohora, hora, horaextra);

Console.Clear();

Console.WriteLine("--- Salário ---");

Console.WriteLine("");

Console.Write("Salário-hora: ");
corVerde();
Console.WriteLine($"{salariohora:C2}");
Console.ResetColor();

Console.Write("Horas trabalhadas: ");
corVerde();
Console.WriteLine($"{hora}h");
Console.ResetColor();

Console.Write("Bônus por horas-extras: ");
corVerde();
Console.WriteLine($"{salariohoraextra:C2}");
Console.ResetColor();

Console.Write("Total de horas-extras: ");
corVerde();
Console.WriteLine($"{horaextra}h");
Console.ResetColor();

Console.WriteLine("");

Console.Write("Salário final: ");
corVerde();
Console.WriteLine($"{salariototal:C2}");
Console.ResetColor();

void corVerde()
{
    Console.ForegroundColor = ConsoleColor.Green;
}

decimal calculaSalario(decimal salariohora, decimal hora, decimal horaextra)
{
    salario = salariohora * hora;

    salariohoraextra = salariohora * 0.40m;

    salariohoraextratotal = salariohoraextra * horaextra;

    salariototal = salario + salariohoraextratotal;

    return salariototal;
}