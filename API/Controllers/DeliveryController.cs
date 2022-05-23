using System.Collections.Generic;
using AutoMapper;
using BLL;

namespace API
{
    public class DeliveryController : IController<DeliveryModel>
    {
        private readonly IService<DeliveryClass> _service;
        private readonly IMapper _mapper;

        public DeliveryController(IService<DeliveryClass> service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public void Add(DeliveryModel delivery)
        {
            _service.Add(_mapper.Map<DeliveryClass>(delivery));
        }

        public void Update(DeliveryModel delivery)
        {
            _service.Update(_mapper.Map<DeliveryClass>(delivery));
        }

        public void Remove(int id)
        {
            _service.Remove(id);
        }

        public DeliveryModel GetById(int id)
        {
            return _mapper.Map<DeliveryModel>(_service.GetById(id));
        }

        public List<DeliveryModel> GetAll()
        {
            return _mapper.Map<List<DeliveryModel>>(_service.GetAll());
        }

        public bool Save()
        {
            _service.Save();
            return true;
        }
    }
}
