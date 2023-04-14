// See https://aka.ms/new-console-template for more information


bool userReply = true;

while (userReply)
{
    int divisors = 0;
    Console.Write("Enter the number you want to check: ");
    Int64 number = Convert.ToInt64(Console.ReadLine());
   
    for (int i = 1; i <= number; i++)
    {

        if (number % i == 0)
        {
            divisors++;
        }
    }
    
    if (divisors == 2)
    {
        Console.WriteLine("{0} is a Prime Number!!!", number);
    }
    else
    {
        Console.WriteLine("{0} is not a Prime Number", number);
    }

    Console.Write("Do you want to continue? Y/N :");
    string userResponse = Console.ReadLine().ToLower();
    if (userResponse == "n")
    {
        userReply = false;
    }
}

