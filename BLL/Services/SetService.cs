using System.Collections.Generic;
using AutoMapper;
using DataBase;
using UoW;

namespace BLL
{
    public class SetService : IService<SetClass>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public SetService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public void Add(SetClass set)
        {
            _unitOfWork.Sets.Add(_mapper.Map<Set>(set));
        }

        public void Update(SetClass set)
        {
            _unitOfWork.Sets.Update(_mapper.Map<Set>(set));
        }

        public void Remove(int id)
        {
            _unitOfWork.Sets.Remove(id);
        }

        public SetClass GetById(int id)
        {
            return _mapper.Map<SetClass>(_unitOfWork.Sets.GetById(id));
        }

        public List<SetClass> GetAll()
        {
            return _mapper.Map<List<SetClass>>(_unitOfWork.Sets.GetAll());
        }
        public bool Save()
        {
            _unitOfWork.Save();
            return true;
        }
    }
}
