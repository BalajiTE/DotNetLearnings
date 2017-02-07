using DotNetLearningModel.Entities;

namespace DotNetLearningService.Repositories.Interfaces
{
    public interface ITechnologyConceptRepository
    {
        TechnologyConcept GetTechnologyConceptFor(int TechnologyConceptID);
    }
}
