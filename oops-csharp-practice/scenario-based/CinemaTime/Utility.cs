using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.ScenarioBased.CinemaTime
{
    public class Utility
    {
        public void RunCinemaSystem()
        {
            
            MovieSchedule mySchedule = new MovieSchedule();
            ISchedulable scheduler = new ScheduleImpl();

            List<Movie> library = new List<Movie>();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("==============================================");
                Console.WriteLine("      CINEMA TIME MANAGEMENT SYSTEM v1.0      ");
                Console.WriteLine("==============================================");
                Console.WriteLine("1. Create New Movie");
                Console.WriteLine("2. Schedule a Movie");
                Console.WriteLine("3. View Full Schedule");
                Console.WriteLine("4. Search for Scheduled Movie");
                Console.WriteLine("5. Exit");
                Console.WriteLine("----------------------------------------------");
                Console.Write("Enter Selection: ");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        // --- CREATE MOVIE ---
                        Console.WriteLine("\n--- Create New Movie ---");
                        Console.Write("Enter Title: ");
                        string title = Console.ReadLine();

                        Console.Write("Enter Duration (mins): ");
                        if (int.TryParse(Console.ReadLine(), out int duration))
                        {
                            library.Add(new Movie(title, duration));
                            Console.WriteLine($"Success! '{title}' added to library.");
                        }
                        else
                        {
                            Console.WriteLine("Invalid duration.");
                        }
                        Pause();
                        break;

                    case "2":
                        // --- SCHEDULE MOVIE ---
                        Console.WriteLine("\n--- Schedule Movie ---");
                        if (library.Count == 0)
                        {
                            Console.WriteLine("No movies in library. Please Create (Option 1) first.");
                            Pause();
                            break;
                        }

                        // Select Movie
                        Console.WriteLine("Available Movies:");
                        for (int i = 0; i < library.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {library[i].title} ({library[i].durationMins}m)");
                        }
                        Console.Write("Select Movie Number: ");
                        int movieIdx = int.Parse(Console.ReadLine()) - 1;

                        if (movieIdx >= 0 && movieIdx < library.Count)
                        {
                            // Select Time Slot
                            Console.WriteLine("\nSelect Time Slot:");
                            Console.WriteLine("0 - Morning (9:00 AM)");
                            Console.WriteLine("1 - Matinee (1:00 PM)");
                            Console.WriteLine("2 - Evening (6:00 PM)");
                            Console.WriteLine("3 - Night   (9:00 PM)");
                            Console.Write("Enter Slot Number: ");
                            int slot = int.Parse(Console.ReadLine());

                            if (slot >= 0 && slot <= 3)
                            {
                                scheduler.ScheduleMovie(library[movieIdx], mySchedule, slot);
                                Console.WriteLine("Attempting to schedule...");
                                // Note: ScheduleImpl handles the success/fail logic internally
                            }
                            else
                            {
                                Console.WriteLine("Invalid slot.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid movie selection.");
                        }
                        Pause();
                        break;

                    case "3":
                        // --- DISPLAY SCHEDULE ---
                        Console.WriteLine("\n--- Current Cinema Schedule ---");
                        Console.WriteLine("-------------------------------------------------------");
                        Console.WriteLine(String.Format("{0,-25} | {1,-25}", "SHOWTIME", "MOVIE TITLE"));
                        Console.WriteLine("-------------------------------------------------------");

                        string[,] currentSchedule = scheduler.DisplaySchedule(mySchedule);

                        for (int i = 0; i < 4; i++)
                        {
                            Console.WriteLine(String.Format("{0,-25} | {1,-25}", currentSchedule[i, 0], currentSchedule[i, 1]));
                        }
                        Console.WriteLine("-------------------------------------------------------");
                        Pause();
                        break;

                    case "4":
                        // --- SEARCH ---
                        Console.WriteLine("\n--- Search Movie ---");
                        Console.Write("Enter Movie Title to find: ");
                        string searchTitle = Console.ReadLine();
                        string result = scheduler.SearchMovie(searchTitle, mySchedule);

                        // Formatting result cleanly
                        if (result != null && result != "Movie not found!")
                        {
                            Console.WriteLine($"\nFOUND: '{searchTitle}' is showing.");
                            Console.WriteLine($"Details: {result}");
                        }
                        else
                        {
                            Console.WriteLine($"\nResult: Movie not scheduled.");
                        }
                        Pause();
                        break;

                    case "5":
                        return; // Exit Application

                    default:
                        Console.WriteLine("Invalid Option.");
                        Pause();
                        break;
                }
            }
        }

        private void Pause()
        {
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
    }
}
