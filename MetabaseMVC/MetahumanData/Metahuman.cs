using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        public virtual Skill Skills { get; set; }
        [ForeignKey("SkillID")]
        public int SkillsID { get; set; }
        [Required]
        public virtual Species Species { get; set; }
        [ForeignKey("SpeciesID")]
        public int SpeciesID { get; set; }
        [Required]
        public string Bio { get; set; }
        public DateTimeOffset DateAdded { get; set; }
        public DateTimeOffset DateModified { get; set; }
    }
}