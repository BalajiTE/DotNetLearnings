using DotNetLearningModel.Entities;
using DotNetLearningService.Repositories.Interfaces;
using System.Web.Http;

namespace DotNetLearningService.Controllers
{
    [RoutePrefix("api/TechnologyType")]
    public class TechnologyTypeController : BaseController<TechnologyType>
    {
        private ITechnologyTypeRepository _technologyRepository;
        public TechnologyTypeController(IBaseRepository<TechnologyType> baseRepository, ITechnologyTypeRepository technologyTypeRepository) 
            : base(baseRepository)
        {
            _technologyRepository = technologyTypeRepository;
        }

        [HttpGet, Route("{techonologyTypeID:int}")]
        public TechnologyType GetTechnologyTypeFor(int techonologyTypeID)
        {
            return _technologyRepository.GetTechnologyTypeFor(techonologyTypeID);
        }
    }
}
