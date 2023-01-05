namespace AddressBook
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Address Book Program");

            Console.WriteLine("enter the number of cantacts you want to add: ");
            int n = Convert.ToInt32(Console.ReadLine());
            AddressBookArray addressBookArray = new AddressBookArray();
            addressBookArray.addPerson(n);
        }
    }
}