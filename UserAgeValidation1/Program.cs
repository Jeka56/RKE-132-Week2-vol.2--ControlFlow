﻿// See https://aka.ms/new-console-template for more information

//rakendus küsib kasutajalt sisestada tema vanuse 
//kui kasutaja vanus on väiksem kui 13, siis konsoolis kuvatakse:
//"You sre too young to use Instagrm"
//muul juhul
//konsoolis kuvatakse "Welcome to Instagram"

Console.WriteLine("Enter your age:");

string userAge = Console.ReadLine();

int userAgeNum = 0;

//boolean - true/false

bool isAgeNumber = Int32.TryParse(userAge, out userAgeNum);

Console.WriteLine($"Parse result {isAgeNumber}. User is {userAgeNum} years old.");
if (isAgeNumber == true)
{
    if (userAgeNum > 13)
    {
        Console.WriteLine("Welcome to Instagram.");
    }
    else
    {
        Console.WriteLine("You are too yong to use Instagram.");
    }
}
else
{
    Console.WriteLine("Could nor read your age."); 
}