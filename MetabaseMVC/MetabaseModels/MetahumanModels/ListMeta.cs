using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MetabaseData.Skill;

namespace MetabaseModels.MetahumanModels
{
    public class ListMeta
    {
        public string Name { get; set; }
        public string SpeciesName { get; set; }
        public SkillType SkillOne { get; set; }
        public DateTimeOffset DateModified { get; set; }
    }
}
