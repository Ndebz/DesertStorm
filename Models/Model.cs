using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DesertStorm.Models
{
    public class Model
    {
        public int ModelID { get; set; }
        [Required]
        public string ModelTitle { get; set; }

        [ForeignKey("Make")]
        [Required]
        public int MakeID { get; set; }

        public virtual Make Make { get; set; }
        public virtual Body Body { get; set; }
    }
}