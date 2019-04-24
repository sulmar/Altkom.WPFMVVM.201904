using System;
using System.Linq;
using Altkom.ABC.FakeServices;
using Altkom.ABC.FakeServices.Fakers;
using Altkom.ABC.ViewModels;
using FluentAssertions;
using FluentAssertions.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Altkom.ABC.UnitTests
{
    [TestClass]
    public class CustomersViewModelUnitTests
    {
        [TestMethod]
        public void LoadTest()
        {
            // Arrange
            CustomersViewModel customersViewModel = new CustomersViewModel(new FakeCustomersService(new CustomerFaker()));

            // Acts
            customersViewModel.Load();

            // Assert
            Assert.IsNotNull(customersViewModel.Customers);
            Assert.IsTrue(customersViewModel.Customers.Any());


        }

        [TestMethod]
        public void ExecutionLoadTest()
        {
            // Arrange
            CustomersViewModel customersViewModel = new CustomersViewModel(new FakeCustomersService(new CustomerFaker()));

            customersViewModel.ExecutionTimeOf(s=>s.Load()).Should().BeLessOrEqualTo(200.Milliseconds());


        }
    }
}
