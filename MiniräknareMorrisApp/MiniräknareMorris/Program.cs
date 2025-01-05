using System.Security.Cryptography.X509Certificates;

namespace MiniräknareMorris
{
    public class Program
    {
        static void Main(string[] args)
        {
            Calculator add = new Calculator();
            add.Sum(1,2);
            
            
            Console.ReadLine();
        }
    }
}
public class Calculator
{
    public void Sum(int x, int y)
    {
       
        Console.WriteLine($"{x} + {y} = {x + y}" );
            
    }
}