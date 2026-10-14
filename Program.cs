int[]NumeroCand, votos, idades;
int n, i, j;
string[]nome;
int candidato1 = 0, candidato2 = 0, candidato3 = 0, candidato4 = 0, candidato5 = 0, candidato6 = 0, candidato7 = 0, candidato8 = 0, candidato9 = 0;

do
{
    Console.WriteLine("informe a quantidade de candidatos que irão concorrer");
    n = int.Parse(Console.ReadLine());
}while(n<5 || n>10);

nome = new string[n];
idades = new int[n];
votos = new int[n];
NumeroCand = new int[n];

for (i=0; i < n; i++)
{
    Console.WriteLine($"Informe o nome desse candidato {i+1}: ");
    nome[i] = Console.ReadLine();

    Console.WriteLine($"Informe a idade desse candidato {i+1}: ");
    idades[i] = int.Parse(Console.ReadLine());

    Console.WriteLine($"Informe o numero desse candidato {i+1}: ");
    NumeroCand[i] = int.Parse(Console.ReadLine());
}

for (i=0; i < NumeroCand.Length; i++)
{
    Console.WriteLine($"Informe a quantidade de votos desse candidato {i+1}: ");
    votos[i] = int.Parse(Console.ReadLine());
}