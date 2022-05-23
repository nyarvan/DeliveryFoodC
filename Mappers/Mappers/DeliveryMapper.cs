using API;
using AutoMapper;
using BLL;
using DataBase;

namespace Mappers
{
    public class DeliveryMapper : Profile
    {
        public DeliveryMapper()
        {
            CreateMap<DeliveryClass, Delivery>().ReverseMap();
            CreateMap<DeliveryClass, DeliveryModel>().ReverseMap();
        }
    }
}
