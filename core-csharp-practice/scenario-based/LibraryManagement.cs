using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization.Metadata;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.ScenarioBased
{
    public class LibraryManagement
    {
        static String[,] books = new string[100, 3] // 100 books * (title, author, status)
        
        {
    // Classics & Fiction
    { "The Great Gatsby", "F. Scott Fitzgerald", "Available" },
    { "1984", "George Orwell", "Checked Out" },
    { "To Kill a Mockingbird", "Harper Lee", "Available" },
    { "Pride and Prejudice", "Jane Austen", "Reserved" },
    { "The Catcher in the Rye", "J.D. Salinger", "Available" },
    { "Moby Dick", "Herman Melville", "Available" },
    { "War and Peace", "Leo Tolstoy", "Checked Out" },
    { "The Odyssey", "Homer", "Available" },
    { "Ulysses", "James Joyce", "Available" },
    { "The Divine Comedy", "Dante Alighieri", "Reserved" },
    { "Hamlet", "William Shakespeare", "Available" },
    { "Macbeth", "William Shakespeare", "Checked Out" },
    { "Great Expectations", "Charles Dickens", "Available" },
    { "Crime and Punishment", "Fyodor Dostoevsky", "Available" },
    { "The Brothers Karamazov", "Fyodor Dostoevsky", "Reserved" },
    { "Wuthering Heights", "Emily Bronte", "Available" },
    { "Jane Eyre", "Charlotte Bronte", "Checked Out" },
    { "Brave New World", "Aldous Huxley", "Available" },
    { "The Lord of the Rings", "J.R.R. Tolkien", "Checked Out" },
    { "The Hobbit", "J.R.R. Tolkien", "Available" },

    // Fantasy & Sci-Fi
    { "Harry Potter 1", "J.K. Rowling", "Available" },
    { "Harry Potter 2", "J.K. Rowling", "Checked Out" },
    { "Harry Potter 3", "J.K. Rowling", "Reserved" },
    { "Harry Potter 4", "J.K. Rowling", "Available" },
    { "Harry Potter 5", "J.K. Rowling", "Available" },
    { "Harry Potter 6", "J.K. Rowling", "Checked Out" },
    { "Harry Potter 7", "J.K. Rowling", "Available" },
    { "Dune", "Frank Herbert", "Reserved" },
    { "Dune Messiah", "Frank Herbert", "Available" },
    { "Children of Dune", "Frank Herbert", "Available" },
    { "Foundation", "Isaac Asimov", "Checked Out" },
    { "Foundation and Empire", "Isaac Asimov", "Available" },
    { "Second Foundation", "Isaac Asimov", "Available" },
    { "Neuromancer", "William Gibson", "Available" },
    { "Fahrenheit 451", "Ray Bradbury", "Checked Out" },
    { "The Martian", "Andy Weir", "Reserved" },
    { "Ender's Game", "Orson Scott Card", "Available" },
    { "A Game of Thrones", "George R.R. Martin", "Available" },
    { "A Clash of Kings", "George R.R. Martin", "Checked Out" },
    { "A Storm of Swords", "George R.R. Martin", "Available" },

    // Mystery & Thriller
    { "The Da Vinci Code", "Dan Brown", "Available" },
    { "Angels & Demons", "Dan Brown", "Checked Out" },
    { "Inferno", "Dan Brown", "Available" },
    { "Gone Girl", "Gillian Flynn", "Reserved" },
    { "The Girl with the Dragon Tattoo", "Stieg Larsson", "Available" },
    { "The Girl Who Played with Fire", "Stieg Larsson", "Available" },
    { "The Girl Who Kicked the Hornet's Nest", "Stieg Larsson", "Checked Out" },
    { "Sherlock Holmes: Study in Scarlet", "Arthur Conan Doyle", "Available" },
    { "Sherlock Holmes: Hound of Baskervilles", "Arthur Conan Doyle", "Available" },
    { "The Godfather", "Mario Puzo", "Reserved" },
    { "The Shining", "Stephen King", "Checked Out" },
    { "It", "Stephen King", "Available" },
    { "Misery", "Stephen King", "Available" },
    { "Carrie", "Stephen King", "Available" },
    { "The Green Mile", "Stephen King", "Checked Out" },
    { "Doctor Sleep", "Stephen King", "Available" },
    { "Pet Sematary", "Stephen King", "Reserved" },
    { "The Silence of the Lambs", "Thomas Harris", "Available" },
    { "Red Dragon", "Thomas Harris", "Available" },
    { "Hannibal", "Thomas Harris", "Checked Out" },

    // Educational & Tech
    { "Clean Code", "Robert C. Martin", "Checked Out" },
    { "The Pragmatic Programmer", "Andrew Hunt", "Reserved" },
    { "Design Patterns", "Erich Gamma", "Available" },
    { "Introduction to Algorithms", "Thomas H. Cormen", "Available" },
    { "Code Complete", "Steve McConnell", "Checked Out" },
    { "Refactoring", "Martin Fowler", "Available" },
    { "Head First Design Patterns", "Eric Freeman", "Available" },
    { "You Don't Know JS", "Kyle Simpson", "Available" },
    { "Eloquent JavaScript", "Marijn Haverbeke", "Reserved" },
    { "C# in Depth", "Jon Skeet", "Checked Out" },
    { "The Art of Computer Programming", "Donald Knuth", "Available" },
    { "Structure and Interpretation", "Harold Abelson", "Available" },
    { "Artificial Intelligence", "Stuart Russell", "Checked Out" },
    { "Deep Learning", "Ian Goodfellow", "Available" },
    { "Python Crash Course", "Eric Matthes", "Available" },
    { "Effective Java", "Joshua Bloch", "Reserved" },
    { "Thinking in Java", "Bruce Eckel", "Available" },
    { "Learning React", "Alex Banks", "Available" },
    { "Pro ASP.NET Core", "Adam Freeman", "Checked Out" },
    { "Docker Deep Dive", "Nigel Poulton", "Available" },

    // Biographies & History
    { "Steve Jobs", "Walter Isaacson", "Available" },
    { "Elon Musk", "Ashlee Vance", "Checked Out" },
    { "Becoming", "Michelle Obama", "Reserved" },
    { "Sapiens", "Yuval Noah Harari", "Available" },
    { "Homo Deus", "Yuval Noah Harari", "Available" },
    { "Guns, Germs, and Steel", "Jared Diamond", "Available" },
    { "The Diary of a Young Girl", "Anne Frank", "Checked Out" },
    { "Long Walk to Freedom", "Nelson Mandela", "Available" },
    { "The Wright Brothers", "David McCullough", "Available" },
    { "Alexander Hamilton", "Ron Chernow", "Reserved" },
    { "Team of Rivals", "Doris Kearns Goodwin", "Available" },
    { "Educated", "Tara Westover", "Checked Out" },
    { "Born a Crime", "Trevor Noah", "Available" },
    { "Shoe Dog", "Phil Knight", "Available" },
    { "Into the Wild", "Jon Krakauer", "Available" },
    { "Unbroken", "Laura Hillenbrand", "Checked Out" },
    { "The Immortal Life of Henrietta Lacks", "Rebecca Skloot", "Reserved" },
    { "A Brief History of Time", "Stephen Hawking", "Available" },
    { "Cosmos", "Carl Sagan", "Available" },
    { "The Theory of Everything", "Stephen Hawking", "Checked Out" }
};


        public static void DisplayBooks()
        {
            for(int i = 0; i < 100; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.WriteLine(books[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public static void showBook(int index)
        {
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine(books[index, i]);
            }
        }

        public static void SearchShow(String searchStr)
        {
            int title = 0; //title is at book[book, 0]
            String[] result = new string[10]; // for top 10 results
            int count = 0;
            int len = 100;
            for(int i = 0; i < len; i++)
            {
                if (books[i, title].ToLower().Contains(searchStr.ToLower()) && count < 10)
                {
                    result[count] = books[i, title];
                    count++;
                }
            }

            for(int j = 0; j < result.Length; j++)
            {
                Console.WriteLine(result[j]);
            }
            
        }


        public static int Search(String searchStr)
        {
            int title = 0; //title is at book[book, 0]
            String[] result = new string[10]; // for top 10 results
            int count = 0;
            int output = 0;
            for (int i = 0; i < 100; i++)
            {
                if (books[i, title].ToLower().Contains(searchStr.ToLower()) && count < 10)
                {
                    result[count] = books[i, title];
                    return i;
                    count++;
                }
            }

            return 0;

        }

        public static void Update(String searchStr, String changeStr)
        {
            int index = Search(searchStr);

            books[index, 2] = changeStr;

            Console.WriteLine(books[index, 0] + " " + books[index, 1] + " " + books[index, 2]);
            
        }

        public static void DisplayMenu()
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\n==========================================");
                Console.WriteLine("       LIBRARY MANAGEMENT SYSTEM          ");
                Console.WriteLine("==========================================");
                Console.WriteLine("1. Show All Books");
                Console.WriteLine("2. Search for a Book");
                Console.WriteLine("3. Update Book Status");
                Console.WriteLine("4. Exit");
                Console.WriteLine("------------------------------------------");
                Console.Write("Enter your choice (1-4): ");

                String choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("\n--- Book List ---");
                        DisplayBooks();
                        break;

                    case "2":
                        Console.Write("\nEnter title to search: ");
                        String searchInput = Console.ReadLine();
                        SearchShow(searchInput);
                        break;

                    case "3":
                        Console.Write("\nEnter the exact title of the book to update: ");
                        String titleInput = Console.ReadLine();

                        Console.WriteLine("Enter new status (Available / Checked Out / Reserved): ");
                        String statusInput = Console.ReadLine();

                        // Calls your existing Update method
                        Update(titleInput, statusInput);
                     
                        Console.WriteLine("Update process completed.");
                        break;

                    case "4":
                        exit = true;
                        Console.WriteLine("Exiting... Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }



        public static void Main(String[] args)
        {
            DisplayMenu();
        }
    }
}
