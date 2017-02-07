using DotNetLearningModel.Entities;

namespace DotNetLearningService.Repositories.Interfaces
{
    public interface ILanguageConceptRepository
    {
        LanguageConcept GetLanguageConceptFor(int languageConceptID);
    }
}
