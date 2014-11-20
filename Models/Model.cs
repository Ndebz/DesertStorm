using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesertStorm.Models
{
    public class Model
    {
        public int ModelID { get; set; }
        public string ModelTitle { get; set; }

        public virtual Make Make { get; set; }
        public virtual Body Body { get; set; }
    }
}