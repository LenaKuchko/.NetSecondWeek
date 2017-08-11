using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SeafoodMarket.Models
{
    [Table("Visitors")]
    public class Visitor
    {
        [Key]
        public string Id { get; set; }
        public string Email { get; set; }
        public string Preference { get; set; }
        public string NewsLetterId { get; set; }

        public Visitor(string email, string preference)
        {
            Email = email;
            Preference = preference;
        }
    }
}
