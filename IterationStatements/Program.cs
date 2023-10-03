namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        static void AdderAndSubtracter()
        {
            int num = 0;
            while(num < 1000)
            {
                Console.WriteLine($"Increasing: {num}");
                num++;
            }

            while (num >= -1000)
            {
                Console.WriteLine($"Decreasing: {num}");
                num--;
            }
        }

        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        static void AdderBy3()
        {
            int num = 3;
            while (num <= 999)
            {
                Console.WriteLine($"Increasing by 3: {num}");
                num += 3;
            }
        }

        //Write a method to accept two integers as parameterss and check whether they are equal or not
        static void EqualTester()
        {
            Console.WriteLine("Give me two numbers and i will check whether they are equal to one another.");
            var a = int.Parse(Console.ReadLine());
            Console.WriteLine("Now, Give me a second number.");
            var b = int.Parse(Console.ReadLine());
            var result = (a == b) ? "They are Equal." : "They are not equal.";
            Console.WriteLine(result);
        }

        //Write a method to check whether a given number is even or odd
        static void EvenOrOdd()
        {
            Console.WriteLine("Give me a number and i will check whether it is even or odd.");
            var a = int.Parse(Console.ReadLine());
            var result = (a % 2 == 0) ? "This number is even." : "This number is odd";
            Console.WriteLine(result);
        }

        //Write a method to check whether a given number is positive or negative
        static void PositiveOrNegative()
        {
            Console.WriteLine("Give me a number and i will check whether it is positive or negative.");
            var a = int.Parse(Console.ReadLine());
            if (a > 0 && a != 0)
            {
                Console.WriteLine($"{a} is positive");
            }
            else if (a < 0 && a != 0)
            {
                Console.WriteLine($"{a} is negative");
            }
            else
            {
                Console.WriteLine($"{a} has no value");
            }
        }

        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()
        static void VoterAgeCheck()
        {
           Console.WriteLine("What is your age?");
           var voterAge = int.Parse(Console.ReadLine());
           var result = (voterAge >= 18) ? "You can vote" : "You are too young to vote.";
           Console.WriteLine(result);
        }

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        static void NumberRangeChecker()
        {
            Console.WriteLine("Give me a number to check and I will tell you if it is within a -10 to 10 range.");
            var number = int.Parse(Console.ReadLine());
            var result = (number < 11 && number > -11) ? "The number is within range" : "The number is outside of range.";
            Console.WriteLine(result);
        }

        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        static void MultiplicationTable()
        {
            Console.WriteLine("Give me a number and I will give you its multiplication table.");
            var a = int.Parse(Console.ReadLine());
            for (int i = 1; i < 13; i++)
            {
                var result = a * i;
                Console.WriteLine($"{a} times {i} is: {result}");
            }

        }

        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            AdderAndSubtracter();

            AdderBy3();

            EqualTester();

            EvenOrOdd();

            PositiveOrNegative();

            VoterAgeCheck();

            NumberRangeChecker();

            MultiplicationTable();

        }
    }
}
