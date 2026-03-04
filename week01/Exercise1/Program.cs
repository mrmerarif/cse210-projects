using System;

class Program
{ 
    static void Main(string[] args)
    {
        // Ask the user for their first and last name, then display it in the format "Last Name, First Name Last Name" 
        Console.WriteLine("What is your first name? "); 
        string firstName = Console.ReadLine(); 
        
        Console.Write("What is your last name? "); 
        string lastName = Console.ReadLine(); 
        
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }
}