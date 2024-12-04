namespace Exercise1_16
{
    class Program
    {
        static void Main(string[] args) {
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
                    if ( choice >= 1 && choice <= 3) {
                        Console.WriteLine($"\nYour selection is: {menuOptions[choice-1]}\n");
                        break;
                    }
                    if (choice < 1 || choice > 3) {
                        throw new OutOfRangeException("The input you provided is out of range");
                    }
                    else
                    {
                        throw new Exception("Exception---------------");
                    }
                }catch (OutOfRangeException outOfRangeException) {    
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
    }
    
    
}

