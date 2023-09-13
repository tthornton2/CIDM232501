namespace HW3_2;

class Program
{
    static void Main(string[] args)
    {
Console.WriteLine("Please enter a number lower than 10.");
int n = int.Parse(Console.ReadLine());    

    for (int row = 0; row<n; row++)
    {
        for(int col = 0; col<n; col++)
    {
        Console.Write("#");
    }
        Console.WriteLine("");
    }
    }
}
