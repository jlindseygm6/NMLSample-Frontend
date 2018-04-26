using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NMLSample.Models
{
    public class Beer
    {

        public int Id { get; set; }
        [Display(Name ="Name")]
        public string name { get; set; }
        [Display(Name = "Tagline")]
        public string tagline { get; set; }
        [Display(Name = "Description")]
        public string description { get; set; }
        [Display(Name = "First Brew")]
        public string first_brewed { get; set; }
        [Display(Name = "Contributed By")]
        public string contributed_by { get; set; }
        [Display(Name = "Product Image")]
        public string image_url { get; set; }
    }
}