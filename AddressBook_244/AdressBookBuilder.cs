using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_244
{
    internal class AdressBookBuilder
    {
        Dictionary<string, Model> addressBookMap = new Dictionary<string, Model>();
        //public AdressBookBuilder()
        //{
        //    this.addressBookMap = new Dictionary<string, Person>();
        //}

        public void AddAdressBook(string firstName, string lastName, string address, string city, string state, string zip, string phoneNumber, string eMail)
        {
            Model model = new Model(firstName, lastName, address, city, state, zip, phoneNumber, eMail);
            addressBookMap.Add(firstName, model);
        }
        public void DisplayAddressBook()
        {
            foreach (var item in addressBookMap)
            {
                Console.WriteLine($" First Name :: {item.Value.firstName}");
                Console.WriteLine($" Last Name :: {item.Value.lastName} ");
                Console.WriteLine($" Address :: {item.Value.address} ");
                Console.WriteLine($" City :: {item.Value.city} ");
                Console.WriteLine($" State :: {item.Value.state} ");
                Console.WriteLine($" Zip :: {item.Value.zip}");
                Console.WriteLine($" Phone Number :: {item.Value.phoneNumber} ");
                Console.WriteLine($" Email :: {item.Value.eMail} ");
            }
        }
    }
}
