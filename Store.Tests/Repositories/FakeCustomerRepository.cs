using Store.Domain.Entities;
using Store.Domain.Repositories;

// Mocks "Existem frameworks que fazem isso bem mais fácil"
namespace Store.Tests.Repositories
{
    public class FakeCustomerRepository : ICustomerRepository
    {
        public Customer Get(string document)
        {
            if (document == "12345678911")
                return new Customer("Bruce Wayne", "batman@balta.io");

            return null;
        }
    }
}