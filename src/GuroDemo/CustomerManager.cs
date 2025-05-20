using System;

namespace GuroDemo
{
    internal class CustomerManager
    {
        private string Name { get; set; }
        private string Email { get; set; }
        TypeCustomerEnum CustomerEnum { get; set; }

        public CustomerManager()
        {
        }

        public Customer GetCustomer()
        {
            SetDataCustomer();
            Customer customer = new Customer(Name, Email, CustomerEnum);
            return customer;
        }

        private void SetDataCustomer()
        {
            Console.WriteLine("Inserisci nome cliente:");
            Name = Console.ReadLine();
            Console.WriteLine("Inserisci email:");
            Email = Console.ReadLine();
            Console.WriteLine("Tipo cliente (Privato, Azienda, VIP):");
            string type = Console.ReadLine();
            switch (type.ToLower())
            {
                case "vip":
                    CustomerEnum = TypeCustomerEnum.Vip; break;
                case "azienda":
                    CustomerEnum = TypeCustomerEnum.Azienda; break;
                default:
                    CustomerEnum = TypeCustomerEnum.Private; break;
            }
        }
    }
}
