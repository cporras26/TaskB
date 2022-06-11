using System.Linq;
using TaskB.Commons.Dto;
using TaskB.Commons.TransactionsUtilitary;

namespace TaskB.BLL.Bll
{
    public class TransactionBll : ITransactionBll
    {
        public string transformToJsonDesired(TransactionConfigurationRequestDto request) {
            string jsonDesired = " {\n\t \"Transaction Configuration\":{";

            foreach (TransactionType transactionType in request.TransactionTypes) {
                jsonDesired += "\n\t\t\"" + transactionType.ID + "\":{ \n\t\t\t";
                jsonDesired += "\"Description\":" + "\"" + transactionType.Description + "\",\n\t\t\t";
                jsonDesired += "\"AnnulmentCode\":" + transactionType.AnnulmentCode + ",\n\t\t\t";
                jsonDesired += "\"HasTip\":" + transactionType.HasTip + ",\n\t\t\t";

                jsonDesired += "\"CurrencyConfiguration\":{\n\t\t\t\t";

                foreach (Currency currency in transactionType.Currencies) {
                    jsonDesired += "\"" + currency.Code + "\":{ \n\t\t\t\t\t";
                    jsonDesired += "\"MerchantID\":" + "\"" + currency.MerchantID + "\",\n\t\t\t\t\t";
                    jsonDesired += "\"TerminalID\":" + "\"" + currency.TerminalID + "\"\n\t\t\t\t";
                    jsonDesired += (currency.Code == transactionType.Currencies.Last().Code) ? "}\n\t\t\t}" : "},\n\t\t\t\t";
                }
                jsonDesired += (transactionType.ID == request.TransactionTypes.Last().ID) ? "\n\t\t}\n\t}\n}" : "\n\t\t},";

            }
            return jsonDesired;
        }
    }
}
