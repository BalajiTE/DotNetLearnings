using DotNetLearningModel.Entities;

namespace DotNetLearningService.Repositories.Interfaces
{
    public interface ITechnologyLanguageRepository
    {
        TechnologyLanguage GetITechnologyLanguageFor(int technologyLanguageID);
    }
}
