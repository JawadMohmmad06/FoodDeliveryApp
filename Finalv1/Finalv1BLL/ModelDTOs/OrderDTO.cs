using Finalv1DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finalv1BLL.ModelDTOs
{
    public class OrderDTO
    {

        public int Id { get; set; }
        [ForeignKey("RestaurantDTO")]
        public int Rid { get; set; }
        [ForeignKey("UserDTO")]
        public int Uid { get; set; }

        public string RestaurantName { get; set; }

        public string Caddress { get; set; }

        public DateTime Date { get; set; }

        public string OrderStatus { get; set; }

        public int Amount { get; set; }

        public RestaurantDTO RestaurantDTO { get; set; }
        public UserDTO UserDTO { get; set; }


        public virtual ICollection<OrderDetailsDTO> OrderDetailsDTOs { get; set; }

        public OrderDTO()
        {
            OrderDetailsDTOs = new List<OrderDetailsDTO>();

        }
    }
}
