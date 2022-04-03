using AkumaNoMi.Data.Dtos;
using AkumaNoMi.Models;
using AutoMapper;

namespace AkumaNoMi.Profiles
{
    public class FrutaProfile : Profile
    {
        public FrutaProfile()
        {
            CreateMap<CreateFrutaDto, Fruta>();
            CreateMap<Fruta, ReadFrutaDto>();
            CreateMap<UpdateFrutaDto, Fruta>();
        }
    }
}
