using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vid_ly.Data.Models
{
    public class Like
    {
        [Key]
        public Guid LikeId { get; set; }
        public Guid VideoId { get; set; }
        public virtual Video Video { get; set; }
        public Status status { get; set; }
    }
    public enum Status
    {
        none,
        like,
        unlike
    }
}
