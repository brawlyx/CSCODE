// See https://aka.ms/new-console-template for more information
using System;
using Library;


TestFile p = new TestFile
{
  //  FirstName = "Tim",
    //LastName = "Bob",
   // Age = 20
};

// System.Console.WriteLine($"{ p.FirstName } { p.LastName } { p.Age }");

Console.WriteLine("Hello, World!");
System.Console.WriteLine("The End ");   

System.Console.WriteLine("WELCOME TO THE GREATEST GIVE AWAY YOU EVER SAW");
System.Console.WriteLine("CHOOSE 1 2 OR 3");
    if (Console.ReadLine() == "1")
    {
        var message = "You just won mate";
        System.Console.WriteLine(message);
    }
    else 
    {
        System.Console.WriteLine("Error");
    }
Console.ReadLine();




