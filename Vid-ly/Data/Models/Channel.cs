using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vid_ly.Data.Models
{
    public class Channel 
    {
        [Key]
        public int ChannelId { get; set; }
        public string Name { get; set; }
        public string logo { get; set; }
        public string DisplayImage { get; set; }
        public string About { get; set; }
        public virtual ICollection<Video> Videos { get; set; }
        public virtual ICollection<PlayList> PlayLists { get; set; }
        public Guid ApplicationUserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
        public DateTime Created { get; set; }

    }
}
