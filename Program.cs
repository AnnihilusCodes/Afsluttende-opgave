using System.Threading.Tasks;

namespace Afsluttende_projekt_2
{
    internal class Program
    {
        //Udskriver tekst til konsollen
        static void print(string text)
        {
            Console.WriteLine(text);
        }

        static void Main(string[] args)
        {
            //Liste til at gemme husopgaver
            List<string> houseTasks = new List<string>
            {

            };

            while (true)
            {
                //Viser nuværende opgaver
                Console.WriteLine("\nHouse Tasks:");
                for (int i = 0; i < houseTasks.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {houseTasks[i]}");
                }

                //Viser muligheder for menuen
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

                //Læser brugerens valg
                string choice = Console.ReadLine();

                //Variabel til at gemme tekst for task nummer
                string numberText = null;

                switch (choice)
                {
                    case "1":
                        //Tilføj en opgave
                        Console.Write("Type the new task: ");
                        string text = Console.ReadLine();

                        //IsNullOrWhiteSpace sørger for at der ikke kan tilføjes 0 input
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
                        //Fjern en opgave
                        Console.Write("Write the task number to remove: ");
                        numberText = Console.ReadLine();

                        int numberToRemove;
                        //Tjekker om input er et gyldigt tal
                        if (int.TryParse(numberText, out numberToRemove))
                        {
                            int index = numberToRemove - 1; //Konvertering fra 1-start til 0-start

                            //Tjekker om nummeret findes i listen
                            if (index >= 0 && index < houseTasks.Count)
                            {
                                Console.WriteLine("Removed: " + houseTasks[index]);
                                houseTasks.RemoveAt(index);
                            }
                            else
                            {
                                Console.WriteLine("That number is not in the list.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Please type a whole number.");
                        }
                        break;


                    case "3":
                        //Case til at markere task som (done)
                        if (houseTasks.Count == 0)
                        {
                            Console.WriteLine("No tasks to mark as done.");
                            break;
                        }
                        //Markere en opgave med (done) når opgaven bliver sat som løst
                        Console.Write("Write the task number to mark as done: ");
                        numberText = Console.ReadLine();
                        if (int.TryParse(numberText, out int doneNumber) && doneNumber > 0 && doneNumber <= houseTasks.Count)
                        {
                            houseTasks[doneNumber - 1] += " (done)";
                            Console.WriteLine("Task marked as done.");
                        }
                        else
                        {
                            Console.WriteLine("Invalid task number.");
                        }
                        break;

                    case "4":
                        //Se listen af opgaver igen
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
                        //Lukker programmet ned
                        Console.WriteLine("Exiting the program. Goodbye!");
                        return;

                    default:
                        //Hvis et forkert input bliver skrevet ind
                        print("Invalid choice.");
                        break;
                }

            }
        }
    }
}