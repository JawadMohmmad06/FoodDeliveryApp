using Finalv1BLL.ModelDTOs;
using Finalv1DAL;
using Finalv1DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Finalv1BLL.Services
{
    public class OrderService
    {
        public static List<OrderDTO> Get()
        {
            var list1 = DataAccessFactory.OrderData().Get();
            var list2 = new List<OrderDTO>();
            foreach (var item in list1)
            {
                list2.Add(new OrderDTO()
                {
                    Id = item.Id,
                    Rid = item.Rid,
                    Uid = item.Uid,
                    RestaurantName = item.RestaurantName,
                    Caddress = item.Caddress,
                    Date = item.Date,
                    OrderStatus = item.OrderStatus,
                    Amount = item.Amount,

                }); ;
            }
            return list2;
        }

        public static OrderDTO Get(int id)
        {
            var allord = Get();
            if (allord != null)
            {
                var ord = (from item in allord
                           where item.Id == id
                           select item).SingleOrDefault();
                return ord;
            }
        return null;
        }

        public static bool Create(OrderDTO orderdto)
        {
            var order = new Order();
            order.Id= orderdto.Id;
            order.Rid = orderdto.Rid;   
            order.Uid= orderdto.Uid;  
            order.RestaurantName= orderdto.RestaurantName;
            order.Caddress= orderdto.Caddress;
            order.Date= orderdto.Date;
            order.OrderStatus = orderdto.OrderStatus;
            order.Amount= orderdto.Amount;
            

            return DataAccessFactory.OrderData().Create(order);
        }

        public static bool Update(OrderDTO orderdto)
        {
            var order = new Order();
            order.Id = orderdto.Id;
            order.Rid = orderdto.Rid;
            order.Uid = orderdto.Uid;
            order.RestaurantName = orderdto.RestaurantName;
            order.Caddress = orderdto.Caddress;
            order.Date = orderdto.Date;
            order.OrderStatus = orderdto.OrderStatus;
            order.Amount = orderdto.Amount;
          

            return DataAccessFactory.OrderData().Update(order);
        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.OrderData().Delete(id);
        }

    }
}
