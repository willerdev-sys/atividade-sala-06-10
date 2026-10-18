int[]NumeroCand, votos, idades;
int n, i, j, m, voto;
string[]nome;

do
{
    Console.WriteLine("informe a quantidade de candidatos que irão concorrer");
    n = int.Parse(Console.ReadLine());
}while(n<5 || n>10);

nome = new string[n];
idades = new int[n];
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

Console.WriteLine("informe a quantidade de eleitores irão votar");
m = int.Parse(Console.ReadLine());

votos = new int[n];

for (i=0; i < m; i++)
{
    Console.WriteLine($"Informe o numero do candidato que você irá votar {i+1}: ");
    voto = int.Parse(Console.ReadLine());
    for(j=0;j<n;j++)
    if(voto == NumeroCand[j])
    {
        votos[j]++;
    }
}

for (i=0; i<votos.Length;i++)
{
Console.WriteLine($"{votos[i]} - ");
}