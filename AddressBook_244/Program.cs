namespace AddressBook_244
{
    class Program
    {

        public static void Main(string[] args)
        {

            Console.WriteLine("Welcome To Address Book Problem");

            ////AdressBookBuilder adressBookBuilder = new AdressBookBuilder();
            ////adressBookBuilder.AddAdressBook("Ram", "Sharma", "Sadar", "Nagpur", "Maharashtra", "440009", "7973455678", "Ram199@gmail.com");
            ////adressBookBuilder.DisplayAddressBook();

            //AdressBookBuilder adressBookBuilder = new AdressBookBuilder();

            //bool check = true;
            //while (check)
            //{

            //    Console.WriteLine("Enter First Name");
            //    string firstName = Console.ReadLine();

            //    Console.WriteLine("Enter Last Name");
            //    string lastName = Console.ReadLine();

            //    Console.WriteLine("Enter Address");
            //    string address = Console.ReadLine();

            //    Console.WriteLine("Enter City Name");
            //    string city = Console.ReadLine();


            //    Console.WriteLine("Enter State Name");
            //    string state = Console.ReadLine();

            //    Console.WriteLine("Enter  Zip number");
            //    string zip = Console.ReadLine();

            //    Console.WriteLine("Enter Phone Number");
            //    string pnoneNumber = Console.ReadLine();

            //    Console.WriteLine("Enter Email");
            //    string email = Console.ReadLine();

            //    adressBookBuilder.AddAdressBook(firstName, lastName, address, city, state, zip, pnoneNumber, email);

            //    Console.WriteLine("If you want to add another Enter Y ");
            //    string addOrNot = Console.ReadLine().ToLower();

            //    if (addOrNot == "y")
            //    {
            //        check = true;
            //    }
            //    else
            //    {
            //        check = false;
            //    }
            //}
            //adressBookBuilder.DisplayAddressBook();


            ////AdressBookBuilder adressBookBuilder = new AdressBookBuilder();

            ////adressBookBuilder.AddAdressBook("Amit", "Roy", "Ram nagar", "Dknl", "Kolkata", "759022", "7978861488", "amit@gmail.com");
            ////adressBookBuilder.AddAdressBook("Raj", "Kumar", "Jatpura", "Fshh", "Raipur", "759023", "7978861434", "raj@gmail.com");
            ////adressBookBuilder.AddAdressBook("Mamta", "Shah", "Gandhibagh", "Ghji", "Kolhapur", "759024", "7978861484", "mamta@gmail.com");
            ////adressBookBuilder.AddAdressBook("Mayank", "Kapoor", "Nagar", "Dfgh", "Satara", "759025", "7978861485", "mayank@gmail.com");
            ////adressBookBuilder.DisplayAddressBook();


            //////For Editiang A Person Contact Details

            ////Console.WriteLine("Enter a person name u want to Edit Details");
            ////string editName = Console.ReadLine();
            ////adressBookBuilder.EditContact(editName);
            ////adressBookBuilder.DisplayAddressBook();

            //Console.WriteLine("Choose : \n1) To Edit A Contact Details\n2) To Delete A Contact Details");
            //int choice = Convert.ToInt32(Console.ReadLine());

            //switch (choice)
            //{
            //    case 1:
            //        //For Editiang A Person Contact Details
            //        Console.WriteLine("Enter a person name u want to Edit Details");
            //        string editName = Console.ReadLine();
            //        adressBookBuilder.EditContact(editName);
            //        adressBookBuilder.DisplayAddressBook();
            //        break;
            //    case 2:
            //        //For Deleate A Person Contact Details
            //        Console.WriteLine("Enter a person name u want to remove");
            //        string name = Console.ReadLine();
            //        adressBookBuilder.RemoveContact(name);
            //        adressBookBuilder.DisplayAddressBook();
            //        break;
            //    default:
            //        Console.WriteLine("Please Choose 1 for Edit Or 2 for Delete");
            //        break;
            //}


            AddressBookMain createContact = new AddressBookMain();
            bool end = true;
            while (true)
            {
                Console.WriteLine("Choose an option to execute the program : \n1. Add a contact\n2. Display contact\n3." +
                    " Edit a contact\n4. Delete a contact\n5. End the program");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        createContact.CreateContact();
                        break;
                    case 2:
                        createContact.Display();
                        break;
                    case 3:
                        createContact.EditContact();
                        break;
                    case 4:
                        createContact.DeleteContact();
                        break;
                    case 5:
                        createContact.ViewContact();
                        break;
                    case 6:
                        end = false;
                        break;
                    default:
                        Console.WriteLine("Incorrect Option ");
                        break;
                }
            }
        }
    }
}
