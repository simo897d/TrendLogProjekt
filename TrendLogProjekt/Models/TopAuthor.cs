using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TrendLogProjekt.Models
{
    public class TopAuthor
    {
        [Key]
        public int AuthorId { get; set; }

        public string Name { get; set; }
        public string Occupation { get; set; }
        public string Location { get; set; }
        public string Status { get; set; }
        public int Money { get; set; }
        public string ImageLocation { get; set; }
    }
}
