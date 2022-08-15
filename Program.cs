//Exercise 2
//Write a program and ask the user to enter a few numbers separated by a hyphen. 
//If the user simply presses Enter, without supplying an input, exit immediately; 
//otherwise, check to see if there are duplicates. 
//If so, display "Duplicate" on the console.

Console.WriteLine("Please enter a few numbers separated by a hyphen");

var userInput = Console.ReadLine();

if(String.IsNullOrEmpty(userInput))
{
    //Environment.Exit(0);
    Console.WriteLine(userInput);
}