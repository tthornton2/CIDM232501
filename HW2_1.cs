namespace HW2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter your letter grade.");
        string letter = Console.ReadLine();
 

        if (letter == "A"){
            Console.WriteLine("4 GPA Points");
        }
        else if (letter == "B"){ 
            Console.WriteLine("3 GPA Points");
        }
        else if (letter == "C"){ 
            Console.WriteLine("2 GPA Points");
        }
        else if (letter == "D"){ 
            Console.WriteLine("1 GPA Points");
        }
        else if (letter == "F"){
            Console.WriteLine("0 GPA Points");
        }
        else
        {
            Console.WriteLine("Try again!");
        }
        

    }
}
