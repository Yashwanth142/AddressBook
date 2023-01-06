namespace AddressBook
{
    class Program
    {
        public static List<Person> Personlist = new List<Person>();
        public static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Address Book Program");

            AddressBookDetails operations = new AddressBookDetails();
            operations.addPerson();
            operations.display();
            operations.edit();
            Console.WriteLine("After the Edit");
            operations.display();
            operations.delete();
            
        }
    }
}