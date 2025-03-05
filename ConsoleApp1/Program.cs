namespace ConsoleApp1
{
    internal class Program
    {
        
        
        static void Main(string[] args)
        {
            FizzBuzz count = new FizzBuzz();
            count.Display();
            Console.WriteLine("Hello, World!");
        }
    }
}
class FizzBuzz
{
    public int topLimit = 20;

    public void Display()
    {
        for (int i = 0; i < topLimit; ++i)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }
}
