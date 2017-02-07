using DotNetLearningModel.Entities;
using System.Collections.Generic;

namespace DotNetLearningService.Repositories.Interfaces
{
    public interface ITechnologyTypeRepository
    {
        TechnologyType GetTechnologyTypeFor(int TechnologyTypeID);
    }
}
