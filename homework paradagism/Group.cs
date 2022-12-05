using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_paradagism
{
    public class Group
    {
        public string No;
        public byte Limit;
        private Student[] Students =new Student[0];
        public Group(string no,byte limit)
        {
            No = no;
            Limit = limit;
        }
 
        public void addStudent()
        {
            int i = 0;
            if (i <= Limit)
            {
                Console.Write("Enter the name:");
                string name = Console.ReadLine();
                Console.Write("Enter the surname:");
                string surname = Console.ReadLine();
                Console.Write("enter the group number:");
                string group = Console.ReadLine();
                Student student = new Student(name, surname, group);
                Array.Resize(ref Students, Students.Length + 1);
                Students[Students.Length-1] = student;
                Console.Clear();
                Console.WriteLine("Student was successfully added");
                i++;
                Console.WriteLine();
            }

        }
        public void listOfGroup()
        {
            Console.Clear();
                int i = 1;
            foreach (var student in Students)
            {
                Console.WriteLine(i + ". " + student);
                i++;
            }
            Console.WriteLine( );
        }
    }
}
