﻿
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace p00.Models
{
    public class Sections
    {    [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name ="اسم المحور")]
        public string SectionName { get; set; }
        [Required]
        [Display(Name = "وصف المحور")]
        public string Description { get; set; }
        [Required]
        [Display(Name = "وزن المحور")]
        public int TotalPoints { get; set; }
        //public ICollection<Topics> Topics { get; set; }
        public ICollection<SectionstoTopics> SectionstoTopics { get; set; }
        public ICollection<EvaluaationFormtoSections> EvaluaationFormtoSections { get; set; }
        public virtual ICollection<TopicEV> TopicEVs { get; set; }


    }
}