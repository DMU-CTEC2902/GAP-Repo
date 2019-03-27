using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FilmReviewWebsite.Models
{
    [Table("Movie")]
    public class Movie
    {
        [Key]
        public virtual int MovieID { get; set; }//added this
        public virtual int NoUserID { get; set; }
        public virtual float Rating { get; set; }
        public virtual string Discription { get; set; }
        public virtual string genreName { get; set; }
      
    }
}