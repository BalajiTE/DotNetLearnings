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
    public class TechnologyConceptTests
    {
        [TestMethod]
        public void RequiredTechnologyTypeNameOnCreation()
        {
            Mock<IBaseRepository<TechnologyConcept>> baseRepository = new Mock<IBaseRepository<TechnologyConcept>>();
            Mock<ITechnologyConceptRepository> technologyConceptRepository = new Mock<ITechnologyConceptRepository>();

            TechnologyConceptController controller = new TechnologyConceptController(baseRepository.Object, technologyConceptRepository.Object);

            TechnologyConcept technologyConcept = new TechnologyConcept
            {
                Description = "Test",
                Active = true
            };

            controller.Configuration = new HttpConfiguration();
            controller.Validate(technologyConcept);

            Assert.IsFalse(controller.ModelState.IsValid);
            Assert.AreEqual(controller.ModelState.Keys.Count, 1);
            Assert.AreEqual(controller.ModelState.GetErrorMessageForKey("Name"), Constants.TechnologyConceptName);
        }

        [TestMethod]
        public void SuccessfulCreationofNewTechnologyConcept()
        {
            Mock<IBaseRepository<TechnologyConcept>> baseRepository = new Mock<IBaseRepository<TechnologyConcept>>();
            Mock<ITechnologyConceptRepository> technologyConceptRepository = new Mock<ITechnologyConceptRepository>();

            TechnologyConceptController controller = new TechnologyConceptController(baseRepository.Object, technologyConceptRepository.Object);
            TechnologyConcept technologyConcept = new TechnologyConcept
            {
                Name = "Test",
                Description = "Test",
                Active = true
            };

            controller.Configuration = new HttpConfiguration();
            controller.Validate(technologyConcept);

            Assert.IsTrue(controller.ModelState.IsValid);
        }
    }
}
