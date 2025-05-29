using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuroDemo
{
    internal class VipCustomerFactory : ICustomerFactory
    {
        public Customer CreateCustomer(string name, string email)
        {
            Customer customer = new CustomerBuilder()
                .WithName(name)
                .WithEmail(email)
                .WithType(TypeCustomerEnum.Vip)
                .Build();
            return customer;
        }
    }
}
