﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Directory.Web.ViewModels
{
    public class ProvinceViewModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Code { get; set; }
    }
}