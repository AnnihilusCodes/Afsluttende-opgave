using System.Threading.Tasks;

namespace Afsluttende_projekt_2
{
    internal class Program
    {


        static void print(string text)
        {
            Console.WriteLine(text);
        }

        static void Main(string[] args)

        {
            List<string> houseTasks = new List<string>
            {

            };

            while (true)
            {
                Console.WriteLine("\nHouse Tasks:");
                for (int i = 0; i < houseTasks.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {houseTasks[i]}");
                }


                Console.WriteLine("\nMenu:");
                string taskadd = "1. Add a task";
                string taskremove = "2. Remove a task";
                string taskdone = "3. Mark a task as done";
                string taskoverview = "4. Overview of tasks";   
                string taskexit = "5. Exit";

                print(taskadd);
                print(taskremove);
                print(taskdone);
                print(taskoverview);
                print(taskexit);

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Type the new task: ");
                        string text = Console.ReadLine();

                        if (string.IsNullOrWhiteSpace(text))
                        {
                            Console.WriteLine("You did not write anything.");
                        }
                        else
                        {
                            houseTasks.Add(text);
                            Console.WriteLine("Task added.");
                        }
                        break;

                    case "2":
                        print(taskremove);
                        Console.WriteLine("Enter the number of the task you want to remove:");
                        Console.ReadLine();
                        Console.WriteLine("Hej");
                        break;

                    case "3":
                        print(taskdone);
                        Console.WriteLine("Enter the number of the task you want to mark as done:");
                        Console.ReadLine();
                        break;

                    case "4":
                        print(taskoverview);
                        if (houseTasks.Count == 0)
                        {
                            Console.WriteLine("No tasks yet.");
                        }
                        else
                        {
                            Console.WriteLine("Here are your tasks:");
                            for (int i = 0; i < houseTasks.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}. {houseTasks[i]}");
                            }
                        }
                        break;

                    case "5":
                        Console.WriteLine("Exiting the program. Goodbye!");
                        return;

                    default:
                        print("Invalid choice.");
                        break;
                }

            }
        }
    }  
}