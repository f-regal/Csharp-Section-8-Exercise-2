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
                var duplicates = false;
                List<int> inputArr = new List<int>();

                //[1,2,3] i = 0,1,2
                //[1,2,3] j = 1,2

                //i loops 0,1,2,3
                //j loops 1,2,3,4

                //first loop
                //i = 0, val = 1 & j = 1, val = 1 (Not Dup)

                //i = 0, val = 1 & j = 2, val = 3 (Not Dup)


                //second loop
                //i = 1, val = 1 & j = 1, val = 2(Not Dup)

                //i = 1, val = 2 & j = 2, val = 3(Not Dup)

                //i = 1, val = 3 & j = 3, val = 1(Not Dup)


                for (int i = 0; i < splitInput.Length; i++) {
                    for (int j = 0; j < splitInput.Length - 1; j++)
                    {
                        if (int.Parse(splitInput[i]) != int.Parse(splitInput[j + 1]))
                            {
                            duplicates = false;
                        } else
                        {
                            duplicates = true;
                            break;
                        }
                    }
                }

                if (duplicates)
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