using System;
using System.Collections.Generic;

namespace Address_Book
{
    public class Program
    {
        public static List<PersonalDetails> Person = new List<PersonalDetails>();
        static void Main(string[] args)
        {
            Address_Book.CreateContacts.PersonInformations();
        }
    }
}
