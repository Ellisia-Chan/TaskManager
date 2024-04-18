using System;
using System.Collections.Generic;
using System.Threading;

namespace ToDoList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> taskList = new List<string>();

            Console.WriteLine("  Welcome to the To Do List Program");
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine(" Please Enter an Action: ");
                Console.WriteLine("  1 - Add a Task     e - Exit Program");
                Console.WriteLine("  2 - Remove a Task");
                Console.WriteLine("  3 - View List of Task");
                Console.WriteLine();
                Console.Write("  > ");

                string action = Console.ReadLine();

                if (action.ToLower() == "e")
                {
                    Console.Write("  Exiting Program");
                    Thread.Sleep(500);
                    Console.Write(".");
                    Thread.Sleep(500);
                    Console.Write(".");
                    Thread.Sleep(500);
                    Console.Write(".");
                    Thread.Sleep(500);
                    break;

                }
                else
                {
                    TaskListManager(action, taskList);
                }
            }
        }

        static void TaskListManager(string action, List<string> taskList)
        {
            string task = "";

            if (action == "1" || action == "2" || action == "3")
            {
                switch (action)
                {
                    case "1":
                        Console.Write("  Enter a Task: ");
                        task = Console.ReadLine();
                        taskList.Add(task);
                        break;
                    case "2":
                        Console.WriteLine("  Select a Task Number to Remove: ");

                        for (int i = 0; i < taskList.Count; i++)
                        {
                            Console.WriteLine("  " + i + " : " + taskList[i]);
                        }
                        Console.Write("  > ");
                        int taskNumber = Convert.ToInt32(Console.ReadLine());
                        taskList.RemoveAt(taskNumber);

                        Console.WriteLine();
                        Console.WriteLine("  Updated List: ");
                        for (int j = 0; j < taskList.Count; j++)
                        {
                            Console.WriteLine($"  {j}.{taskList[j]}");
                            
                        }
                        Thread.Sleep(1000);
                        break;
                    case "3":
                        Console.WriteLine("  Current Task in the List: ");

                        for (int i = 0; i < taskList.Count; i++)
                        {
                            Console.WriteLine($"    {i}.{taskList[i]}");
                            
                        }
                        Thread.Sleep(1000);
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid Action. Please Try Again.");
                Thread.Sleep(1000);
            }
        }
    }
}
