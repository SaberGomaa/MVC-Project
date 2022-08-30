using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Project.Models
{
    public class logindata
    {
        [RegularExpression("^[\\w-\\.]+@([\\w-]+\\.)+[\\w-]{2,4}$", ErrorMessage = "Invalid Email")]
        [Required(ErrorMessage = "*")]
        public string email { get; set; }

        [Required(ErrorMessage = "*")]
        public string password { get; set; }
    }
}