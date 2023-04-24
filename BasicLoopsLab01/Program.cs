while (true)
{
    Console.WriteLine("Hello World!");
    Console.WriteLine("Would you like to continue? (y/n)");
    string input = Console.ReadLine();
    if (input == "n")
    {
        break;
    }
}



while (true)
{
    Console.WriteLine("Please enter a number:");
    int userNumber = int.Parse(Console.ReadLine());
    for (int i = userNumber; i >= 0; i--)
    {
        Console.WriteLine(i);
    }

    Console.WriteLine("Would you like to continue? y/n");
    string input = Console.ReadLine();
    if (input == "n")
    {
        break;
    }
}

bool codeCheck = false;
while (codeCheck == false)
{
    for (int i = 1; i <= 5; i++)
    {

        Console.WriteLine("Please enter your passcode:");
        string input = Console.ReadLine();

        if (input == "13579")
        {
            Console.WriteLine("Welcome home.");
            break;
        }
        else if(i == 5)
        {
            Console.WriteLine("You have made too many incorrect attempts.");
            break;
        }
        else
        {
            Console.WriteLine("Please try again.");
        }
        codeCheck = true;
    }
}




bool keyCheck = false;
do
{

    for (int i = 1; i <= 5; i++)
    {
        Console.WriteLine("Please enter key code:");
        string input = Console.ReadLine();

        if (input == "13579")
        {
            Console.WriteLine("Welcome home.");
            break;
        }
        else if (i == 5)
        {
            Console.WriteLine("You have made too many attempts.");
            break;
        }
        else
        {
            Console.WriteLine("Please try again.");
        }

    }

    keyCheck = true;

} while (keyCheck == false);




