Console.WriteLine("Fibonacci raqamlarni aniqlovchi loyixa: ");

Console.Write("Enter a number: ");
            string userStrInput = Console.ReadLine();
            int userInput = Convert.ToInt32(userStrInput);
            int num1 = 0; int num2 = 1; int result = 0;
            for(int i = 0; i < userInput; i++)
            {
                result = num1 + num2; 
                num1 = num2; 
                num2 = result;
                if(result <= userInput)
                {
                    Console.WriteLine(result);
                }
            }