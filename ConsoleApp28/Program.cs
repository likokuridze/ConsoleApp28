// See https://aka.ms/new-console-template for more information
using ConsoleApp28;

class Program
{
    static void Main(string[] args)
    {
        int number1 = 10;
        int number2 = 5;

        // შეკრება
        int sum = MathHelper.Add(number1, number2);
        Console.WriteLine($"შეკრება: {number1} + {number2} = {sum}");

        // გამოკლება
        int difference = MathHelper.Subtract(number1, number2);
        Console.WriteLine($"გამოკლება: {number1} - {number2} = {difference}");

        // გამრავლება
        int product = MathHelper.Multiply(number1, number2);
        Console.WriteLine($"გამრავლება: {number1} * {number2} = {product}");

        // გაყოფა
        try
        {
            double quotient = MathHelper.Divide(number1, number2);
            Console.WriteLine($"გაყოფა: {number1} / {number2} = {quotient}");

            Console.WriteLine("\nვცდილობთ ნულზე გაყოფას:");
            double divideByZero = MathHelper.Divide(number1, 0);
        }
        catch (Exception ex)
        {
            // დაიჭერს და დაბეჭდავს Exception-ის მესიჯს
            Console.WriteLine($"შეცდომა: {ex.Message}");
        }

    }
}