using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication6.Models
{
    [Table("language")]
    public class Language
    {
        [Key]
        [Column("language_id")]
        public int language_id { get; set; }

        public string name { get; set; }

        public DateTime last_update { get; set; }

        public virtual ICollection<Film> Films { get; set; }
    }
}