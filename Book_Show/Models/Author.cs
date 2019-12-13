using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Book_Show.Models
{
    public class Author
    {
        public int Id { get; set; }

        [Required]
        [Display(Name ="Author")]
        public string AzthorName { get; set; }

        public ICollection<Book> Books{ get; set; }
    }
}