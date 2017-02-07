using DotNetLearningModel.Entities;
using DotNetLearningService.Repositories.Interfaces;
using System.Web.Http;

namespace DotNetLearningService.Controllers
{
    [RoutePrefix("api/TechnologyLanguage")]
    public class TechnologyLanguageController : BaseController<TechnologyLanguage>
    {
        private ITechnologyLanguageRepository _technologyLanguageRepository;
        public TechnologyLanguageController(IBaseRepository<TechnologyLanguage> baseRepository, ITechnologyLanguageRepository technologyLanguageRepository) 
            : base(baseRepository)
        {
            _technologyLanguageRepository = technologyLanguageRepository;
        }
        
        [HttpGet, Route("{technologyLanguageID:int}")]
        public TechnologyLanguage GetITechnologyLanguageFor(int technologyLanguageID)
        {
            return _technologyLanguageRepository.GetITechnologyLanguageFor(technologyLanguageID);
        }
    }
}
