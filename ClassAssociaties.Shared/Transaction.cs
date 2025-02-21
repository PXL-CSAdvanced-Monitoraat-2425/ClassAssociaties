using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssociaties.Shared
{
    public class Transaction
    {
        public enum _types { D, C };

        private double _amount;

        public double Amount
        {
            get { return _amount; }
            set { _amount = Math.Round(value, 2); }
        }

        private _types _type;

        public _types Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public Transaction(_types type, double amount)
        {
            Type = type;
            Amount = amount;
        }
    }
}
