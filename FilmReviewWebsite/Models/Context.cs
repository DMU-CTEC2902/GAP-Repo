using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FilmReviewWebsite.Models
{
    [Table("Context")]
    public class Context
    {
        [Key]
        public virtual int PostID { get; set; }//added this
        public virtual string Contexts { get; set; }
        public virtual DateTime ReleaseDate { get; set; }
        public virtual string MovieName { get; set; }
        public virtual int UserID { get; set; }
    }
}