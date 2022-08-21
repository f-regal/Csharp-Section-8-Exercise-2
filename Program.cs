//Exercise 2
//Write a program and ask the user to enter a few numbers separated by a hyphen. 
//If the user simply presses Enter, without supplying an input, exit immediately; 
//otherwise, check to see if there are duplicates. 
//If so, display "Duplicate" on the console.






namespace CsharpFundamentals 
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a few numbers separated by a hyphen");
            var userInput = Console.ReadLine();

            if (String.IsNullOrEmpty(userInput))
            {
                Environment.Exit(0);
            } else
            {
                var splitInput = userInput.Split('-');
                //var duplicates = false;
                List<int> inputArr = new List<int>();

                var counter = 0;

                for (int i = 0; i <= splitInput.Length - 1; i++) {
                    for (int j = 0; j <= splitInput.Length - 1; j++)
                    {
                        if (int.Parse(splitInput[i]) == int.Parse(splitInput[j]))
                        {
                            counter++;
                        } 
                    }
                }

                if (counter > splitInput.Length)
                {
                    Console.WriteLine("Duplicates");
                } else
                {
                    Console.WriteLine("No Duplicates");
                }

                

               
            }
        }
    }

}