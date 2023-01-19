using System;
using System.Runtime.CompilerServices;


namespace HelloWorll
{

    public class Program
    {

        public static void Main(string[] args)
        {
            double a = 20;
            double b = 10;

            Math math = new Math();
            double addResult = math.Add(a, b);
            
            double substractResult = math.Substract(a, b);
            
            Console.WriteLine(addResult.ToString());
            
            Console.WriteLine(substractResult.ToString());
        }
    }
    
}