using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mactor.DAL.Entites
{
    public class Post
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime DateTime { get; set; }
        public string BodayText { get; set; }
        public virtual User User { get; set; }
    }
}
