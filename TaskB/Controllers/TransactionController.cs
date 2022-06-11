using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TaskA.API.Requests;
using TaskB.BLL.Bll;
using TaskB.Commons.Dto;

namespace TaskB.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TransactionController : ControllerBase
    {
        private readonly ILogger _logger;
        private readonly IMapper _mapper;
        private readonly ITransactionBll _transactionBll;

        public TransactionController(ILogger<TransactionController> logger, ITransactionBll transactionBll, IMapper mapper)
        {
            _logger = logger;
            _transactionBll = transactionBll;
            _mapper = mapper;
        }

        [HttpPost]
        public string Post([FromBody] TransactionConfigurationRequest request)
        {
            var requestDto = _mapper.Map<TransactionConfigurationRequest, TransactionConfigurationRequestDto>(request);
            return _transactionBll.transformToJsonDesired(requestDto);
        }
    }
}