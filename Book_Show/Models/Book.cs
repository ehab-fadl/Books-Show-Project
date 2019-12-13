using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Book_Show.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required]
        [Display(Name ="Book Name")]
        public string BookName { get; set; }
        [Required]
        [Display(Name ="Pages Number")]
        public int PagesNamber { get; set; }
        [Required]
        [Display(Name ="ISBN")]
        public string ISBAN { get; set; }
        [Required]
        [Display(Name ="Author")]
        public int AuthorId { get; set; }

        public Author Author{ get; set; }
    }   
}