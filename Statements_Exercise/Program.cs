// Exercise 1

static void GuessMyNumber()
{
    Console.WriteLine("Try to guess what number I\'m thinking of between 1 and 10!");


    var r = new Random();
    var favNumber = r.Next(1, 10);
    bool tryAgain = true;
    //var userInput = int.Parse(Console.ReadLine());
    do
    {
       var userInput = int.Parse(Console.ReadLine());

        if (userInput == favNumber)
        {
            Console.WriteLine("\n You Guessed my number correctly!");
            tryAgain = false;

        }
        else if (userInput < favNumber && userInput >= 1)
        {
            Console.WriteLine("The number you guessed is too low, try again.");

        }
        else if (userInput > favNumber && userInput <= 10)
        {
            Console.WriteLine("The number you guessed is too high, try again.");

        }
        else if (userInput <= 0 || userInput >= 11)
        {
            Console.WriteLine("You did not guess a number between 1 and 10, try again.");
        }

    } while (tryAgain);
}

GuessMyNumber();


// Exercise 2

static void SchoolSubject()
{
    Console.WriteLine("\n\n What is your favorite school subject?");

    var answer = Convert.ToString(Console.ReadLine());

    switch (answer)
    {

        case "math":
            Console.WriteLine("Oh, so you like numbers?");
            string reply = Console.ReadLine();
            if (reply == "yes")
            {
                Console.WriteLine("That\'s awesome, maybe engineering could be your career.");
            }
            else
            {
                Console.WriteLine("It\'s all about the challenges.");
            }
            break;


        case "english":
            Console.WriteLine("Do you enjoy reading and writing?");
            string reply2 = Console.ReadLine();
            if (reply2 == "yes")
            {
                Console.WriteLine("You could make writing a career!");
            }
            else
            {
                Console.WriteLine("Then it must be about social skills.");
            }
            break;


        case "history":
            Console.WriteLine("History is important to learn from past mistakes.");
            break;

        case "science":
            Console.WriteLine("The study of science is very important to society.");
            break;

        case "art":
            Console.WriteLine("I see you\'re the creative type!");
            break;

        default:
            Console.WriteLine("I did not include that subject.");
            break;
    }
}

SchoolSubject();
