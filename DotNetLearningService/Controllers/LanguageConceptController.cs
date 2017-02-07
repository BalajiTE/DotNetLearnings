using DotNetLearningModel.Entities;
using DotNetLearningService.Repositories.Interfaces;
using System.Web.Http;

namespace DotNetLearningService.Controllers
{
    [RoutePrefix("api/LanguageConcept")]
    public class LanguageConceptController : BaseController<LanguageConcept>
    {
        private ILanguageConceptRepository _languageConceptRepository;
        public LanguageConceptController(IBaseRepository<LanguageConcept> baseRepository, ILanguageConceptRepository languageConceptRepository) 
            : base(baseRepository)
        {
            _languageConceptRepository = languageConceptRepository;
        }
        
        [HttpGet, Route("{languageConceptID:int}")]
        public LanguageConcept GetLanguageConceptFor(int languageConceptID)
        {
            return _languageConceptRepository.GetLanguageConceptFor(languageConceptID);
        }
    }
}
