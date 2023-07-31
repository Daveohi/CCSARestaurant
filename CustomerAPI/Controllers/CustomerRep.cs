using NHibernate;

namespace CustomerAPI.Controllers
{
    internal class CustomerRep
    {
        private ISessionFactory sessionFactory;

        public CustomerRep(ISessionFactory sessionFactory)
        {
            this.sessionFactory = sessionFactory;
        }

        internal void DeleteCustomer(object customer)
        {
            throw new NotImplementedException();
        }

        internal object GetCustomer()
        {
            throw new NotImplementedException();
        }

        internal object GetCustomerById(int id)
        {
            throw new NotImplementedException();
        }

        internal void UpdateCustomer(object existingCustomer)
        {
            throw new NotImplementedException();
        }
    }
}