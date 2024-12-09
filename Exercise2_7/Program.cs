using System.Linq;

namespace Exercise2_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie movie = new Movie();
            List<Movie> movieList = movie.CreateMovieList();

            while (true)
            {
                try
                {
                    Console.WriteLine("Here are the top 10 movies on IMDb:");
                    int j = 1;
                    foreach (var m in movieList)
                    {
                        Console.WriteLine($"{j} --> [Name]: {m.Name}, [Rating]: {m.Rating}");
                        j++;
                    }

                    Console.WriteLine("\nYou have the following options: " +
                                      "\nPress 1 to display the top 3 movies." +
                                      "\nPress 2 to display the worst 3 movies." +
                                      "\nPress 3 to display all movies with a rating of 9 or above." +
                                      "\nPress 0 to exit the application.");

                    string strChoice = Console.ReadLine();
                    int choice = Convert.ToInt32(strChoice);

                    if (choice < 0 || choice > 3) {
                        throw new OutOfRangeException("The input you provided is out of range");
                    }
                    
                    if (choice == 0)
                    {
                        Console.WriteLine("Exiting the app");
                        break;
                    }

                    if (choice == 1)
                    {
                        var best3Movies = movieList
                            .OrderByDescending(m => m.Rating)
                            .Take(3);
                        Console.WriteLine("\nThe top three rated movies from the list above are: ");
                        int i = 1;
                        foreach (var m in best3Movies)
                        {
                            Console.WriteLine($"{i} --> [Name]: {m.Name}, [Rating]: {m.Rating}");
                            i++;
                        }
                        break;
                    }
                    
                    if (choice == 2)
                    {
                        var worst3Movies = movieList
                            .OrderBy(m => m.Rating)
                            .Take(3);
                        Console.WriteLine("\nThe three worst-rated movies from the list above are:");
                        int i = 1;
                        foreach (var m in worst3Movies)
                        {
                            Console.WriteLine($"{i} --> [Name]: {m.Name}, [Rating]: {m.Rating}");
                            i++;
                        }
                        break;
                    }
                    
                    if (choice == 3)
                    {
                        var moreThan9Rating = movieList
                            .Where(m => m.Rating >= 9);
                        Console.WriteLine("\nThe movies with a rating of 9 or higher");
                        int i = 1;
                        foreach (var m in moreThan9Rating)
                        {
                            Console.WriteLine($"{i} --> [Name]: {m.Name}, [Rating]: {m.Rating}");
                            i++;
                        }
                        break;
                    }
                    
                    else
                    {
                        throw new Exception("Exception---------------");
                    }
                }
                catch (OutOfRangeException outOfRangeException) {    
                    Console.WriteLine($"\n---OutOfRangeException ---\nThe given number is not between 0 and 3\n");
                }
                catch (FormatException formatException) {    
                    Console.WriteLine($"\n---FormatException Error ---\n" +
                                      $"{formatException.Message} \nPlease enter a valid number between 0 and 3!!!\n");
                }
                catch (Exception ex) {
                    Console.WriteLine($"---General error---: {ex.Message}");
                }
            }
        }


    }
    
}