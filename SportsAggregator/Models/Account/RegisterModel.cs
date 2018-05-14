using SportsAggregator.Models.DataModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SportsAggregator.Models.Account
{
    public class RegisterModel
    {
        [Required]
        public LOGIN_PROFILE LOGIN_PROFILES { get; set; } 

        [Required]
        public USER USERS { get; set; }

        [Required]
        public string COUNTRY { get; set; }

        [Required]
        public string[] SPORTS { get; set; }
    }
}