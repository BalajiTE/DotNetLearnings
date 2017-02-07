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
    public class TechnologyLanguageTests
    {
        [TestMethod]
        public void RequiredTechnologyTypeNameOnCreation()
        {
            Mock<IBaseRepository<TechnologyLanguage>> baseRepository = new Mock<IBaseRepository<TechnologyLanguage>>();
            Mock<ITechnologyLanguageRepository> technologyLanguageRepository = new Mock<ITechnologyLanguageRepository>();

            TechnologyLanguageController controller = new TechnologyLanguageController(baseRepository.Object, technologyLanguageRepository.Object);

            TechnologyLanguage technologyLanguage = new TechnologyLanguage
            {
                Description = "Test",
                Active = true
            };

            controller.Configuration = new HttpConfiguration();
            controller.Validate(technologyLanguage);

            Assert.IsFalse(controller.ModelState.IsValid);
            Assert.AreEqual(controller.ModelState.Keys.Count, 1);
            Assert.AreEqual(controller.ModelState.GetErrorMessageForKey("Name"), Constants.TechnologyLanguageName);
        }

        [TestMethod]
        public void SuccessfulCreationofNewTechnologyLanguage()
        {
            Mock<IBaseRepository<TechnologyLanguage>> baseRepository = new Mock<IBaseRepository<TechnologyLanguage>>();
            Mock<ITechnologyLanguageRepository> technologyLanguageRepository = new Mock<ITechnologyLanguageRepository>();

            TechnologyLanguageController controller = new TechnologyLanguageController(baseRepository.Object, technologyLanguageRepository.Object);

            TechnologyLanguage technologyLanguage = new TechnologyLanguage
            {
                Name = "Test",
                Description = "Test",
                Active = true
            };

            controller.Configuration = new HttpConfiguration();
            controller.Validate(technologyLanguage);

            Assert.IsTrue(controller.ModelState.IsValid);
        }
    }
}
