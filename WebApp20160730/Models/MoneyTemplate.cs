using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApp20160730.Models
{
    public class MoneyTemplate
    {
        [Display(Name = "分類")]
        public string Category { get; set; }

        [Display(Name = "金額")]
        public string Money { get; set; }

        [Display(Name = "日期")]
        public string Date { get; set; }

        [Display(Name = "備註")]
        public string Description { get; set; }
    }
}