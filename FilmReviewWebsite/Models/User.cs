using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FilmReviewWebsite.Models
{
    [Table("User")]
    public class User
    {
        [Key]
        public virtual int  UserID { get; set; }//added this
        public virtual string UserName { get; set; }
        public virtual string UserEmail { get; set; }
        public virtual string UserPassword { get; set; }

    }
}