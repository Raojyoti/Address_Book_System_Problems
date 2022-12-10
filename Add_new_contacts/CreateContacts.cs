using System;
using System.Collections.Generic;
using System.Text;

namespace Address_Book
{
    public class CreateContacts
    {
        public static void PersonInformations()
        {
            PersonalDetails contacts = new PersonalDetails();
            Console.Write("Enter First Name:   ");
            contacts.firstName = Console.ReadLine();
            Console.Write("Enter Last Name:   ");
            contacts.lastName = Console.ReadLine();
            Console.Write("Enter Address:   ");
            contacts.address = Console.ReadLine();
            Console.Write("Enter City Name:   ");
            contacts.city = Console.ReadLine();
            Console.Write("Enter State Name:   ");
            contacts.state = Console.ReadLine();
            Console.Write("Enter ZipCode:   ");
            contacts.zipcode = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Phone Number:   ");
            contacts.phonenumber = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Email Id:   ");
            contacts.email = Console.ReadLine();
            Program.Person.Add(contacts);

            Console.WriteLine(" \n ");
            Console.WriteLine("Details of the Person:  ");
            Console.WriteLine("------------------------");
            Console.Write("\n");
            Console.WriteLine("First Name: " + contacts.firstName);
            Console.WriteLine("Last Name: " + contacts.lastName);
            Console.WriteLine("Address: " + contacts.address);
            Console.WriteLine("City: " + contacts.city);
            Console.WriteLine("State: " + contacts.state);
            Console.WriteLine("Zip Code: " + contacts.zipcode);
            Console.WriteLine("Phone Number: " + contacts.phonenumber);
            Console.WriteLine("Email Id: " + contacts.email);

        }
    }
}
