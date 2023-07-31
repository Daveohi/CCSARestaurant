using NHibernate;

namespace ChefAPI.Controllers
{
    internal class ChefRep
    {
        private ISessionFactory sessionFactory;

        public ChefRep(ISessionFactory sessionFactory)
        {
            this.sessionFactory = sessionFactory;
        }

        internal void DeleteChef(object chef)
        {
            throw new NotImplementedException();
        }

        internal void DeleteCustomer(string customer)
        {
            throw new NotImplementedException();
        }

        internal object GetChef()
        {
            throw new NotImplementedException();
        }

        internal string GetChefById(int id)
        {
            throw new NotImplementedException();
        }

        internal void UpdateChef(object existingChef)
        {
            throw new NotImplementedException();
        }
    }
}