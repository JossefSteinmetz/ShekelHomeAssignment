using System.ComponentModel.DataAnnotations;

namespace ShekelHomeAsssignment.Models
{
    public class Factory
    {

        private int _factoryCode;
        [Key]
        public int FactoryCode
        {
            get { return _factoryCode; }
            set { _factoryCode = value; }
        }

        private string _factoryName;

        public string FactoryName
        {
            get { return _factoryName; }
            set { _factoryName = value; }
        }

        private int _gorupCode;

        public int GorupCode
        {
            get { return _gorupCode; }
            set { _gorupCode = value; }
        }
    }
}
