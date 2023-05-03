using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finalv1DAL.Models
{
    public class FeedBack
    {
        public int Id { get; set; }
        [ForeignKey("User")]
        public int UId { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public virtual User User { get; set; }
    }
}
