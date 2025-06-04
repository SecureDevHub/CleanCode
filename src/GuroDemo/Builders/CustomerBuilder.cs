using System;

namespace GuroDemo
{
        internal class CustomerBuilder
        {
            private string _name;
            private string _email;
            private CustomerTypeEnum _typeCustomer;

            // Fluent setters
            public CustomerBuilder WithName(string name)
            {
                _name = name;
                return this;
            }

            public CustomerBuilder WithEmail(string email)
            {
                _email = email;
                return this;
            }

            public CustomerBuilder WithType(CustomerTypeEnum type)
            {
                _typeCustomer = type;
                return this;
            }

            // Fluent setters from console (optional step)
            public CustomerBuilder WithNameFromConsole()
            {
                Console.Write("Inserisci nome cliente: ");
                _name = Console.ReadLine();
                return this;
            }

            public CustomerBuilder WithEmailFromConsole()
            {
                Console.Write("Inserisci email: ");
                _email = Console.ReadLine();
                return this;
            }

            public CustomerBuilder WithTypeFromConsole()
            {
                Console.Write("Tipo cliente (Privato, Azienda, VIP): ");
                string type = Console.ReadLine();

                switch (type.ToLower())
                {
                    case "vip":
                        _typeCustomer = CustomerTypeEnum.Vip;
                        break;
                    case "azienda":
                        _typeCustomer = CustomerTypeEnum.Azienda;
                        break;
                    default:
                        _typeCustomer = CustomerTypeEnum.Privato;
                        break;
                }

                return this;
            }

            // Build final object
            public Customer Build()
            {
                if (string.IsNullOrWhiteSpace(_name))
                    throw new InvalidOperationException("Name is required.");
                if (string.IsNullOrWhiteSpace(_email))
                    throw new InvalidOperationException("Email is required.");

                return new Customer(_name, _email, _typeCustomer);
            }
        }
}
