using Models;

public class Program
{
    public static void Main()
    {
       

        Pessoa pessoa1 = new Pessoa("Alberto Roberto", 16);


        pessoa1.Cantar();

        Pessoa pessoa2 = new Pessoa("Marcos", 17);
        pessoa2.Cantar();

        Pessoa pessoa3 = new Pessoa("Ronaldo", 18);
        pessoa3.Cantar();
        
    }
}