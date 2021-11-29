using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MetabaseData
{
    public class Metahuman
    {
        [Key]
        public int MetaID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int SkillsID { get; set; }
        [Required]
        public int SpeciesID { get; set; }
        [Required]
        public string Bio { get; set; }
        public DateTimeOffset DateAdded { get; set; }
        public DateTimeOffset DateModified { get; set; }
    }
}