using Finalv1DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finalv1BLL.ModelDTOs
{
    public class RestaurantDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }

        public string Status { get; set; }

        public int Rating { get; set; }

        public int Discount { get; set; }

        public virtual ICollection<ProductDTO> ProductDTOs { get; set; }
        public virtual ICollection<OrderDTO> OrderDTOs { get; set; }

        public RestaurantDTO()
        {
            ProductDTOs = new List<ProductDTO>();
            OrderDTOs = new List<OrderDTO>();
        }
    }
}
