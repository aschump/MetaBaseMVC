using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MetabaseMVC.Models
{
    public class Metahuman
    {
        [Key]
        public int MetaID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [ForeignKey(nameof(Skill))]
        public int SkillsID { get; set; }
        [Required]
        [ForeignKey(nameof(Species))]
        public int SpeciesID { get; set; }
        [Required]
        public string Bio { get; set; }
    }
}