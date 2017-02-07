using DotNetLearningModel;
using DotNetLearningModel.Entities;
using DotNetLearningService.Controllers;
using DotNetLearningService.Helpers;
using DotNetLearningService.Repositories.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Web.Http;

namespace DotNetLearningService.Tests
{
    [TestClass]
    public class TechnologyTypeTests
    {
        [TestMethod]
        public void RequiredTechnologyTypeNameOnCreation()
        {
            Mock<IBaseRepository<TechnologyType>> baseRepository = new Mock<IBaseRepository<TechnologyType>>();
            Mock<ITechnologyTypeRepository> technologyTypeRepository = new Mock<ITechnologyTypeRepository>();

            TechnologyTypeController controller = new TechnologyTypeController(baseRepository.Object, technologyTypeRepository.Object);

            TechnologyType technologyType = new TechnologyType
            {
                Description = "Test",
                Active = true                
            };

            controller.Configuration = new HttpConfiguration();
            controller.Validate(technologyType);

            Assert.IsFalse(controller.ModelState.IsValid);
            Assert.AreEqual(controller.ModelState.Keys.Count, 1);
            Assert.AreEqual(controller.ModelState.GetErrorMessageForKey("Name"), Constants.TechnologyTypeName);
        }

        [TestMethod]
        public void SuccessfulCreationofNewTechnologyType()
        {
            Mock<IBaseRepository<TechnologyType>> baseRepository = new Mock<IBaseRepository<TechnologyType>>();
            Mock<ITechnologyTypeRepository> technologyTypeRepository = new Mock<ITechnologyTypeRepository>();

            TechnologyTypeController controller = new TechnologyTypeController(baseRepository.Object, technologyTypeRepository.Object);

            TechnologyType technologyType = new TechnologyType
            {
                Name = "Test",
                Description = "Test",
                Active = true
            };

            controller.Configuration = new HttpConfiguration();
            controller.Validate(technologyType);

            Assert.IsTrue(controller.ModelState.IsValid);
        }
    }
}
