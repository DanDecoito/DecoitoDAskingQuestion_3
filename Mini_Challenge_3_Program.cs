// Daniel Decoito 
// 9-8-2022
// Mini Challenge 3 "Ask a question"
// Create a program where you ask the user a question and use thier response in a phrase
// Peer Reviewed Elizar Garcia. Ran great, worked as intended.


Console.Clear();

string userName;
string wakeTime;
string terminate = ".";


static string QuestionStuff(string name, string time)
{
    return $"Hello {name}, you woke up at {time} today";
}


while (terminate != "")
{Console.WriteLine("Hello, user what is your name?");
userName = Console.ReadLine();
Console.WriteLine("And what time did you wake up today " + userName);
wakeTime = Console.ReadLine();
Console.WriteLine(QuestionStuff(userName, wakeTime));
Console.WriteLine("Do you wanna play again? press any key then enter to do so \nIf you want the program to end press enter ");
Console.WriteLine("");
terminate = Console.ReadLine();}
Console.WriteLine("Thanks for playing.");

