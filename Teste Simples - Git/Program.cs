Console.WriteLine("Informe o primeiro valor!");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Informe o segundo valor!");
int b = int.Parse(Console.ReadLine());
if (b !=0)
{
int result = a / b;
Console.WriteLine($"O resultado da divisão dos dois é: {result}");
}
else
{
    Console.WriteLine(" Não se pode dividir um número por 0");
}