using AutoMapper;
using ComexApiT2.Dtos;
using ComexApiT2.Models;

namespace ComexApiT2.Profiles
{
    public class ClienteProfile : Profile
    {
        public ClienteProfile()
        {
            CreateMap<CreateClienteDto, Cliente>();
            CreateMap<UpdateClienteDto, Cliente>();
            CreateMap<Cliente, ReadClienteDto>()
                .ForMember(dto => dto.Endereco, opt => opt.MapFrom(cliente => cliente.Endereco));
        }
    }
}
