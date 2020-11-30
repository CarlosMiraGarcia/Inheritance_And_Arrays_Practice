namespace InheritanceAndArrays
{
    public class Customer : Person
    {
        public string CustomerID { get; set; }
        public string CustomerEmail { get; set; }
        public bool OnEmailListing { get; set; }
        public int SpentAmount { get; set; }

        public Customer(string name, string address, string phoneNumber, string email, bool emailListing, int spentAmount, string customerId)
            : base(name, address, phoneNumber)
        {
            CustomerEmail = email;
            OnEmailListing = emailListing;
            SpentAmount = spentAmount;
            CustomerID = customerId;
        }

        public virtual double CalcAmount()
        {
            return SpentAmount;
        }
    }
}
