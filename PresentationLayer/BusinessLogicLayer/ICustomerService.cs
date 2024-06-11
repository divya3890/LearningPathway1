using DataLayer.Entity;


namespace BusinessLogicLayer
{
    public interface ICustomerService
    {
        Task<IEnumerable<Customer>> GetCustomerAsync();
    }
}
