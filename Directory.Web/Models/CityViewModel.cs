using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Directory.Web.Models
{
    public class CityViewModel
    {
        public long Id { get; set; }
        [Display(Name = "Province")]
        public long ProvinceId { get; set; }
        public string Name { get; set; }
    }
}