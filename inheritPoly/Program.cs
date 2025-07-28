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


class Program
{
    public async Task DowloadDataAsync()
    {
        try
        {
            Console.WriteLine("Downloading Started...");
            await Task.Delay(3000);
            Console.WriteLine("Downloaded Compeled");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        } 
    }
    public async Task DowloadDataAsync2()
    {
        Console.WriteLine("Downloading 2 Started...");
        await Task.Delay(2000);
        Console.WriteLine("Downloaded 2 Compeled");
    }

    public static async Task Main(string[] args)
    {
        Program program = new Program();
        Task task1 = program.DowloadDataAsync();
        Task task2 = program.DowloadDataAsync2();
        await Task.WhenAll(task1, task2);
        Console.WriteLine("All Downloads Completed");
    }
}