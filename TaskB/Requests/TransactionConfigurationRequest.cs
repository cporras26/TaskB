using System.Collections.Generic;
using TaskB.Commons.TransactionsUtilitary;

namespace TaskA.API.Requests
{
    public class TransactionConfigurationRequest
    {
        public List<TransactionType> TransactionTypes { get; set; }
    }

}
