using System;
using System.IO;

namespace InheritanceAndArrays
{
    public static class DataOperations
    {
        public static PreferredCustomer[] preferredCustomers;
        public static string enteredID;
        public static void GetData()
        {
            using (var reader = new StreamReader("CustomerInfo.txt"))
            {
                var index = 0;
                preferredCustomers = new PreferredCustomer[5];

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine().Split(':');
                    var name = line[0];
                    var address = line[1];
                    var phone = line[2];
                    var id = line[3];
                    var email = line[4];
                    var spentAmount = Convert.ToInt32(line[5]);
                    var onEmailList = Convert.ToBoolean(line[6]);
                    preferredCustomers[index] = new PreferredCustomer(name, address, phone, id, email, spentAmount, onEmailList);
                    index++;
                }
            }
        }

        public static void UpdateData(int index)
        {
            using(var writer = new StreamWriter("CustomerInfo2.txt"))

            for (int i = 0; i < 5; i++)
                { 
                var name = preferredCustomers[i].CustomerName;
                var address = preferredCustomers[i].Address;
                var phone = preferredCustomers[i].PhoneNumber;
                var id = preferredCustomers[i].CustomerID;
                var email = preferredCustomers[i].CustomerEmail;
                var updatedSpentAmount = preferredCustomers[i].SpentAmount;
                var onEmailList = preferredCustomers[i].OnEmailListing;

                    if (i == index)
                    {
                        updatedSpentAmount = (int)preferredCustomers[i].CalcAmount();
                    }

                writer.WriteLine("{0}:{1}:{2}:{3}:{4}:{5}:{6}", name, address, phone, id, email, updatedSpentAmount, onEmailList == true? "true" : "false");
            }  
        }

        public static int GetID()
        {
            do
            {
                var customerIndex = 0;
                Console.Write("Please enter user ID: ");
                string entererdID = Console.ReadLine();
                foreach (var id in preferredCustomers)
                {
                    if (id.CustomerID == entererdID)
                    {
                        return customerIndex;
                    }

                    else
                    {
                        customerIndex++;
                    }
                }
                Console.Write("ID does not exists.\n");
            }
            while (true);
        }

        public static string UserChoice()
        {
            var userChoice = Console.ReadLine();
            while (userChoice != "1" & userChoice != "2")
            {
                Console.WriteLine("Wrong entry. Try again");
                DisplayMenu();
                userChoice = Console.ReadLine();

            }
            return userChoice;
        }

        public static void DisplayMenu()
        {
            Console.WriteLine("1. Display Customer Information");
            Console.WriteLine("2. Update Customer Information");
            Console.Write("Please, enter your choice: ");
        }
    }  
}
