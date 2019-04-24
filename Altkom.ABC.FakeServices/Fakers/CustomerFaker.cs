using Altkom.ABC.Models;
using Bogus;
using System;
using System.Collections.Generic;
using System.Text;

namespace Altkom.ABC.FakeServices.Fakers
{
    // Install-Package Bogus
    public class CustomerFaker : Faker<Customer>
    {
        public CustomerFaker()
        {
            StrictMode(true);
            RuleFor(p => p.Id, f => f.IndexFaker);
            RuleFor(p => p.FirstName, f => f.Person.FirstName);
            RuleFor(p => p.LastName, f => f.Person.LastName);
            RuleFor(p => p.Salary, f => f.Random.Decimal(100, 200));
            RuleFor(p => p.IsDeleted, f => f.Random.Bool(0.2f));
            RuleFor(p => p.Description, f => f.Lorem.Sentence());
        }
    }
}
