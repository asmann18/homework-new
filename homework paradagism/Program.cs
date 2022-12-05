namespace homework_paradagism
{
    internal class Program
    {
        private static string choose;

        static void Main(string[] args)
        {
                    Group group = new Group("327", 30);
            restart:
            Console.WriteLine($"1.Add a new student");
            Console.WriteLine($"2.List of Group");
            choose = Console.ReadLine();
            switch (choose)
            {
                case "1":
                    group.addStudent();
                    goto restart;
                    break;
                case "2":
                    group.listOfGroup();
                    goto restart;
                    break;
            }
        }
    }
}