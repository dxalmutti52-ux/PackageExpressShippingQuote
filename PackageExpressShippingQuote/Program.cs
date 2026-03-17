using System;

class Program
{
    static void Main()
    {
        // Display welcome message as required
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        // Ask user for package weight
        Console.WriteLine("Please enter the package weight:");
        float weight = float.Parse(Console.ReadLine());

        // Check if weight exceeds limit
        if (weight > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            return; // End program
        }

        // Ask user for package width
        Console.WriteLine("Please enter the package width:");
        float width = float.Parse(Console.ReadLine());

        // Ask user for package height
        Console.WriteLine("Please enter the package height:");
        float height = float.Parse(Console.ReadLine());

        // Ask user for package length
        Console.WriteLine("Please enter the package length:");
        float length = float.Parse(Console.ReadLine());

        // Check if total dimensions exceed limit
        if (width + height + length > 50)
        {
            Console.WriteLine("Package too big to be shipped via Package Express.");
            return; // End program
        }

        // Calculate shipping quote:
        // Multiply dimensions together, multiply by weight, then divide by 100
        float quote = (width * height * length * weight) / 100;

        // Display the quote formatted as currency
        Console.WriteLine("Your estimated total for shipping this package is: $" + quote.ToString("0.00"));
        Console.WriteLine("Thank you!");
        Console.ReadLine(); // Keeps the window open
    }
}
