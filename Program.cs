namespace FundamentalsTwo;
class Program
{
    static void Main(string[] args)
    {
        static void PrintNumbers()
        {
            for (int x = 1; x <= 255; x++)
            {
                Console.WriteLine(x);
            }
        }

        static void PrintOdds()
        {
            for (int x = 1; x <= 255; x++)
            {
                if (x % 2 != 0)
                {
                    Console.WriteLine(x);
                }
            }
        }

        static void PrintSum()
        {
            int acumulador = 0;
            for (int x = 0; x <= 255; x++)
            {
                acumulador += x;
                Console.WriteLine($"new number: {x} sum: {acumulador}");

            }
        }

        static void LoopArray(int[] numbers)
        {
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        static int FindMax(int[] numbers)
        {
            int maxNumber = numbers[0];
            foreach (int number in numbers)
            {
                if (number > maxNumber)
                {
                    maxNumber = number;
                }
            }
            return maxNumber;
        }

        static void GetAverage(int[] numbers)
        {
            int acumulador = 0;
            foreach (int number in numbers)
            {
                acumulador += number;
            }
            Console.WriteLine(acumulador / numbers.Length);
        }

        static List<int> OddList()
        {
            List<int> oddNumbers = new();
            for (int x = 0; x <= 255; x++)
            {
                if (x % 2 != 0)
                {
                    oddNumbers.Add(x);
                }
            }
            return oddNumbers;
        }

        static int GreaterThanY(List<int> numbers, int y)
        {
            // Write a function that takes an integer List, and an integer "y" and returns the number of values 
            // That are greater than the "y" value. 
            // For example, if our List contains 1, 3, 5, 7 and y is 3. Your function should return 2 
            // (since there are two values in the List that are greater than 3).
            int acumulador = 0;
            foreach (int number in numbers)
            {
                if (number > y)
                {
                    acumulador += 1;
                }
            }
            return acumulador;
        }

        static List<int> SquareArrayValues(List<int> numbers)
        {
            // Write a function that takes a List of integers called "numbers", and then multiplies each value by itself.
            // For example, [1,5,10,-10] should become [1,25,100,100]
            List<int> newNumbers = new();
            foreach (int number in numbers)
            {
                newNumbers.Add(number * number);
            }
            return newNumbers;
        }

        static List<int> EliminateNegatives(List<int> numbers)
        {
            // Given a List of integers called "numbers", say [1, 5, 10, -2], create a function that replaces any negative number with the value of 0. 
            // When the program is done, "numbers" should have no negative values, say [1, 5, 10, 0].
            List<int> newNumbers = new(numbers);
            for (int x = 0; x < newNumbers.Count; x++) {
                if (newNumbers[x] < 0) {
                    newNumbers[x] = 0;
                }
            }
            return newNumbers;
        }
        //ejecuciones
        // recomiendo ir comentarlas todas e ir descomentando una a una 
        PrintNumbers();
        PrintOdds();
        PrintSum();
        LoopArray(new int[] {1, 2, 3, 4, 5});
        Console.WriteLine(FindMax(new int[] {-1, 1, 0, 2, -3, 4, -5, -10}));
        GetAverage(new int[] {2, 10, 3});
        foreach (int number in OddList()) {
            Console.WriteLine(number);
        }
        Console.WriteLine(GreaterThanY(new List<int> { 1, 3, 5, 7 }, 3));
        foreach (int number in SquareArrayValues(new List<int> { 1, 5, 10, -10 }))
        {
            Console.WriteLine(number);
        }
        foreach (int number in EliminateNegatives(new List<int> { 1, 5, 10, -2 }))
        {
            Console.WriteLine(number);
        }
    }
}
