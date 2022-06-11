using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskB.Commons.TransactionsUtilitary
{
    public class TransactionType
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public int AnnulmentCode { get; set; }
        public bool HasTip { get; set; }
        public List<Currency> Currencies { get; set; }
    }
}
