public class Program
{
    public static void Main(string[] args)
    {
        //Variables
        //camelCase for variable names = everyOtherWordStartsWithCapital
        
        //Number types
        //Declaring a variable (creation of a variable)
        int wholeNumber;
        
        //Initializing a variable (giving a value to a variable)
        wholeNumber = 5;
        
        //Or do both
        //Declaring and Initialzing
        int myAge = 30;
        
        double average = 99.87;

        decimal myAccount = 5000.00m;
        
        //Word types

        string ourClass = "CSharp-52";

        char initial = 'S';
        
        //Fact types
        
        bool isCoding = true;
        
        //String interpolation

        //string message = $"I am {myAge} years old";

        //Console.WriteLine($"I am {myAge} years old and I have {myAccount} in my account.");
        
        //Take user input
        
        Console.WriteLine("Give me your name:");
        
        string userName = Console.ReadLine();

        Console.WriteLine($"Hello, {userName}!");
    }
}