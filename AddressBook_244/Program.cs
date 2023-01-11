namespace AddressBook_244
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Welcome To Address Book Problem");

            //AdressBookBuilder adressBookBuilder = new AdressBookBuilder();
            //adressBookBuilder.AddAdressBook("Ram", "Sharma", "Sadar", "Nagpur", "Maharashtra", "440009", "7973455678", "Ram199@gmail.com");
            //adressBookBuilder.DisplayAddressBook();

            AdressBookBuilder adressBookBuilder = new AdressBookBuilder();

            bool check = true;
            while (check)
            {

                Console.WriteLine("Enter First Name");
                string firstName = Console.ReadLine();

                Console.WriteLine("Enter Last Name");
                string lastName = Console.ReadLine();

                Console.WriteLine("Enter Address");
                string address = Console.ReadLine();

                Console.WriteLine("Enter City Name");
                string city = Console.ReadLine();


                Console.WriteLine("Enter State Name");
                string state = Console.ReadLine();

                Console.WriteLine("Enter  Zip number");
                string zip = Console.ReadLine();

                Console.WriteLine("Enter Phone Number");
                string pnoneNumber = Console.ReadLine();

                Console.WriteLine("Enter Email");
                string email = Console.ReadLine();

                adressBookBuilder.AddAdressBook(firstName, lastName, address, city, state, zip, pnoneNumber, email);

                Console.WriteLine("If you want to add another Enter Y ");
                string addOrNot = Console.ReadLine().ToLower();

                if (addOrNot == "y")
                {
                    check = true;
                }
                else
                {
                    check = false;
                }
            }
            adressBookBuilder.DisplayAddressBook();


        }

    }
}
