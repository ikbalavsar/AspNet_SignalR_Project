using SignalR_BusinessLayer.Abstract;
using SignalR_DataAccessLayer.Abstract;
using SignalR_EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR_BusinessLayer.Concrete
{
    public class SliderManager : ISliderService
    {
        private readonly ISliderDal _sliderDal;

        public SliderManager(ISliderDal sliderDal)
        {
            _sliderDal = sliderDal;
        }

        public void TAdd(Slider entity)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Slider entity)
        {
            throw new NotImplementedException();
        }

        public Slider TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Slider> TGetListAll()
        {
           return _sliderDal.GetListAll();
        }

        public void TUpdate(Slider entity)
        {
            throw new NotImplementedException();
        }
    }
}
