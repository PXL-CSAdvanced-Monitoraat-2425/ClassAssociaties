using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssociaties.Shared
{
    public class BankAccount
    {
        public Person Owner { get; set; }
        public string AccountNumber { get; set; }
        public List<Transaction> Transactions { get; set; } = new List<Transaction>();

        public void AddTransaction(Transaction transaction)
        {
            Transactions.Add(transaction);
        }

        public double Saldo()
        {
            double saldo = 0;
            foreach (var transaction in Transactions)
            {
                saldo += (transaction.Type == Transaction._types.D ? 1 : -1) * transaction.Amount;
            }
            return saldo;
        }

        public override string ToString()
        {
            return $"Nieuw saldo van {Owner.FirstName} = {Saldo()}";
        }
    }
}
