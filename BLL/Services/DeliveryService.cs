using System.Collections.Generic;
using AutoMapper;
using DataBase;
using UoW;

namespace BLL
{
    public class DeliveryService : IService<DeliveryClass>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public DeliveryService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public void Add(DeliveryClass delivery)
        {
            _unitOfWork.Deliveries.Add(_mapper.Map<Delivery>(delivery));
        }

        public void Update(DeliveryClass delivery)
        {
            _unitOfWork.Deliveries.Update(_mapper.Map<Delivery>(delivery));
        }

        public void Remove(int id)
        {
            _unitOfWork.Deliveries.Remove(id);
        }

        public DeliveryClass GetById(int id)
        {
            return _mapper.Map<DeliveryClass>(_unitOfWork.Deliveries.GetById(id));
        }

        public List<DeliveryClass> GetAll()
        {
            return _mapper.Map<List<DeliveryClass>>(_unitOfWork.Deliveries.GetAll());
        }
        public bool Save()
        {
            _unitOfWork.Save();
            return true;
        }
    }
}
