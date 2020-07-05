using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace p00.Models
{
    public class CheckedTeachersViewModel
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "الأسم الكامل")]
        public string FullName { get; set; }
        [Display(Name = "الجامعة")]
        public string University { get; set; }
        [Display(Name = "الكلية")]
        public string College { get; set; }
        [Display(Name = "القسم")]
        public string Department { get; set; }
        [Display(Name = "اللقب العلمي")]
        public string ScientificTitle { get; set; }
        public bool Check { get; set; }
    }
}