using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication6.Models
{
    public class FilmLanguage
    {
        public Language language { get; set; }
        public List<Film> films { get; set; }
    }
}