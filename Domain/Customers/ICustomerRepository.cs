namespace Domain.Customers;

public interface ICustomerRepository
{
    Task<Customers?> GetByIdAsync(CustomerId id);
}