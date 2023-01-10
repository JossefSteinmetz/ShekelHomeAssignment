using System.ComponentModel.DataAnnotations;

namespace ShekelHomeAsssignment.Models
{
    public class Group
    {
        private int _groupKod;
        [Key]
        public int GroupKod
        {
            get { return _groupKod; }
            set { _groupKod = value; }
        }

        private string _groupName;

        public string GroupName
        {
            get { return _groupName; }
            set { _groupName = value; }
        }


    }
}
