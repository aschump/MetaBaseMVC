using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MetabaseMVC.Models
{
    public class Skill
    {
        public enum SkillType
        {
            Invisibility,
            Flying,
            Electricity,
            [Description("Super Strength")]
            SuperStrength,
            Telekinesis,
            [Description("Mind Manipulation")]
            MindManipulation,
            [Description("Element Related")]
            ElementRelated
        }
        [Key]
        public int SkillsID { get; set; }
        public SkillType SkillOne { get; set; }
    }
}