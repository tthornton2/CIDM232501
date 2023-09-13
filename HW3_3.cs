namespace HW3_3;

class Program
{
    static void Main(string[] args)
    {   Console.WriteLine("Please input a number: ");
        int N = Convert.ToInt16 (Console.ReadLine());
        
        for(int row = 0; row<N; row++){
            for(int col = 0; col<N; col++)
            {
                if(row>col)
                    {                   
                        Console.Write("*");
                    }
            }
            Console.WriteLine("");

        }
    }
}
