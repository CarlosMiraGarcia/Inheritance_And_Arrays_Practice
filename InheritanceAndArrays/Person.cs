namespace InheritanceAndArrays
{
    public abstract class Person
    {
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }

        public Person(string name, string address, string phoneNumber)
        {
            CustomerName = name;
            Address = address;
            PhoneNumber = phoneNumber;
        }
    }    
}
