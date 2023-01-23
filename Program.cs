namespace AddressBook
{
    class Program
    {
        public static List<Person> Personlist = new List<Person>();

        public static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Address Book Program");

            int z = 1, y = 991, flag = 0;
            string[] book = new string[10];

            AddressBookDetails operations = new AddressBookDetails();
            Console.WriteLine("Enter a number of Address Books you want to add: ");
            int ne = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < ne; i++)
            {

                String stringNumber = y.ToString();
                book[i] = "AddressBook" + " " + stringNumber;
                Console.WriteLine("The Address book unique name is: " + book[i]);

                while (z > 0)
                {
                    Console.WriteLine("Enter a number to do which operation: ");
                    Console.WriteLine("1)Add_Contact\t2)Display_Contacts\t3)Edit_Contact\t4)Delete_Contact\t5)Exit\t6)Search ");
                    int r = Convert.ToInt32(Console.ReadLine());


                    switch (r)
                    {
                        case 1:
                            operations.addPerson();
                            break;
                        case 2:
                            operations.display();

                            break;

                        case 3:
                            operations.edit();
                            break;
                        case 4:
                            operations.delete();
                            break;
                        case 5:
                            z = 0;
                            break;
                        case 6:
                            operations.search();
                            break;
                        default:
                            Console.WriteLine("Enter a valid number to do which operation:");
                            break;

                    }
                }
                if (i < ne)
                {
                    z = 1;
                }
                y++;
            }

        }
    }
}