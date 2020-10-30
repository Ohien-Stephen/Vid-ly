using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vid_ly.Data.Models
{
    public class PlayList
    {
        [Key]
        public int PlayListId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Video> Videos { get; set; }
        public int ChannelId { get; set; }
        public virtual Channel Channel { get; set; }
        public DateTime Created { get; set; }

    }
}
