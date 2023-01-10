namespace ShekelHomeAsssignment.Models
{
    public class GroupResponse
    {
        private int _groupCode;

        public int GroupCode
        {
            get { return _groupCode; }
            set { _groupCode = value; }
        }

        private string  _groupName;

        public string  GroupName
        {
            get { return _groupName; }
            set { _groupName = value; }
        }

        private List<CustomerResponse> _customers;

        public List<CustomerResponse> Customers
        {
            get { return _customers; }
            set { _customers = value; }
        }
    }
}
