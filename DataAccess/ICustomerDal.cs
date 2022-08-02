using Entity;

namespace DataAccess
{
    public interface ICustomerDal
    {
        List<Customer> GetAll();
    }
}