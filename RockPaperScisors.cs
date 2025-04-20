// See https://aka.ms/new-console-template for more information
const string Rock = "Rock";
const string Paper = "Paper";
const string Scissors = "Scissors";
Console.WriteLine("Type r/rock for rock, s/scissors for scisors or p/paper for paper");
string choice= Console.ReadLine();
if (choice == "r"||choice=="rock") {
    choice = Rock;
}
else if (choice == "s"||choice=="scissors")
{
    choice = Scissors;
}
else if(choice == "p"||choice=="paper"){
    choice = Paper;
}
else
{
    Console.WriteLine("Invalid input, try again...");
    return;
}
Random random = new Random();
int computerRandomNumber = random.Next(1, 4);
string pc = "";
switch (computerRandomNumber)
{
    case 1:
        pc = "Rock";
        break;
    case 2:
        pc = "Paper";
        break;
    case 3:
        pc = "Scisors";
        break;
}

Console.WriteLine($"The computer chose {pc}.");
if ((choice ==  Rock && pc == Scissors) || ( choice == Paper && pc == Rock)
    || (choice == Scissors && pc == Paper))
{
    Console.WriteLine("You win");
}
else if ((choice == Rock && pc == Paper) || (choice == Paper && pc == Scissors)
    || (choice == Scissors && pc == Rock))
{
    Console.WriteLine("You lose");
}
else
{
    Console.WriteLine("Draw");
}