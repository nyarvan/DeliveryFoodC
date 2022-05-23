using API;
using AutoMapper;
using BLL;
using DataBase;

namespace Mappers
{
    public class SetMapper : Profile
    {
        public SetMapper()
        {
            CreateMap<SetClass, Set>().ReverseMap();
            CreateMap<SetClass, SetModel>().ReverseMap();
        }
    }
}
