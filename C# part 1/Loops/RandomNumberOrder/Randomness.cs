using System;
using System.Linq;


class Randomness
{
    static void Main()
    {
        int input = 0;
        bool isInputNumber = int.TryParse(Console.ReadLine(), out input);

        int[] randomNumbers = new int[input];
        Random random = new Random();

        for (int i = 0; i < input; i++)
        {
            int number;

            do
            {
                number = random.Next(input+1);
            } while (randomNumbers.Contains(number));

            randomNumbers[i] = number;
        }

        for (int i = 0; i < input; i++)
        {
            Console.Write(randomNumbers[i]+ " ");
        }
    }
}

