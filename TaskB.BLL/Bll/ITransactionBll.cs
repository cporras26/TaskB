using TaskB.Commons.Dto;

namespace TaskB.BLL.Bll
{
    public interface ITransactionBll
    {
        public string transformToJsonDesired(TransactionConfigurationRequestDto request);
    }
}
