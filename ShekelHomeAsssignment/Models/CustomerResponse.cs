namespace ShekelHomeAsssignment.Models
{
    public class CustomerResponse
    {
        private int _customerId;

        public int CustomerId
        {
            get { return _customerId; }
            set { _customerId = value; }
        }

        private string _customerName;

        public string CustomerName
        {
            get { return _customerName; }
            set { _customerName = value; }
        }

    }
}
