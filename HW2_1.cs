namespace HW2_2;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Please enter your first number:");
        string input1 = Console.ReadLine();
        
        Console.WriteLine("Please enter your second Number:");
        string input2 = Console.ReadLine();
        
        Console.WriteLine("Please enter your third Number:");
        string input3 = Console.ReadLine();

        if (int.TryParse(input1, out int num1) && int.TryParse(input2, out int num2) && int.TryParse(input3, out int num3))
        { //asked AI for some help (below) clearing up my num/input convertion chatgpt, 9/10/23
            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine($"{num1} is the largest number");
            }
            else if (num2 > num3)
            {
                Console.WriteLine($"{num2} is the largest number");
            }
            else
            {
                Console.WriteLine($"{num3} is the largest number");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter valid numbers.");
        }
    }
}


