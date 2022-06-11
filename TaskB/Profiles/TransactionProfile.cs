using AutoMapper;
using TaskA.API.Requests;
using TaskB.Commons.Dto;

namespace TaskB.API.Profiles
{
    public class TransactionProfile : Profile
    {
        public TransactionProfile(){
            CreateMap<TransactionConfigurationRequest, TransactionConfigurationRequestDto>();
        }
    }
}
