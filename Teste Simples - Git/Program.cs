Console.WriteLine("Informe o primeiro valor!");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Informe o segundo valor!");
int b = int.Parse(Console.ReadLine());
try
{
int result = a / b;
Console.WriteLine($"O resultado da divisão dos dois é: {result}");
}
catch (Exception ex)
{
    Console.WriteLine(" Não se pode dividir um número por 0 " + ex.Message);
}