using AutoMapper;
using ComexApiT2.Dtos;
using ComexApiT2.Models;

namespace ComexApiT2.Profiles
{
    public class ProdutoProfile : Profile
    {
        public ProdutoProfile()
        {
            CreateMap<CreateProdutoDto, Produto>();
            CreateMap<UpdateProdutoDto, Produto>();
            CreateMap<Produto, ReadProdutoDto>();
        }
    }
}
