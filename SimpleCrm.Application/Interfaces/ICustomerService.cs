using SimpleCrm.Application.Dto;

namespace SimpleCrm.Application.Interfaces
{
    public interface ICustomerService
    {
        IEnumerable<CustomerForReport> Get4Report();
        IEnumerable<CustomerDto> GetAllCustomers();
        CustomerDto GetCustomerById(Guid id);
        CustomerDto GetCustomerByTaxNumber(string taxNumber);
    }
}
