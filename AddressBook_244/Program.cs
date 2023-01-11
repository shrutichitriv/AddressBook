namespace AddressBook_244
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Welcome To Address Book Problem");

            AdressBookBuilder adressBookBuilder = new AdressBookBuilder();
            adressBookBuilder.AddAdressBook("Ram", "Sharma", "Sadar", "Nagpur", "Maharashtra", "440009", "7973455678", "Ram199@gmail.com");
            adressBookBuilder.DisplayAddressBook();
        }
            
    }
}
