using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoListApp
{
    internal class Program
    {
        private static object taskList;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to to list app!");
            List<string> taskList = new List<string>();
            string option = "";
            while (option != "e")
            {
                Console.WriteLine("\n What would you like to do? ");
                Console.WriteLine("Enter 1 to add task to the list. ");
                Console.WriteLine("Enter 2 to remove task to the list.");
                Console.WriteLine("Enter 3 to view task to the list.");
                Console.WriteLine("Enter e to exit the program.\n");

                option = Console.ReadLine();
                if (option == "1") //ADD ITEM
                {
                    Console.WriteLine("Please Enter the Task that you want to add.");
                    string task = Console.ReadLine();
                    taskList.Add(task);
                    Console.WriteLine("Task added to the list.");

                }
                else if (option == "2") // REMOVE ITEM
                {
                    for (int i = 0; i < taskList.Count; i++)
                    {
                        Console.WriteLine(i + " " + taskList[i]);
                    }
                    Console.WriteLine("Please Enter the number of the task you want to remove.");
                    int taskNumber = Convert.ToInt32(Console.ReadLine());
                    taskList.RemoveAt(taskNumber);
                }
                else if (option == "3") // VIEW ITEM
                {
                    Console.WriteLine("The task in to do list: ");
                    for (int i = 0; i < taskList.Count; i++)
                    {
                        Console.WriteLine(taskList[i]);
                    }
                }
                else if (option == "e") // EXIT
                {
                    Console.WriteLine("Exit Program.");
                }
                else
                {
                    Console.WriteLine("Invalid Input Please Try again");
                }
            }
            Console.WriteLine("Thank you for Using!");
            Console.ReadLine();
        }
    }
}
