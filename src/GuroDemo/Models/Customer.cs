using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuroDemo
{
    internal class Customer
    {
        public string Name;
        public string Email;
        public CustomerTypeEnum TypeCustomer;

        public Customer(string name, string email, CustomerTypeEnum typeCustomer)
        {
            Name = name;
            Email = email;
            TypeCustomer = typeCustomer;

        }
    }
}
