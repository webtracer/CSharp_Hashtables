using System;
using System.Collections;

namespace Hashtables
{
    class Program
    {
        //Key - Value


        static void Main(string[] args)
        {
            Hashtable studentsTable = new Hashtable();

            Student stud1 = new Student(1, "Maria", 98);
            Student stud2 = new Student(2, "Jason", 76);
            Student stud3 = new Student(3, "Clara", 43);
            Student stud4 = new Student(4, "Steve", 55);

            studentsTable.Add(stud1.Id, stud1);
            studentsTable.Add(stud2.Id, stud2);
            studentsTable.Add(stud3.Id, stud3);
            studentsTable.Add(stud4.Id, stud4);

            //Methods of accessing the Hashtable
            // 1.  Create an object - cannot just assign an object, must cast Hashtable to object type
            //    Retrieves individual item when you know the ID
            Student storedStudent1 = (Student)studentsTable[1];  // or (Student)studentsTable[stud1.Id];
            Console.WriteLine($"Student ID: {storedStudent1.Id}, Name: {storedStudent1.Name}, GPA: {storedStudent1.GPA}");
            Console.WriteLine(" ");
            Console.WriteLine(" ----- ");
            Console.WriteLine(" ");
            // 2. Get item from Hashtable without first knowing the key/index values
            //    Struct(ure) called Dictionary Entry - the Key - Value pair
            //     Hashtables are basically a collection of Dictionary Entries
            //   retrieves all values from a Hashtable
            foreach (DictionaryEntry entry in studentsTable)
            {
                Student temp = (Student)entry.Value;  // Must also cast this to the correct Object type
                Console.WriteLine($"Student ID : {temp.Id}");
                Console.WriteLine($"Student Name : {temp.Name}");
                Console.WriteLine($"Student GPA : {temp.GPA}");
            }
            Console.WriteLine(" ");
            Console.WriteLine(" ----- Simplified for loop ----- ");
            Console.WriteLine(" ");
            //simplify the above foreach loop
            foreach (Student value in studentsTable.Values)
            {
                Console.WriteLine($"Student ID : {value.Id}");
                Console.WriteLine($"Student Name : {value.Name}");
                Console.WriteLine($"Student GPA : {value.GPA}");
            }

            Console.WriteLine("Hello World!");
        }
    }


}
