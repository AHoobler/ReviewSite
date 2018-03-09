using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ReviewSite1.Models
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }

        public string Type { get; set; }

        //navigation property
        public virtual ICollection<Review> Reviews { get; set; }

    }
}