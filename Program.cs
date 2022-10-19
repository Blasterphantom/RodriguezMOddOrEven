//Marcel Rodriguez
//10-18-22 4pm
//Mini Challenge 6 - Odd or Even
//This program will ask the user to input a number, data validate it
//and tell them if it is odd or even
//Peer review - Manuel L.

Console.Clear();

string end = "yes";
while(end == "yes")
{
    string numberOne;
    bool isContained = false;
    bool isNumber;
    int validNumber = 0;

    while(isContained == false)
    {
        Console.WriteLine("Please enter a number");
        numberOne = Console.ReadLine();
        isNumber = Int32.TryParse(numberOne, out validNumber);

        if(isNumber == true)
        {
            isContained = true;
            Console.WriteLine("--------------------------");
            Console.WriteLine(numberOne+ " is valid for real");
        }
        else
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine("Lowkey not valid");
        }
    }

    if(validNumber%2 == 0)
    {
        Console.WriteLine("--------------------------");
        Console.WriteLine($"{validNumber} is even");
    }
    else
    {
        Console.WriteLine("--------------------------");
        Console.WriteLine($"{validNumber} is odd");
    }

    Console.WriteLine("--------------------------");
    Console.WriteLine("Would you like to play again? yes/no");
    end = Console.ReadLine().ToLower();
    Console.WriteLine("--------------------------");
}