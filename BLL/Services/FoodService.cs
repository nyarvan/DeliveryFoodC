using System.Collections.Generic;
using AutoMapper;
using DataBase;
using UoW;

namespace BLL
{
    public class FoodService : IService<FoodClass>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public FoodService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public void Add(FoodClass food)
        {
            _unitOfWork.Foods.Add(_mapper.Map<Food>(food));
        }

        public void Update(FoodClass food)
        {
            _unitOfWork.Foods.Update(_mapper.Map<Food>(food));
        }

        public void Remove(int id)
        {
            _unitOfWork.Foods.Remove(id);
        }

        public FoodClass GetById(int id)
        {
            return _mapper.Map<FoodClass>(_unitOfWork.Foods.GetById(id));
        }

        public List<FoodClass> GetAll()
        {
            return _mapper.Map<List<FoodClass>>(_unitOfWork.Foods.GetAll());
        }
        public bool Save()
        {
            _unitOfWork.Save();
            return true;
        }
    }
}
