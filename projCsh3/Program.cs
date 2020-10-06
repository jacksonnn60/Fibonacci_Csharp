using System;
namespace projCsh3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write your count of numbers Fibonachi you want to see: ");

            int counter = int.Parse(Console.ReadLine());

            Console.Clear();

            int[] numbers =  new int[counter];

            numbers[0] = 1;
            numbers[1] = 1;

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);



            for (int i = 1; i != numbers.Length - 1; i++)

            {

                numbers[i + 1] = numbers[i] + numbers[i - 1];  
                
                
                Console.WriteLine(numbers[i + 1]);
            }

        }
    }
}
