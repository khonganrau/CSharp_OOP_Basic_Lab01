using System;
using System.Collections.Generic;

namespace Lab_1_Advanced_Programming_Doc_02_Problem_2
{
    class ValueStudent
    {
        public byte Age { get; set; }
        public double Grade { get; set; }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter command: Create (information), " +
                "Show (information), or Exit to stop program");
            Dictionary<string, ValueStudent> myDict = 
                new Dictionary<string, ValueStudent>();
            string command;
            while((command = Console.ReadLine()) != "Exit")
            {
                string[] commandArgs = command.Split();
                string stdName = Convert.ToString(commandArgs[1]);

                switch (commandArgs[0])
                {
                    case "Create":
                        if (myDict.ContainsKey(stdName))
                            Console.WriteLine("Student information already exists");
                        else
                        {
                            ValueStudent students = new ValueStudent();
                            students.Age = Convert.ToByte(commandArgs[2]);
                            students.Grade = Convert.ToDouble(commandArgs[3]);
                            myDict.Add(stdName, students);
                            Console.WriteLine("Add Student's Information successfully ...");
                        }
                        break;
                    case "Show":
                        if (!myDict.ContainsKey(stdName))
                        {
                            Console.WriteLine("Student not found ...");
                        }
                        else
                        {
                            foreach (var value in myDict.Values)
                            {
                                Console.WriteLine("{0}", value);
                            }
                        }
                        break;
                    default:
                        Console.Write("Command Not Found... Try Again ...");
                        break;                    
                }
            }
        }
    }
}
