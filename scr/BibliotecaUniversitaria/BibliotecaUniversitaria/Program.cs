
using System;

Console.WriteLine("================================");
Console.WriteLine(" SISTEMA DE BIBLIOTECA");
Console.WriteLine("================================");

Console.Write("Digite o nome do membro: ");
string nome = Console.ReadLine() ?? "";

Console.Write("Digite a quantidade de emprestimos ativos: ");
int emprestimos = int.Parse(Console.ReadLine() ?? "0");

if (emprestimos < 0)
{
    Console.WriteLine("Quantidade invalida.");
}
else if (emprestimos < 3)
{
    Console.WriteLine($"{nome}, voce pode realizar um novo emprestimo.");
}
else
{
    Console.WriteLine($"{nome}, voce atingiu o limite de emprestimos.");
}

Console.WriteLine("Prazo padrao de devolucao: 14 dias.");
Console.WriteLine("================================");

