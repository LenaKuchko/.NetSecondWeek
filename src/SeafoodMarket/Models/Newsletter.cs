using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SeafoodMarket.Models
{
    [Table("Newsletters")]
    public class Newsletter
    {
        public Newsletter(string email, string preference)
        {
            Email = email;
            Preference = preference;
        }
        public Newsletter()
        {

        }

        [Key]
        public int Id { get; set; }
        public string Email { get; set; }
        public string Preference { get; set; }
    }
}
