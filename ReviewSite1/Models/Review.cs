using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ReviewSite1.Models
{
    public class Review
    {
        [Key]
        public int ReviewID { get; set; }

        [Display(Name = "What are you reveiwing?")]
        public string Title { get; set; }

        [Display(Name = "What is your name?")]
        public string Name { get; set; }

        [Display(Name = "Date of Review")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTime ReviewDate { get; set; }

        [Display(Name = "What is your review?")]
        public string ReviewContent { get; set; }

        [Display(Name = "Would you recommend this desintation?")]
        public bool WouldRecommend { get; set; }

        public int Rating { get; set; }

        [ForeignKey("Category")] //foreign key
        public int CategoryID { get; set; } //navigation property
        public virtual Category Category { get; set; }
    }
}