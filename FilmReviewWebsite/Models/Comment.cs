using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FilmReviewWebsite.Models
{
    [Table("Comment")]
    public class Comment
    {
        [Key]
        public virtual int CommentID { get; set; }
        public virtual int PostID { get; set; }
        public virtual int PersonID { get; set; }
        public virtual string Content { get; set; }
       

    }
}