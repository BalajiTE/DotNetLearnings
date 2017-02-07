using DotNetLearningModel.Entities;
using DotNetLearningService.Repositories.Interfaces;
using System.Web.Http;

namespace DotNetLearningService.Controllers
{
    [RoutePrefix("api/TechnologyConcept")]
    public class TechnologyConceptController : BaseController<TechnologyConcept>
    {
        private ITechnologyConceptRepository _technologyConceptRepository;

        public TechnologyConceptController(IBaseRepository<TechnologyConcept> baseRepository, ITechnologyConceptRepository technologyConceptRepository) 
            : base(baseRepository)
        {
            _technologyConceptRepository = technologyConceptRepository;
        }

        [HttpGet, Route("{technologyConceptID:int}")]
        public TechnologyConcept GetTechnologyConceptFor(int technologyConceptID)
        {
            return _technologyConceptRepository.GetTechnologyConceptFor(technologyConceptID);
        }
    }
}
