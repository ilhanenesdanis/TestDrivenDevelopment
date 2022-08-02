using Entity;

namespace Business
{
    public interface ICustomerService
    {
        List<Customer> GetAll();
        List<Customer> GetCustomerByInitial(string v);
    }
}