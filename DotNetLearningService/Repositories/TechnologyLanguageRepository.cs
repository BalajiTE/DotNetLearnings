using System.Linq;
using DotNetLearningModel.Entities;
using DotNetLearningService.Models;
using DotNetLearningService.Repositories.Interfaces;

namespace DotNetLearningService.Repositories
{
    public class TechnologyLanguageRepository : BaseRepository<TechnologyLanguage>, ITechnologyLanguageRepository
    {
        private DotNetLearningContext context;
        public TechnologyLanguageRepository(DotNetLearningContext context) : base(context) 
        {
            this.context = context;
        }

        public TechnologyLanguage GetITechnologyLanguageFor(int technologyLanguageID)
        {
            var technologyLanguage = (from techType in context.TechnologyLanguage
                                      where techType.ID == technologyLanguageID
                                      select techType).FirstOrDefault();

            return technologyLanguage;
        }
    }
}