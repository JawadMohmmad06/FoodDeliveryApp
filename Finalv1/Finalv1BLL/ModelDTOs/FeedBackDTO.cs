using Finalv1DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finalv1BLL.ModelDTOs
{
    public  class FeedBackDTO
    {
        public int Id { get; set; }
       
        public int UId { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public virtual UserDTO UserDTO { get; set; }
    }
}
