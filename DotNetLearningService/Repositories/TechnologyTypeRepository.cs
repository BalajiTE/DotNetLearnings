using System.Linq;
using DotNetLearningModel.Entities;
using DotNetLearningService.Models;
using DotNetLearningService.Repositories.Interfaces;

namespace DotNetLearningService.Repositories
{
    public class TechnologyTypeRepository : BaseRepository<TechnologyType>, ITechnologyTypeRepository
    {
        private DotNetLearningContext context;
        public TechnologyTypeRepository(DotNetLearningContext context) : base(context) 
        {
            this.context = context;
        }

        public TechnologyType GetTechnologyTypeFor(int TechnologyTypeID)
        {
            var technologyType = (from techType in context.TechnologyType
                                  where techType.ID == TechnologyTypeID
                                  select techType).FirstOrDefault();

            return technologyType;
        }
    }
}