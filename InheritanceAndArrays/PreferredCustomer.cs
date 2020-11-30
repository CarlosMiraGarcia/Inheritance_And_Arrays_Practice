namespace InheritanceAndArrays
{
    public class PreferredCustomer : Customer
    {
        public readonly decimal DiscountLevel;

        public PreferredCustomer(string name, string address, string phone, string id,
            string email, int spentAmount, bool onEmailList)
            : base(name, address, phone, email, onEmailList, spentAmount, id)
        {
            DiscountLevel = SetDiscountLevel();
        }

        public decimal SetDiscountLevel()
        {
            int range = SpentAmount / 500;

            switch (range)
            {
                case 0:
                    return 0;
                case 1:
                    return 0.05m;
                case 2:
                    return 0.06m;
                case 3:
                    return 0.08m;
                default:
                    return 0.1m;
            }
        }
        public double GetDiscount()
        {
            return SpentAmount * (double)DiscountLevel;
        }

        public override double CalcAmount()
        {
            return base.CalcAmount() - GetDiscount();
        }

        public override string ToString()
        {
            return string.Format(
                "Customer ID: {0}\nCustomer Name: {1}\nCustomer Address: {2}\nCustomer Phone: {3}\nCustomer Email: {4}\nCustomer Spending: {5:C2}" +
                "\nCustomer On Email List: {6}", CustomerID, CustomerName, Address, PhoneNumber, CustomerEmail, SpentAmount, OnEmailListing);
        }
    }
    
}
