namespace ShekelHomeAsssignment.Models
{
    public class AddCustomerRequest 
    {
        private int _customerId;
        public int CustomerId
        {
            get { return _customerId; }
            set { _customerId = value; }
        }

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _address;

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        private string _phone;

        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }
        private int _groupKod;

        public int GroupKod
        {
            get { return _groupKod; }
            set { _groupKod = value; }
        }

        private int _factoryCode;

        public int FactoryCode
        {
            get { return _factoryCode; }
            set { _factoryCode = value; }
        }
    }
}
