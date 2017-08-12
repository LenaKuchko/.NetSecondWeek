using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SeafoodMarket.ViewModels
{
    public class SignUpForNewsViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Enter your email")]
        public string Email { get; set; }

        [Display(Name = "Your favorite seafood")]
        public string Preference { get; set; }
    }
}
