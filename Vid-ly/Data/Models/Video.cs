using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vid_ly.Data.Models
{
    public class Video
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int ChannelId { get; set; }
        public virtual Channel Channel { get; set; }
        public int PlayListId { get; set; }
        public virtual PlayList PlayList { get; set; }
        public DateTime Uploaded { get; set; }

    }
}
