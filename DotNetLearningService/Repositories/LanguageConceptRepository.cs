using System;
using System.Linq;
using DotNetLearningModel.Entities;
using DotNetLearningService.Models;
using DotNetLearningService.Repositories.Interfaces;

namespace DotNetLearningService.Repositories
{
    public class LanguageConceptRepository : BaseRepository<LanguageConcept>, ILanguageConceptRepository
    {
        private DotNetLearningContext context;
        public LanguageConceptRepository(DotNetLearningContext context) : base(context) 
        {
            this.context = context;
        }

        public LanguageConcept GetLanguageConceptFor(int languageConceptID)
        {
            var languageConcept = (from langConcept in context.LanguageConcept
                                   where langConcept.ID == languageConceptID
                                   select langConcept).FirstOrDefault();

            return languageConcept;
        }
    }
}