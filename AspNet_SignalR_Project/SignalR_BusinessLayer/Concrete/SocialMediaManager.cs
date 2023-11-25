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
    public class SocialMediaManager : ISocialMediaService
    {
        private readonly ISocialMediaDal _socialMediaDal;

        public SocialMediaManager(ISocialMediaDal socialMediaDal)
        {
            _socialMediaDal = socialMediaDal;
        }

        public void TAdd(SocialMedia entity)
        {
           _socialMediaDal.Add(entity);
        }

        public void TDelete(SocialMedia entity)
        {
           _socialMediaDal.Delete(entity);
        }

        public SocialMedia TGetByID(int id)
        {
          return _socialMediaDal.GetByID(id);
        }

        public List<SocialMedia> TGetListAll()
        {
           return _socialMediaDal.GetListAll();
        }

        public void TUpdate(SocialMedia entity)
        {
           _socialMediaDal.Update(entity);
        }
    }
}
