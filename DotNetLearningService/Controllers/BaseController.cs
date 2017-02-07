using DotNetLearningModel.Entities;
using DotNetLearningService.Repositories.Interfaces;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;

namespace DotNetLearningService.Controllers
{
    public abstract class BaseController<T> : ApiController
        where T : EntityBase, new()
    {
        #region Private Variables

        private IBaseRepository<T> baseRepository;

        #endregion

        protected BaseController(IBaseRepository<T> context)
        {
            this.baseRepository = context;
        }

        [System.Web.Http.HttpGet]
        public IEnumerable<T> All()
        {
            return baseRepository.All();
        }

        [System.Web.Http.HttpPost]
        public async Task<object> Create(T entity)
        {
            if (ModelState.IsValid)
            {
                baseRepository.Create(entity);

                var retVal = await baseRepository.Save();

                return entity;
            }
            else
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
            //return null;
        }

        [System.Web.Http.HttpPut]
        public async Task<int> Update(T entity)
        {
            if (ModelState.IsValid)
            {
                baseRepository.Update(entity);

                await baseRepository.Save();

                return entity.ID;
            }

            return 0;
        }
    }
}
