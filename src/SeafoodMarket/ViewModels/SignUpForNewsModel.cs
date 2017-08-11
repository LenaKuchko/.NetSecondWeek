using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SeafoodMarket.ViewModels
{
    public class SignUpForNewsModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Your favorite kind of seafood")]
        public string Preference { get; set; }
    }
}
