using ShekelHomeAsssignment.Data;
using ShekelHomeAsssignment.Models;
using ShekelHomeAsssignment.Utilities;

namespace ShekelHomeAsssignment.Service
{
    public class CustomerService : ICustomerService
    {
        #region Service Decleration

        private readonly CustomerApiDbContext _dbContext;

        #endregion

        public CustomerService(CustomerApiDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> AddCustomer(AddCustomerRequest customerRequest)
        {

            var customer = new Customer()
            {
                CustomerId = customerRequest.CustomerId,
                Address = customerRequest.Address,
                Phone = customerRequest.Phone,
                Name = customerRequest.Name,
            };

            var customerResult = await _dbContext.Customers.FindAsync(customer);
            if (customerResult != null)
                throw new ErrorResponse(403, "Customer With The Same Id Already Registered");
            
            await _dbContext.Customers.AddAsync(customer);

            var group = await _dbContext.Gorups.FindAsync(customerRequest.GroupKod);
            if (group == null)
            {
                 await _dbContext.Gorups.AddAsync(new Group
                {
                    GroupKod = customerRequest.GroupKod
                    ,
                    GroupName = EntitiesUtilities.CreateRAndomString()
                });
            }
            var factory = _dbContext.Factories.FindAsync(customerRequest.FactoryCode);
            if (factory == null)
                await _dbContext.Factories.AddAsync(new Factory()
                {
                    FactoryCode = customerRequest.FactoryCode
                    ,
                    GorupCode = customerRequest.GroupKod
                    ,
                    FactoryName = EntitiesUtilities.CreateRAndomString()
                });

            await _dbContext.FactoriesToCustomer.AddAsync(new FactoriesToCustomer()
            {
                FactoryCode = customerRequest.FactoryCode,
                GroupCode = customerRequest.GroupKod,
                CustomerId = customerRequest.CustomerId,
            });
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public Task<GroupResponse> GetGroup(int groupId)
        {
            var group = _dbContext.Gorups.Find(groupId);
            if (group == null)
                throw new ErrorResponse(404,"There is no gorup with the given ID");


            var CustomersWithGroup = from factory in _dbContext.FactoriesToCustomer
                                     join customer in _dbContext.Customers
                                     on factory.CustomerId equals customer.CustomerId
                                     select new CustomerResponse()
                                     {
                                         CustomerId = customer.CustomerId,
                                         CustomerName = customer.Name,
                                     };


            var groupResponse = new GroupResponse()
            {
                GroupCode = group.GroupKod,
                GroupName = group.GroupName,
                Customers = new List<CustomerResponse>(CustomersWithGroup)
            };

            return Task.FromResult(groupResponse);
        }
    }
}
