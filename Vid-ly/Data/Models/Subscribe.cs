using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vid_ly.Data.Models
{
    public class Subscribe
    {
        [Key]
        public Guid SubscribeId { get; set; }
        public int ChannelId { get; set; }
        public virtual Channel Channel { get; set; }
        public Guid ApplicationUserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
        public DateTime Created { get; set; }
    }
}
