using Finalv1DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finalv1BLL.ModelDTOs
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }

        public DateTime DOB { get; set; }

        public string Email { get; set; }

        public string Gender { get; set; }

        public string Password { get; set; }

        public string Address { get; set; }

        public string MobileNumber { get; set; }

        public virtual ICollection<OrderDTO> OrderDTOs { get; set; }
        public virtual ICollection<ChatDto> ChatDtos { get; set; }
        public virtual ICollection<FeedBackDTO> FeedBackDTOs { get; set; }

        public UserDTO()
        {
            OrderDTOs = new List<OrderDTO>();
            ChatDtos= new List<ChatDto>();
            FeedBackDTOs= new List<FeedBackDTO>();
        }
    }
}
