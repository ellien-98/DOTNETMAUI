namespace Exercise3_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //ChefStuff chefStuff = new ChefStuff();
            
            while (true) {
                try {
                    IFood[] menuOptions = Catalog.GetMenuItems();
                    
                    Console.WriteLine($"\nPlease select your dish:");
                    for (int i = 0; i < menuOptions.Length; i++) {
                        Console.WriteLine($"Option {i + 1} --> {menuOptions[i]}");
                    }
                    Console.WriteLine($"Press 0 to exit the app\n");
                    
                    string strChoice = Console.ReadLine();
                    int choice = Convert.ToInt32(strChoice);
                    
                    if (choice == 0) {
                        Console.WriteLine("Exiting the app");
                        break;
                    }
                    
                    if ( choice >= 1 && choice <= 3)
                    {
                        string userInput = await AwaitUserInput();
                        //Task<string> resultTask = AwaitUserInput();
                        
                        if (userInput.ToLower()=="cancel")
                        {
                            Console.WriteLine($"cancel detected----------- withing 10 seconds. Restarting the loop\n");
                            continue;
                        }
                        WaitForPrep(); 
                        
                        Console.WriteLine($"\nYour selection '{menuOptions[choice-1]}' is ready\n");
                        break;
                    }
                    if (choice < 1 || choice > 3) {
                        throw new OutOfRangeException("The input you provided is out of range");
                    }
                    else
                    {
                        throw new Exception("Exception---------------");
                    }
                }
                catch (OutOfRangeException outOfRangeException) {    
                    Console.WriteLine($"\n---OutOfRangeException ---\nThe given number must be between 1 and 3\n");
                }
                catch (FormatException formatException) {    
                    Console.WriteLine($"\n---FormatException Error ---\n" +
                                      $"{formatException.Message} \nPlease enter a valid number between 1 and 3!!!\n");
                }
                catch (Exception ex) {
                    Console.WriteLine($"---General error---: {ex.Message}");
                }
            }
            
        }
        
        public static void WaitForPrep()
        {
            Console.WriteLine($"Entered WaitForPrep, waiting for the meal to be prepared");
            Thread.Sleep(5000);
            Console.WriteLine($"The meal has been prepared successfully");
        }
        // Asynchronous method
        public static Task<string> AwaitUserInput()
        {
            return Task.Run(() =>
            {   
                Console.WriteLine($"Entering AwaitUserInput(). Await for user to cancel for 10 seconds");
                string str=Console.ReadLine();
                return str;
                /*
                 * if (str.ToLower() == "cancel")
                {
                    Console.WriteLine($"cancel request detected");
                    return "cancel";
                }
                else
                {
                    return "continue";
                }
                 */

            });
        }
        
        
    }

    
}

