Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Welcome To the Number Analyzer 2000,");
Console.WriteLine();
Console.WriteLine("\"We'll Analyze Your Numbers!\"");
Console.WriteLine();
Console.ResetColor();
Console.WriteLine("**Please Press Any Key To Continue**");
Console.ReadKey();
Console.Clear();

Console.WriteLine("To Begin Number Analysis, Please Enter Your Name:");
string userName = Console.ReadLine();
Console.WriteLine();
Console.WriteLine($"Thank You {userName}, Let's Begin....");
Console.WriteLine();
Console.WriteLine("**Please Press Any Key To Continue**");
Console.ReadKey();
Console.Clear();

//


bool shouldRunAnalyzer = true;
int totalNumbersAnalyzed = 1;

while (shouldRunAnalyzer)
{
    if (totalNumbersAnalyzed == 1)
    {
        Console.WriteLine($"If You Could Please {userName}, Enter A Number Between 1 And 100");
    }
    else
    {
        Console.WriteLine($"{userName}, Please Enter A New Number Between 1 And 100");
    }

    int userNumberInput = int.Parse(Console.ReadLine());
    Console.WriteLine();

    if (userNumberInput >= 1 && userNumberInput <= 100)
    {
        if (userNumberInput % 2 == 0)
        {
            if (userNumberInput > 60)
            {
                Console.WriteLine($"Congratulations {userName}, The Number: {userNumberInput} Is Even And Greater Than 60!");
                Console.WriteLine("Neat!");
            }
            else if (userNumberInput >= 2 && userNumberInput <= 24)
            {
                Console.WriteLine($"Wowza {userName}, The Number: {userNumberInput} Is Even And Less Than 25!");
                Console.WriteLine("Math Is Fun!");
            }
            else
            {
                Console.WriteLine($"{userName}, That Number Met Its Analysis Doom And The Number: {userNumberInput} Is Even And Between 26 And 60 Inclusive");
                Console.WriteLine("Zing!");
            }
        }
        else if (userNumberInput > 60)
        {
            Console.WriteLine($"Another Number Has Been Chewed Up And Analyzed {userName}, The Number: {userNumberInput} Is Odd And Greater Than 60!");
            Console.WriteLine("Having Fun Yet?");
        }
        else
        {
            Console.WriteLine($"That Was Too Easy {userName}, The Number: {userNumberInput} Is Odd And Less Than 60");
            Console.WriteLine("Next Time Try A Harder Number");
        }
    }
    else
    {
        Console.WriteLine($"{userNumberInput}???? Hey I Can't Analyze That! Try Again!");
        Console.WriteLine("(This Time Follow The Instructions!)");
    }
    Console.WriteLine();
    Console.WriteLine("Would You Like To Analyze Another Number? Enter Y Or Yes To Enter A New Number Or Press Any Other Key To Exit");
    string userAnalyzeAgainResponse = Console.ReadLine().ToLower();

    if (userAnalyzeAgainResponse == "yes" || userAnalyzeAgainResponse == "y")
    {
        Console.Clear();
        totalNumbersAnalyzed++;

    }
    else
    {
        shouldRunAnalyzer = false;
    }
}

Console.Clear();
Console.WriteLine($"Thank You {userName} For Analazing Numbers Today!");
Console.WriteLine();
Console.WriteLine("Good Bye!");


//Console.ReadKey();
