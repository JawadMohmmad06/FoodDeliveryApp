using Finalv1DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finalv1BLL.ModelDTOs
{
    public class ChatDto
    {
        public int Id { get; set; }
       
        public int Uid { get; set; }
       
        public int DId { get; set; }
        public String Msg { get; set; }
        public virtual UserDTO UserDTO{ get; set; }
        public virtual DeliverymanDTO DeliverymanDTO{ get; set; }
    }
}
