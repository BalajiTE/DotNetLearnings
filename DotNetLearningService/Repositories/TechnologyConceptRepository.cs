using System.Linq;
using DotNetLearningModel.Entities;
using DotNetLearningService.Models;
using DotNetLearningService.Repositories.Interfaces;

namespace DotNetLearningService.Repositories
{
    public class TechnologyConceptRepository : BaseRepository<TechnologyConcept>, ITechnologyConceptRepository
    {
        private DotNetLearningContext context;

        public TechnologyConceptRepository(DotNetLearningContext context) : base(context) 
        {
            this.context = context;
        }

        public TechnologyConcept GetTechnologyConceptFor(int technologyConceptID)
        {
            var technologyConcept = (from techConcept in context.TechnologyConcept
                                  where techConcept.ID == technologyConceptID
                                  select techConcept).FirstOrDefault();

            return technologyConcept;
        }
    }
}