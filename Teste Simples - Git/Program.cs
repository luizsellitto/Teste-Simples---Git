try
{
    Console.WriteLine("Informe o primeiro valor!");
    int a = int.Parse(Console.ReadLine());
    Console.WriteLine("Informe o segundo valor!");
    int b = int.Parse(Console.ReadLine());
    int result = a / b;
    Console.WriteLine($"O resultado da divisão dos dois é: {result}");
}
catch (DivideByZeroException ex)
{
    Console.WriteLine(" Não se pode dividir um número por 0\n" + ex.Message);
}
catch (InvalidCastException ex)
{
    Console.WriteLine(" Não se porde digitar letras, por favor, digite um número\n" + ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine("Houve um erro\n" + ex.Message);
}