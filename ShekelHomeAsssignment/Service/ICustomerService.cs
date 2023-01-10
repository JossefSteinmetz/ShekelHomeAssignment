using ShekelHomeAsssignment.Models;

namespace ShekelHomeAsssignment.Service
{
    public interface ICustomerService 
    {
        public Task<bool> AddCustomer(AddCustomerRequest customerRequest);

        public Task<GroupResponse> GetGroup(int groupId);
    }
}
