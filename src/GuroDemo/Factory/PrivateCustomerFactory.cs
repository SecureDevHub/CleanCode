using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuroDemo
{
    internal class PrivateCustomerFactory : ICustomerFactory
    {
        public Customer CreateCustomer(string name, string email)
        {
            Customer customer = new CustomerBuilder()
                .WithName(name)
                .WithEmail(email)
                .WithType(CustomerTypeEnum.Privato)
                .Build();
            return customer;
        }
    }
}
