using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace SportsAggregator.Models.Account
{
    public class LoginModel
    {
        [Required]
        public string USERNAME { get; set; }

        [Required]
        public string PASSWORD { get; set; }
    }
}