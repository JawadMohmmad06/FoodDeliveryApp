using Finalv1DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finalv1BLL.ModelDTOs
{
    public class DeliverymanTypeDTO
    {
        public int ID { get; set; }
        public string Type { get; set; }

        public virtual ICollection<DeliverymanDTO> DeliverymensDTO { get; set; }
        public DeliverymanTypeDTO()
        {
            DeliverymensDTO = new List<DeliverymanDTO>();
        }
    }
}
