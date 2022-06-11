using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskB.DAL.Models
{
    public class CurrencyConfiguration
    {
        public int CurrencyCode { get; set; }
        public int MerchantID { get; set; }
        public int TerminalID { get; set; }
    }
}
