using System;

namespace Delete_person_using_person_name
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = "";
            while (command != "exit")
            {
                Console.Clear();
                Console.WriteLine("The commands are:\n  1.add\n 2.delete\n 3.edit\n 4.list\n 5.exit\n ");
                Console.WriteLine("Please enter a command: ");
                command = Console.ReadLine().ToLower();

                switch (command)
                {
                    case "add":
                        CreateContacts.PersonInformations();
                        break;
                    case "delete":
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
