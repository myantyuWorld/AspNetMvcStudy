using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication6.Models
{
    [Table("film")]
    public class Film
    {
        [Key]
        [Column("film_id")]
        public int id { get; set; }

        public string title { get; set; }

        public string description { get; set; }

        public int release_year { get; set; }

        public int rental_duration { get; set; }

        public int rental_rate { get; set; }

        public int length { get; set; }

        public int language_id { get; set; }

        public int replacement_cost { get; set; }

        public string rating { get; set; }

        public DateTime last_update { get; set; }

        public string special_features { get; set; }

        public string fulltext { get; set; }

        public virtual Language Language { get; set; }
    }
}