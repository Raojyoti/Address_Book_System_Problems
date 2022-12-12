using System;

namespace Add_multiple_persons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = "";
            while (command != "exit")
            {
                Console.Clear();
                Console.WriteLine("The commands are:\n  1.add\n 2.remove\n 3.edit\n 4.list\n 5.exit\n ");
                Console.WriteLine("Please enter a command: ");
                command = Console.ReadLine().ToLower();

                switch (command)
                {
                    case "add":
                        CreateContacts.PersonInformations();
                        break;
                    case "remove":
                        CreateContacts.DeletePerson();
                        break;
                    case "edit":
                        CreateContacts.EditOfDetails();
                        break;
                    case "list":
                        CreateContacts.ListPeople();
                        break;
                    default:
                        if (command != "exit")
                        {
                            CreateContacts.DisplayHelp();
                        }
                        break;
                }
            }
        }
    }
}
