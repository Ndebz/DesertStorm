using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DesertStorm.Models
{
    public class Make
    {
        public int MakeID { get; set; }
        [Required]
        public string MakeTitle { get; set; }

        public virtual ICollection<Model> Models { get; set; }
    }
}