using NHibernate;

namespace CCSARestaurant
{
    internal class CustomerRep
    {
        private ISessionFactory sessionFactory;

        public CustomerRep(ISessionFactory sessionFactory)
        {
            this.sessionFactory = sessionFactory;
        }

        internal void DeleteCustomer(string customer)
        {
            throw new NotImplementedException();
        }

        internal object GetCustomer()
        {
            throw new NotImplementedException();
        }

        internal string GetCustomerById(int id)
        {
            throw new NotImplementedException();
        }

        internal void UpdateCustomer(string existingCustomer)
        {
            throw new NotImplementedException();
        }
    }
}