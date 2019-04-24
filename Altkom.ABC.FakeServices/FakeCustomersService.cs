using Altkom.ABC.FakeServices.Fakers;
using Altkom.ABC.IServices;
using Altkom.ABC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Altkom.ABC.FakeServices
{
    public class FakeCustomersService : ICustomersService
    {
        private readonly ICollection<Customer> customers;

        private readonly CustomerFaker customerFaker;

        public FakeCustomersService(CustomerFaker customerFaker)
        {
            this.customerFaker = customerFaker;

            customers = customerFaker.Generate(5000);
        }

        public void Add(Customer entity)
        {
            customers.Add(entity);
        }

        public IEnumerable<Customer> Get()
        {
            Thread.Sleep(TimeSpan.FromMilliseconds(500));
            return customers;
        }

        public Customer Get(int id)
        {
            return customers.SingleOrDefault(c => c.Id == id);
        }

        public void Remove(int id)
        {
            Customer customer = Get(id);
            customers.Remove(customer);
        }

        public void Update(Customer entity)
        {
            throw new NotImplementedException();
        }
    }
}
