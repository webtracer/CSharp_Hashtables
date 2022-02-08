using System;
using System.Collections;

namespace Hashtables_Challenge
{
    /* Challenge
     * 
     * Write a program that will iterate through each element of the students array and insert them int a
     * hashtable.  
     * If a student with the same ID already exists in the Hashtable skip it and display the following error:
     * "Sorry, a student with the same ID already Exists"
     * Hint: Use the method ContainsKey() to check whether a student with the same ID already exists
     */

    class Program
    {
        static void Main(string[] args)
        {
            Hashtable studentTable = new Hashtable();

            Students[] students = new Students[5];
            students[0] = new Students(1, "Randy", 88);
            students[1] = new Students(2, "Laura",97);
            students[2] = new Students(6, "Noah", 65);
            students[3] = new Students(1, "Cooper",73);
            students[4] = new Students(4, "Mae", 58);

            Console.WriteLine("     -----------------------------     ");
            Console.WriteLine("Now adding student information to the hashtable");
            Console.WriteLine("     -----------------------------     ");

            foreach (Students item in students)
            {
                if (!studentTable.ContainsKey(item.ID))
                {
                    studentTable.Add(item.ID, item);
                    studentTable.Add(item.Name, item);
                    studentTable.Add(item.GPA, item);
                }
                else
                {
                    Console.WriteLine($"Sorry, a student with the same ID (ID #{item.ID}) already Exists");
                }
            }

            Console.WriteLine("Hello World!");
        }
    }
}
