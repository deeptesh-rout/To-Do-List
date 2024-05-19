using System;
using System.Collections.Generic;

namespace ToDoListApp
{
    class Program
    {
        static List<string> toDoList = new List<string>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("To-Do List Application");
                Console.WriteLine("1. Add a task");
                Console.WriteLine("2. Remove a task");
                Console.WriteLine("3. Display tasks");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option (1-4): ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddTask();
                        break;
                    case "2":
                        RemoveTask();
                        break;
                    case "3":
                        DisplayTasks();
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }

        static void AddTask()
        {
            Console.Write("Enter the task: ");
            string task = Console.ReadLine();
            toDoList.Add(task);
            Console.WriteLine("Task added successfully!");
        }

        static void RemoveTask()
        {
            DisplayTasks();
            Console.Write("Enter the task number to remove: ");
            if (int.TryParse(Console.ReadLine(), out int taskNumber) && taskNumber > 0 && taskNumber <= toDoList.Count)
            {
                toDoList.RemoveAt(taskNumber - 1);
                Console.WriteLine("Task removed successfully!");
            }
            else
            {
                Console.WriteLine("Invalid task number!");
            }
        }

        static void DisplayTasks()
        {
            Console.WriteLine("To-Do List:");
            if (toDoList.Count == 0)
            {
                Console.WriteLine("No tasks found.");
            }
            else
            {
                for (int i = 0; i < toDoList.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {toDoList[i]}");
                }
            }
        }
    }
}
