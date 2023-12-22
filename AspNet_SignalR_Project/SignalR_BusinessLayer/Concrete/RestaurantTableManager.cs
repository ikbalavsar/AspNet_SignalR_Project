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
    public class RestaurantTableManager : IRestaurantTableService
    {
        private readonly IRestaurantTableDal _restaurantTableDal;

        public RestaurantTableManager(IRestaurantTableDal restaurantTableDal)
        {
            _restaurantTableDal = restaurantTableDal;
        }

        public void TAdd(RestaurantTable entity)
        {
            throw new NotImplementedException();
        }

        public void TDelete(RestaurantTable entity)
        {
            throw new NotImplementedException();
        }

        public RestaurantTable TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<RestaurantTable> TGetListAll()
        {
            throw new NotImplementedException();
        }

        public int TTableCount()
        {
            return _restaurantTableDal.TableCount();
        }

        public void TUpdate(RestaurantTable entity)
        {
            throw new NotImplementedException();
        }
    }
}
