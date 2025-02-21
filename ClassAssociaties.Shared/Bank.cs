using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssociaties.Shared
{
    public class Bank
    {
        public List<BankAccount> Customers { get; set; } = new List<BankAccount>();
        public string Name { get; set; }

        public List<string> GetAllCustomers()
        {
            List<string> customerNames = new List<string>();
            foreach (var account in Customers)
            {
                customerNames.Add($"{account.Owner.FirstName} {account.Owner.LastName}");
            }
            return customerNames;
        }

        public void AddCustomer(BankAccount account)
        {
            Customers.Add(account);
        }

        public double ShowBankCapital()
        {
            double total = 0;
            foreach (var account in Customers)
            {
                total += account.Saldo();
            }
            return total;
        }
    }
}
