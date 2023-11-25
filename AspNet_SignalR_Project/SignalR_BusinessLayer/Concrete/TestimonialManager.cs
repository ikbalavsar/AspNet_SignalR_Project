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
    public class TestimonialManager : ITestimonialService
    {
        private readonly ITestimonialDal _testimonialDal;

        public TestimonialManager(ITestimonialDal testimonialDal)
        {
            _testimonialDal = testimonialDal;
        }

        public void TAdd(Testimonial entity)
        {
            _testimonialDal.Add(entity);    
        }

        public void TDelete(Testimonial entity)
        {
           _testimonialDal.Delete(entity);
        }

        public Testimonial TGetByID(int id)
        {
          return _testimonialDal.GetByID(id);
        }

        public List<Testimonial> TGetListAll()
        {
          return _testimonialDal.GetListAll();
        }

        public void TUpdate(Testimonial entity)
        {
          _testimonialDal.Update(entity);
        }
    }
}
