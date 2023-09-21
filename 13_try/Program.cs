public class program
{
    public static void Main()
   { 
    try{
    Console.WriteLine("Digite um numero inteiro");
    int numero = int.Parse(Console.ReadLine());
    Console.WriteLine($"Você digitou o n° {numero}"); 
    }
   catch (Exceptin erro)
   {
    Console.WriteLine($"Ocorreu um erro: {erro.message}");
   }
}

}