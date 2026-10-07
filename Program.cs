int[]NumeroCand, votos, idades;
int n, i;
string[]nome;

do
{
    Console.WriteLine("informe a quantidade de candidatos que irão concorrer");
    n = int.Parse(Console.ReadLine());
}while(n<5 || n>10);

nome = new string[n];

for (i=0; i < nome.Length; i++)
{
    Console.WriteLine($"Informe o nome desse candidato {i+1}: ");
    nome[i] = Console.ReadLine();
}

