namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void NumbersThousand(int ceiling, int floor)
        {
            for (int i =1000;i >= -1000;i--)
            {
                Console.WriteLine(i);
            }
        }

        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void CountbyThrees()
        {
            for (int a=3; a <= 999; a += 3)
            {
                Console.WriteLine(a);
            }
        }

        //Write a method to accept two integers as parameterss and check whether they are equal or not
        public static bool AreTheyEqual(int b, int c)
        {
            var check = (b == c)? true: false;
            return check;
        }
        
        //Write a method to check whether a given number is even or odd
        public static void EvenOrOdd()
        {
            Console.WriteLine("Enter a number to see if the machine can determine if it is even or odd:");
            var userInput = int.TryParse(Console.ReadLine(), out int number);
            if (userInput == true)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine("This is even");
                }
                else
                {
                    Console.WriteLine("This is odd");
                }
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }
        
        //Write a method to check whether a given number is positive or negative
        public static bool PositiveOrNeg()
        {
            Console.WriteLine("Enter a postive or negative number and to see the machine run");
            var userInput = int.Parse(Console.ReadLine());
            if(userInput >= 0)
            {
                return true;
            }
            return (false);//can do this without the else statement
        }
        
        //Write a method to read the age of a candidate and determine whether they can vote.
        public static bool CanYouVote()
        {
            Console.WriteLine("What is your age");
            var userInput = int.Parse(Console.ReadLine());
      
             if (userInput >= 18)
                {
                    Console.WriteLine("You can vote!");
                    return true;
                }
             else
                {
                    Console.WriteLine("No vote from you");
                    return false;
                }
        }
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()
        public static int[] RandomChallenge()
        {
            Console.WriteLine($"How many items are in your array?");

            var userInput = int.Parse(Console.ReadLine());

            var newArray = new int[userInput];

            for (int i = 0; i < newArray.Length; i++)
            {
                var random = new Random();
                newArray[i] = random.Next(1, 500);
            }
            return newArray;
        }

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        public static bool RangeTen()
        {
            Console.WriteLine("Enter a number and the machine will see if its in our range:");
            var number = int.Parse(Console.ReadLine());
            if (number <= 10 && number >= -10)
            {
                Console.WriteLine($"This is in range!");
                return true;
            }
            Console.WriteLine("Not in range.");
            return false;
        }
        
        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        public static void MultiplyMe()
        {
            Console.WriteLine("Pick a number to see its multiplication table");
            var userInput = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{i} * {userInput} = {userInput * i}");
            }
        }


        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            NumbersThousand(1000,-1000);

            CountbyThrees();

            Console.WriteLine(AreTheyEqual(6,9));

            EvenOrOdd();

            PositiveOrNeg();

            CanYouVote();

            RandomChallenge();

            RangeTen();

            MultiplyMe();

        }

    }
}
