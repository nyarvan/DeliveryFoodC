using API;
using AutoMapper;
using BLL;
using DataBase;

namespace Mappers
{
    public class FoodMapper : Profile
    {
        public FoodMapper()
        {
            CreateMap<FoodClass, Food>().ReverseMap();
            CreateMap<FoodClass, FoodModel>().ReverseMap();
        }
    }
}
