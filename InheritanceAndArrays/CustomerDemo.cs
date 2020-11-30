using System;

namespace InheritanceAndArrays
{
    class CustomerDemo
    {
        static void Main(string[] args)
        {
            do
            {
                DataOperations.GetData();
                var customerIndex = DataOperations.GetID();
                DataOperations.DisplayMenu();

                if (DataOperations.UserChoice() == "1")
                {
                    Console.WriteLine(DataOperations.preferredCustomers[customerIndex].ToString());
                }

                else
                {
                    DataOperations.UpdateData(customerIndex);
                }
            }

            while (true);
        }
    }
}
