using System.Collections.Generic;
using BLL;
using AutoMapper;

namespace API
{
    public class FoodController : IController<FoodModel>
    {
        private readonly IService<FoodClass> _service;
        private readonly IMapper _mapper;

        public FoodController(IService<FoodClass> service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        public void Add(FoodModel food)
        {
            _service.Add(_mapper.Map<FoodClass>(food));
        }

        public void Update(FoodModel food)
        {
            _service.Update(_mapper.Map<FoodClass>(food));
        }

        public void Remove(int id)
        {
            _service.Remove(id);
        }

        public FoodModel GetById(int id)
        {
            return _mapper.Map<FoodModel>(_service.GetById(id));
        }

        public List<FoodModel> GetAll()
        {
            return _mapper.Map<List<FoodModel>>(_service.GetAll());
        }

        public bool Save()
        {
            _service.Save();
            return true;
        }
    }
}
