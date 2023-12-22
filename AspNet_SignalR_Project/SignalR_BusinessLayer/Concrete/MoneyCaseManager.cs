using SignalR_BusinessLayer.Abstract;
using SignalR_DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR_BusinessLayer.Concrete
{
    public class MoneyCaseManager : IMoneyCaseService
    {
        private readonly IMoneyCaseDal _moneyCaseDal;

        public MoneyCaseManager(IMoneyCaseDal moneyCaseDal)
        {
            _moneyCaseDal = moneyCaseDal;
        }

        public void TAdd(IMoneyCaseService entity)
        {
            throw new NotImplementedException();
        }

        public void TDelete(IMoneyCaseService entity)
        {
            throw new NotImplementedException();
        }

        public IMoneyCaseService TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<IMoneyCaseService> TGetListAll()
        {
            throw new NotImplementedException();
        }

        public decimal TTotalMoneyCaseAmount()
        {
            return _moneyCaseDal.TotalMoneyCaseAmount();
        }

        public void TUpdate(IMoneyCaseService entity)
        {
            throw new NotImplementedException();
        }
    }
}
