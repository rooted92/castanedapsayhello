//Pedro Castaneda
//10-17-2022
//Say Hello
//Simple program that asks your name and gives a response

string username;
string userInput;
bool run = false;

while(!run)
{
    Console.WriteLine("Hello, what is your name?");

    username = Console.ReadLine();

    Console.WriteLine($"Nice to meet {username}");
    Console.WriteLine();

    Console.WriteLine("Would you like run this program again? (yes/no)");
    userInput = Console.ReadLine();

    if(userInput == "yes" || userInput == "y")
    {
        run = false;
    }
    else if(userInput == "no" || userInput == "n")
    {
        Console.WriteLine($"Goodbye {username}!");
        run = true;
    }
    else
    {
        Console.WriteLine("Please enter yes or no!");
    }
}