using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FilmReviewWebsite.Models
{
    [Table("Person")]
    public class Person
    {
        [Key]
        public virtual DateTime DOB { get; set; }
        public virtual int PersonID { get; set; }
        public virtual string PersonName { get; set; }
        public virtual string PersonLastName { get; set; }
        public virtual List<Movie> MovieList { get; set; }
        public virtual List<Comment> CommentList { get; set; }

    }
}