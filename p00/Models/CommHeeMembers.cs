﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace p00.Models
{
    public class CommHeeMembers
    {
        public int Id { get; set; }

        public string Role { get; set; }

        [System.ComponentModel.DisplayName(" االلجنة")]
        public int CommitHeesid { get; set; }
        [DisplayName(" االلجنة")]
        public CommitHees CommitHees { get; set; }
        public int Teacherid { get; set; }
        [Display(Name = "اسم الاستاذ")]
        public Teacher Teacher { get; set; }

    }
}