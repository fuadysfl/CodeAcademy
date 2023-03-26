using System;

Console.WriteLine("How much money do you have on your bank account?");
float balance = float.Parse(Console.ReadLine());

string my1Choice = "";
string my2Choice = "";
string my3Choice = "";
float cash = 0;
float topUp = 0;
string myTransactions = "My recent transactions are:\r\n";

while (my1Choice != "No")
{
    Console.WriteLine("1. Top up.");
    Console.WriteLine("2. Cash.");
    Console.WriteLine("3. Exit.");
    my2Choice = Console.ReadLine();

    if (my2Choice == "1")
    {
        Console.WriteLine("By what amount do you want to top up?");
        topUp = float.Parse(Console.ReadLine());
        myTransactions += "The balance has been toped up. Previos balance: " + Convert.ToString(balance) + ". New balance: " + Convert.ToString(balance + topUp) + "\r\n";
        balance += topUp;
    }
    else if (my2Choice == "2")
    {
        do
        {
            Console.WriteLine("How much cash do you need?");
            cash = float.Parse(Console.ReadLine());
            if (cash <= balance)
            {
                myTransactions += "The cash has been retrieved from the balance. Previous balance: " + Convert.ToString(balance) + ". New balance: " + Convert.ToString(balance - cash) + "\r\n";
                balance -= cash;
                break;
            }
            else
            {
                Console.WriteLine("Yo do not have this amount on your account? Please, be more realistic. Life is tough.");
            }
        }
        while (cash > balance);
        


           
    }
    else
    {
        continue;
    }

    Console.WriteLine("Would like to perform another operation? (Yes/No)");
    my1Choice = Console.ReadLine();
 }


Console.WriteLine("1. Show my balance.");
Console.WriteLine("2. Show the last transactions.");
Console.WriteLine("3. Exit");
my3Choice = Console.ReadLine();
if (my3Choice == "1")
{
    Console.WriteLine("Your current balance is: " + Convert.ToString(balance));
}
else if (my3Choice == "2")
{
    Console.WriteLine(myTransactions);
}
else
{
    Console.WriteLine("Bye.");
}
