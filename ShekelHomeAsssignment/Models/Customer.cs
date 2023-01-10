using System.ComponentModel.DataAnnotations;

namespace ShekelHomeAsssignment.Models
{
    public class Customer
    {
        private int _customerId;
        [Key]
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

        public Customer()
        {

        }

        public Customer(Customer customer)
        {
            this.CustomerId = customer.CustomerId;
            this.Name = customer.Name;
            this.Address = customer.Address;
            this.Phone = customer.Phone;
        }
    }
}
