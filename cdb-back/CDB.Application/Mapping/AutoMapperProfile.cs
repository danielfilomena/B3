using AutoMapper;
using CDB.Application.DTOs;
using CDB.Domain.Entities;

namespace CDB.Application.Mapping
{
    public class AutoMapperProfile : Profile
    {

        public AutoMapperProfile()
        {
            
            CreateMap<CalculoCDBDto, Calculo>().ReverseMap();
            CreateMap<RetornoCalculoDto, RetornoCalculo>().ReverseMap();
            CreateMap<ImpostoDTO, Imposto>().ReverseMap();

        }

    }
}
