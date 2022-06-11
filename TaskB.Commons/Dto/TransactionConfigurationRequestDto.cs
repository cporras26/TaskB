using System.Collections.Generic;
using TaskB.Commons.TransactionsUtilitary;

namespace TaskB.Commons.Dto
{
    public class TransactionConfigurationRequestDto
    {
        public List<TransactionType> TransactionTypes { get; set; }
    }
}
