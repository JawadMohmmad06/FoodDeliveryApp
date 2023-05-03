using Finalv1BLL.ModelDTOs;
using Finalv1DAL;
using Finalv1DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finalv1BLL.Services
{
    public class RestaurantService
    {
        public static List<RestaurantDTO> Get()
        {
            var list1 = DataAccessFactory.RestaurantData().Get();
            var list2 = new List<RestaurantDTO>();
            foreach(var item in list1)
            {
                list2.Add(new RestaurantDTO()
                {
                    Id = item.Id,
                    Name = item.Name,
                    Location = item.Location,
                    Status = item.Status,
                    Rating = item.Rating,
                    Discount = item.Discount,
                });
            }
            return list2;
        }

        public static RestaurantDTO Get(int id) {
            var allres = Get();
            var res = (from item in allres
                       where item.Id == id
                       select item).SingleOrDefault();
            return res;
        }

        public static bool Create(RestaurantDTO restaurantdto) {
            var restaurant = new Restaurant();
            restaurant.Id = restaurantdto.Id;
            restaurant.Name= restaurantdto.Name;
            restaurant.Location= restaurantdto.Location;
            restaurant.Status = restaurantdto.Status;
            restaurant.Rating= restaurantdto.Rating;
            restaurant.Discount = restaurantdto.Discount;
            return DataAccessFactory.RestaurantData().Create(restaurant);
        }

        public static bool Update(RestaurantDTO restaurantdto)
        {
            var restaurant = new Restaurant();
            restaurant.Id = restaurantdto.Id;
            restaurant.Name = restaurantdto.Name;
            restaurant.Location = restaurantdto.Location;
            restaurant.Status = restaurantdto.Status;
            restaurant.Rating = restaurantdto.Rating;
            restaurant.Discount = restaurantdto.Discount;
            return DataAccessFactory.RestaurantData().Update(restaurant);
        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.RestaurantData().Delete(id);
        }
    }
}
