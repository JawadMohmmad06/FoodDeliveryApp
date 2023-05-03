using Finalv1BLL.ModelDTOs;
using Finalv1DAL;
using Finalv1DAL.Models;
using Finalv1DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finalv1BLL.Services
{
    public class UserService
    {
        public static List<UserDTO> Get()
        {
            var list1 = DataAccessFactory.UserData().Get();
            var list2 = new List<UserDTO>();
            var orders = new List<OrderDTO>();
            var chats=new List<ChatDto>();
            var feedbacks=new List<FeedBackDTO>();
            foreach (var item in list1)
            {
                foreach(var i2 in item.FeedBacks)
                {
                    feedbacks.Add(new FeedBackDTO()
                    {
                        Id = i2.Id,
                        UId = i2.UId,
                        Subject = i2.Subject,
                        Body = i2.Body,

                    });
                }
                foreach(var i in item.Chats)
                {
                    chats.Add(new ChatDto()
                    {
                        Id = i.Id,
                        Uid = i.Uid,
                        DId = i.DId,
                        Msg = i.Msg,
                    });
                }
                
                foreach(var item2 in item.Orders)
                {
                    orders.Add(new OrderDTO
                    {
                        Id = item2.Id,
                        Rid = item2.Rid,
                        Uid = item2.Uid,
                        Caddress = item2.Caddress,
                        Date = item2.Date,
                        Amount = item2.Amount,
                        RestaurantName = item2.RestaurantName,
                        OrderStatus = item2.OrderStatus,
                    });
                }
                list2.Add(new UserDTO()
                {
                    Id = item.Id,
                    Name = item.Name,
                    Username = item.Username,
                    DOB = item.DOB,
                    Email = item.Email,
                    Gender = item.Gender,
                    Password = item.Password,
                    Address = item.Address,
                    MobileNumber = item.MobileNumber,
                    OrderDTOs= orders,
                    ChatDtos=chats,
                    FeedBackDTOs=feedbacks
                    
                });
            }
            return list2;
        }

        public static UserDTO Get(int id)
        {
            var alluser = Get();

            var user = (from item in alluser
                        where item.Id == id
                        select item).SingleOrDefault();
            if (user != null)
            {
                return user;
            }
            return null;
        }

        public static bool Create(UserDTO userdto)
        {
            var user = new User();
            user.Id = userdto.Id;
            user.Name = userdto.Name;
            user.Username= userdto.Username;
            user.DOB = userdto.DOB;
            user.Email = userdto.Email;
            user.Gender = userdto.Gender;
            user.Password = userdto.Password;
            user.Address = userdto.Address;
            user.MobileNumber = userdto.MobileNumber;
            return DataAccessFactory.UserData().Create(user);

        }

        public static bool Update(UserDTO userdto) {
            var user = new User();
            user.Id = userdto.Id;
            user.Name = userdto.Name;
            user.Username = userdto.Username;
            user.DOB = userdto.DOB;
            user.Email = userdto.Email;
            user.Gender = userdto.Gender;
            user.Password = userdto.Password;
            user.Address = userdto.Address;
            user.MobileNumber = userdto.MobileNumber;
            return DataAccessFactory.UserData().Update(user);
        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.UserData().Delete(id); 
        }
        public static UserDTO SearchByUserName(String username)
        {
            var users = Get();
            var userbyname=(from i in users
                            where i.Username== username
                            select i).SingleOrDefault();
            return userbyname;
            
        }
        public static List<UserDTO> SearchByAdress(String adress)
        {
            var users = Get();
            var useradd = (from i in users
                              where i.Address == adress
                              select i).ToList();
            return useradd;

        }
    }
}
