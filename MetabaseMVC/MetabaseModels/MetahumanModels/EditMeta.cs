using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MetabaseData.Skill;

namespace MetabaseModels.MetahumanModels
{
    public class EditMeta
    {
        public string Name { get; set; }
        public string SpeciesName { get; set; }
        public SkillType SkillOne { get; set; }
        public SkillType SkillTwo { get; set; }
        public SkillType SkillThree { get; set; }
        public string Bio { get; set; }
        public DateTimeOffset DateModified { get; set; }

    }
}
