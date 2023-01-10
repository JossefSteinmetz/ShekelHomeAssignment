using Microsoft.EntityFrameworkCore;
using ShekelHomeAsssignment.Models;

namespace ShekelHomeAsssignment.Data
{
    public class CustomerApiDbContext : DbContext
    {
        public CustomerApiDbContext(DbContextOptions options):base (options) 
        {
        }

        private DbSet<Customer> _customers;

        public DbSet<Customer> Customers    
        {
            get { return _customers; }
            set { _customers = value; }
        }

        private DbSet<Factory> _factories;

        public DbSet<Factory> Factories
        {
            get { return _factories; }
            set { _factories = value; }
        }
                
        private DbSet<Group> _gorups;

        public DbSet<Group> Gorups
        {
            get { return _gorups; ; }
            set { _gorups = value; }
        }

        private DbSet<FactoriesToCustomer> _factoriesToCustomer;                

        public DbSet<FactoriesToCustomer> FactoriesToCustomer
        {
            get { return _factoriesToCustomer; }
            set { _factoriesToCustomer = value; }
        }
    }
}
