using System.ComponentModel.DataAnnotations;

namespace ShekelHomeAsssignment.Models
{
    public class FactoriesToCustomer
    {
        private int _groupCode;

        public int GroupCode 
        {
            get { return _groupCode; }
            set { _groupCode = value; }
        }

        private int _factoryCode;           

        public int FactoryCode
        {
            get { return _factoryCode; }
            set { _factoryCode = value; }
        }

        private int _customerId;
        [Key]
        public int CustomerId
        {
            get { return _customerId; }
            set { _customerId = value; }
        }


    }
}
