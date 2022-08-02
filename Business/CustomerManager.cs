using DataAccess;
using Entity;

namespace Business
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public List<Customer> GetAll()
        {
            return _customerDal.GetAll();
        }

        public List<Customer> GetCustomerByInitial(string v)
        {
            return _customerDal.GetAll().Where(x => x.FirstName.ToUpper().StartsWith(v.ToUpper())).ToList();
        }
    }
}