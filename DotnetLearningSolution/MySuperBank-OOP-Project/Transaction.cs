using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MySuperBank
{
    public class Transaction
    {
        public decimal Amount { get; }
        public DateTime Date { get; set; }
        public String Notes { get; }

        public Transaction(decimal amount, DateTime date, string note) 
        { 
            this.Amount = amount;
            this.Date = date;
            this.Notes = note;
        }
    }
}
