using System.Runtime.CompilerServices;

namespace HW3;

class Program
{
    static void Main(string[] args)
    {
                    int n, i, m=0, p=0;

        Console.WriteLine("Please enter a number to see if it is prime.");
        n= int.Parse(Console.ReadLine());
        m=n/2;
            for(i = 2; i <= m / 2; i++) 
            {
                if (n%i==0)
                {
                    Console.Write("Number is not Prime.");
                    p=1;
                    break;
                }
            }
            if(p==0)
            Console.Write("Number is Prime.");
    
    }

}
