using MetabaseData;
using MetabaseModels.MetahumanModels;
using MetabaseMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetabaseServices
{
    public class MetahumanService
    {
        //CREATE
        public bool CreateMetahuman(CreateMeta metamodel)
        {
            using (var ctx = new ApplicationDbContext())
            {
                Species species = new Species()
                {
                    Name = metamodel.SpeciesName,
                };
                ctx.Species.Add(species);

                Skill skill = new Skill()
                {
                    SkillOne = metamodel.SkillOne,
                    SkillTwo = metamodel.SkillTwo,
                    SkillThree = metamodel.SkillThree
                };
                ctx.Skills.Add(skill);

                Metahuman metahuman = new Metahuman()
                {
                    Name = metamodel.Name,
                    DateAdded = DateTimeOffset.Now
                };
                ctx.Metahumans.Add(metahuman);
                return ctx.SaveChanges() == 1;
                    }
        }
        //READ: Get all 
        public IEnumerable<ListMeta> GetAllMetahumans()
        {

        }
        //READ: Get By keyword
        //public IEnumerable<ListMeta> GetMetahumanByKeyword(string keyword)
        //{

        //}

        //UPDATE

        //DELETE
    }
}
