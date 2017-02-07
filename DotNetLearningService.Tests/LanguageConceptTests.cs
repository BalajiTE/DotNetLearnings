using DotNetLearningModel.Entities;
using DotNetLearningService.Controllers;
using DotNetLearningService.Repositories.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace DotNetLearningService.Tests
{
    [TestClass]
    public class LanguageConceptTests
    {
        [TestMethod]
        public void RequiredLanguageConceptNameOnCreation()
        {
            Mock<IBaseRepository<LanguageConcept>> baseRepository = new Mock<IBaseRepository<LanguageConcept>>();
            Mock<ILanguageConceptRepository> languageConceptRepository = new Mock<ILanguageConceptRepository>();

            LanguageConceptController controller = new LanguageConceptController(baseRepository.Object, languageConceptRepository.Object);

            //LanguageConcept languageConcept = new LanguageConcept
            //{
            //    Description = "Test",
            //    Active = true
            //};

            //controller.Configuration = new HttpConfiguration();
            //controller.Validate(languageConcept);

            //Assert.IsFalse(controller.ModelState.IsValid);
            //Assert.AreEqual(controller.ModelState.Keys.Count, 1);
            //Assert.AreEqual(controller.ModelState.GetErrorMessageForKey("Name"), Constants.LanguageConceptName);
        }

        [TestMethod]
        public void SuccessfulCreationofNewLanguageConcept()
        {
            Mock<IBaseRepository<LanguageConcept>> baseRepository = new Mock<IBaseRepository<LanguageConcept>>();
            Mock<ILanguageConceptRepository> languageConceptRepository = new Mock<ILanguageConceptRepository>();

            LanguageConceptController controller = new LanguageConceptController(baseRepository.Object, languageConceptRepository.Object);

            //LanguageConcept languageConcept = new LanguageConcept
            //{
            //    Name = "Test",
            //    Description = "Test",
            //    Active = true
            //};

            //controller.Configuration = new HttpConfiguration();
            //controller.Validate(languageConcept);

            //Assert.IsTrue(controller.ModelState.IsValid);
        }
    }
}
