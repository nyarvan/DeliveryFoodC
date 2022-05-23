using System.Collections.Generic;
using AutoMapper;
using BLL;

namespace API
{
    public class SetController : IController<SetModel>
    {
        private readonly IService<SetClass> _service;
        private readonly IMapper _mapper;

        public SetController(IService<SetClass> service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        public void Add(SetModel set)
        {
            _service.Add(_mapper.Map<SetClass>(set));
        }

        public void Update(SetModel set)
        {
            _service.Update(_mapper.Map<SetClass>(set));
        }

        public void Remove(int id)
        {
            _service.Remove(id);
        }

        public SetModel GetById(int id)
        {
            return _mapper.Map<SetModel>(_service.GetById(id));
        }

        public List<SetModel> GetAll()
        {
            return _mapper.Map<List<SetModel>>(_service.GetAll());
        }

        public bool Save()
        {
            _service.Save();
            return true;
        }
    }
}
