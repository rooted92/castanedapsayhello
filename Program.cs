//Pedro Castaneda
//10-17-2022
//Say Hello
//Simple program that asks your name and gives a response

string username;
string userInput;
bool run = false;
while(!run)
{
    bool isAnswerValid = false;
    bool replay = false;
    Console.WriteLine("Hello, what is your name?");
    while(!isAnswerValid)
    {
        username = Console.ReadLine();
        bool isAlpha = username.All(Char.IsLetter);
        if(isAlpha == false || string.IsNullOrEmpty(username))
        {
            Console.WriteLine("Invalid Entry!");
            isAnswerValid = false;
        }
        else
        {
            Console.WriteLine($"Nice to meet {username}");
            isAnswerValid = true;
        }
    }
    Console.WriteLine();
    Console.WriteLine("Would you like run this program again? (yes/no)");
    while(!replay)
    {
        userInput = Console.ReadLine();
        if(userInput == "yes" || userInput == "y")
        {
            replay = true;
            run = false;
        }
        else if(userInput == "no" || userInput == "n")
        {
            Console.WriteLine($"Goodbye!");
            replay = true;
            run = true;
        }
        else
        {
            Console.WriteLine("Please enter yes or no!");
        }
    }
}