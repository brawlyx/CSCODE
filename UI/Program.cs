// See https://aka.ms/new-console-template for more information
using System;
using Library;

bool power=true;
while (power==true)
{
    System.Console.WriteLine("THIS IS THE GREATEST ATM EVER");
    System.Console.WriteLine("WHAT IS YOUR SELECTION?");
    System.Console.WriteLine("1) Create Account");
    System.Console.WriteLine("2) Make Withdrawal");
    System.Console.WriteLine("3) Make Deposit");
    string v = System.Console.ReadLine();
    if (v=="1")
    {
        System.Console.WriteLine("Create An Account -");
        System.Console.WriteLine("What is your name ?");
        string name = System.Console.ReadLine(name);
        var account = new BankAccount(0, name, 0);
        
    };
};
System.Console.WriteLine("thanks");
