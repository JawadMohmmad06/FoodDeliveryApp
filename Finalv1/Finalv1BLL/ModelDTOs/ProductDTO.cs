using Finalv1DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finalv1BLL.ModelDTOs
{
    public class ProductDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Price { get; set; }

        public int Quantity { get; set; }
        [ForeignKey("RestaurantDTO")]
        public int Rid { get; set; }

        [ForeignKey("CuisineDTO")]
        public int Cid { get; set; }


        public RestaurantDTO RestaurantDTO { get; set; }

        public CuisineDTO CuisineDTO { get; set; }

        public virtual ICollection<OrderDetailsDTO> OrderDetailsDTOs { get; set; }

        public ProductDTO()
        {
            OrderDetailsDTOs = new List<OrderDetailsDTO>();
        }
    }
}
