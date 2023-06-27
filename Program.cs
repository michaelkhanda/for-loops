using System;

namespace forloop
{
    class Program
    {
        static void Main(string[] args)
        {
            int score, total = 0;
            for (int i = 0; i < 5; i++)
            {

                Console.WriteLine("Enter a score: ");
                score = int.Parse(Console.ReadLine());
                total = total + score;
            }
            double average = total / 5;
            Console.WriteLine("The average of the scores is:" + average);

        }
    }
}
