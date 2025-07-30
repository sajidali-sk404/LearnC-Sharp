// using System.Threading.Tasks.Dataflow;

// public interface IAnimal
// {
//     void Eat();
// }

// public class Animal : IAnimal
// {
//     public void Eat()
//     {
//         Console.WriteLine("Generic Food of Animal");
//     }
//     public virtual void MakeSound()
//     {
//         Console.WriteLine("Generic sound of Animal");
//     }
// }


// public class Dog : Animal
// {
//     public void Eat()
//     {
//         Console.WriteLine("Kibble");
//     }

//     public override void MakeSound()
//     {
//         Console.WriteLine("Bark");
//     }
// }

// public class Cat : Animal
// {
//     public void Eat()
//     {
//         Console.WriteLine("Tuna");
//     }
//     public override void MakeSound()
//     {
//         Console.WriteLine("Meow");
//     }
// }






// public class Program
// {

//     public static void Main(string[] args)
//     {
//         List<Animal> animals = new List<Animal>();
//         animals.Add(new Dog());
//         animals.Add(new Cat());

//         foreach (Animal animal in animals)
//         {
//             animal.MakeSound();
//         }
//     }
// }



// public class Person
// {
//     public  string Name { get; set; }
//     public  int Age { get; set; }

//     public Person(string name, int age)
//     {
//         Name = name;
//         Age = age;
//     }

//     public void Greet()
//     {
//         Console.WriteLine($"Hello, My Name is: {Name}, Age is: {Age} ");
//     }

//     public static void Main(string[] args)
//     {
//         Person friend = new Person("Sajid Ali", 23);
//         Person collegue = new Person("Ali", 20);

//         friend.Greet();
//         collegue.Greet();
//     }
// }


// class Program
// {
//     public async Task DowloadDataAsync()
//     {
//         try
//         {
//             Console.WriteLine("Downloading Started...");
//             await Task.Delay(3000);
//             Console.WriteLine("Downloaded Compeled");
//         }
//         catch (Exception ex)
//         {
//             Console.WriteLine($"An error occurred: {ex.Message}");
//         } 
//     }
//     public async Task DowloadDataAsync2()
//     {
//         Console.WriteLine("Downloading 2 Started...");
//         await Task.Delay(2000);
//         Console.WriteLine("Downloaded 2 Compeled");
//     }

//     public static async Task Main(string[] args)
//     {
//         Program program = new Program();
//         Task task1 = program.DowloadDataAsync();
//         Task task2 = program.DowloadDataAsync2();
//         await Task.WhenAll(task1, task2);
//         Console.WriteLine("All Downloads Completed");
//     }
// }


// Library management System



// class LibraryManager
// {
//     static void Main()
//     {
//         string book1 = null, book2 = null, book3 = null, book4 = null, book5 = null;

//         while (true)
//         {
//             Console.WriteLine("\nChoose an action: add / remove / display / exit");
//             string action = Console.ReadLine().Trim().ToLower();

//             if (action == "add")
//             {
//                 Console.Write("Enter book title to add: ");
//                 string newBook = Console.ReadLine();

//                 if (string.IsNullOrEmpty(book1)) book1 = newBook;
//                 else if (string.IsNullOrEmpty(book2)) book2 = newBook;
//                 else if (string.IsNullOrEmpty(book3)) book3 = newBook;
//                 else if (string.IsNullOrEmpty(book4)) book4 = newBook;
//                 else if (string.IsNullOrEmpty(book5)) book5 = newBook;
//                 else Console.WriteLine("Library is full. Cannot add more books.");
//             }
//             else if (action == "remove")
//             {
//                 Console.Write("Enter book title to remove: ");
//                 string bookToRemove = Console.ReadLine();
//                 bool found = false;

//                 if (book1 == bookToRemove) { book1 = null; found = true; }
//                 else if (book2 == bookToRemove) { book2 = null; found = true; }
//                 else if (book3 == bookToRemove) { book3 = null; found = true; }
//                 else if (book4 == bookToRemove) { book4 = null; found = true; }
//                 else if (book5 == bookToRemove) { book5 = null; found = true; }

//                 Console.WriteLine(found ? "Book removed." : "Book not found in library.");
//             }
//             else if (action == "display")
//             {
//                 Console.WriteLine("\nBooks in Library:");
//                 if (!string.IsNullOrEmpty(book1)) Console.WriteLine($"- {book1}");
//                 if (!string.IsNullOrEmpty(book2)) Console.WriteLine($"- {book2}");
//                 if (!string.IsNullOrEmpty(book3)) Console.WriteLine($"- {book3}");
//                 if (!string.IsNullOrEmpty(book4)) Console.WriteLine($"- {book4}");
//                 if (!string.IsNullOrEmpty(book5)) Console.WriteLine($"- {book5}");
//             }
//             else if (action == "exit")
//             {
//                 Console.WriteLine("Exiting Library Manager. Goodbye!");
//                 break;
//             }
//             else
//             {
//                 Console.WriteLine("Invalid action. Please choose add, remove, display, or exit.");
//             }
//         }
//     }
// }



// class LibraryManager
// {
//     static void Main()
//     {
//         string book1 = "";
//         string book2 = "";
//         string book3 = "";
//         string book4 = "";
//         string book5 = "";

//         while (true)
//         {
//             Console.WriteLine("Would you like to add or remove a book? (add/remove/exit)");
//             string action = Console.ReadLine();

//             if (action == "add")
//             {
//                 Console.WriteLine("Enter the title of the book to add:");
//                 string newBook = Console.ReadLine();

//                 if (string.IsNullOrEmpty(book1))
//                 {
//                     book1 = newBook;
//                 }
//                 else if (string.IsNullOrEmpty(book2))
//                 {
//                     book2 = newBook;
//                 }
//                 else if (string.IsNullOrEmpty(book3))
//                 {
//                     book3 = newBook;
//                 }
//                 else if (string.IsNullOrEmpty(book4))
//                 {
//                     book4 = newBook;
//                 }
//                 else if (string.IsNullOrEmpty(book5))
//                 {
//                     book5 = newBook;
//                 }
//                 else
//                 {
//                     Console.WriteLine("The library is full. No more books can be added.");
//                 }
//             }
//             else if (action == "remove")
//             {
//                 Console.WriteLine("Enter the title of the book to remove:");
//                 string removeBook = Console.ReadLine();

//                 if (removeBook == book1)
//                 {
//                     book1 = "";
//                 }
//                 else if (removeBook == book2)
//                 {
//                     book2 = "";
//                 }
//                 else if (removeBook == book3)
//                 {
//                     book3 = "";
//                 }
//                 else if (removeBook == book4)
//                 {
//                     book4 = "";
//                 }
//                 else if (removeBook == book5)
//                 {
//                     book5 = "";
//                 }
//                 else
//                 {
//                     Console.WriteLine("Book not found.");
//                 }
//             }
//             else if (action == "exit")
//             {
//                 break;
//             }
//             else
//             {
//                 Console.WriteLine("Invalid action. Please type 'add', 'remove', or 'exit'.");
//             }

//             // Display the list of books
//             Console.WriteLine("Available books:");
//             Console.WriteLine(book1);
//             Console.WriteLine(book2);
//             Console.WriteLine(book3);
//             Console.WriteLine(book4);
//             Console.WriteLine(book5);
//         }
//     }
// }




using System;

class LibraryManager
{
    static void Main()
    {
        string book1 = null, book2 = null, book3 = null, book4 = null, book5 = null;

        while (true)
        {
            Console.WriteLine("\nWould you like to add, remove, or exit? (add/remove/display/exit)");
            string action = Console.ReadLine()?.Trim().ToLower();

            if (action == "add")
            {
                if (!string.IsNullOrEmpty(book1) &&
                    !string.IsNullOrEmpty(book2) &&
                    !string.IsNullOrEmpty(book3) &&
                    !string.IsNullOrEmpty(book4) &&
                    !string.IsNullOrEmpty(book5))
                {
                    Console.WriteLine("The library is full. No more books can be added.");
                    continue;
                }

                Console.Write("Enter the title of the book to add: ");
                string newBook = Console.ReadLine()?.Trim();

                if (string.IsNullOrEmpty(book1)) book1 = newBook;
                else if (string.IsNullOrEmpty(book2)) book2 = newBook;
                else if (string.IsNullOrEmpty(book3)) book3 = newBook;
                else if (string.IsNullOrEmpty(book4)) book4 = newBook;
                else if (string.IsNullOrEmpty(book5)) book5 = newBook;

                Console.WriteLine($"\"{newBook}\" has been added to the library.");
            }
            else if (action == "remove")
            {
                Console.Write("Enter the title of the book to remove: ");
                string removeBook = Console.ReadLine()?.Trim();
                bool found = false;

                if (book1 == removeBook) { book1 = null; found = true; }
                else if (book2 == removeBook) { book2 = null; found = true; }
                else if (book3 == removeBook) { book3 = null; found = true; }
                else if (book4 == removeBook) { book4 = null; found = true; }
                else if (book5 == removeBook) { book5 = null; found = true; }

                Console.WriteLine(found ? $"\"{removeBook}\" has been removed." : "Book not found.");
            }
            else if (action == "display")
            {
                Console.WriteLine("\n📚 Available Books:");
                if (!string.IsNullOrEmpty(book1)) Console.WriteLine($"- {book1}");
                if (!string.IsNullOrEmpty(book2)) Console.WriteLine($"- {book2}");
                if (!string.IsNullOrEmpty(book3)) Console.WriteLine($"- {book3}");
                if (!string.IsNullOrEmpty(book4)) Console.WriteLine($"- {book4}");
                if (!string.IsNullOrEmpty(book5)) Console.WriteLine($"- {book5}");

                if (string.IsNullOrEmpty(book1) &&
                    string.IsNullOrEmpty(book2) &&
                    string.IsNullOrEmpty(book3) &&
                    string.IsNullOrEmpty(book4) &&
                    string.IsNullOrEmpty(book5))
                {
                    Console.WriteLine("No books currently in the library.");
                }
            }
            else if (action == "exit")
            {
                Console.WriteLine("👋 Exiting Library Manager. Goodbye!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid action. Please type 'add', 'remove', 'display', or 'exit'.");
            }
        }
    }
}
