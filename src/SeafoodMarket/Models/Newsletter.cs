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
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public virtual ICollection<Visitor> Visitors { get; set; }

        public Newsletter()
        {

        }
    }
}
