using System.ComponentModel.DataAnnotations;

namespace DotNetLearningModel.Entities
{
    public class LanguageConcept : EntityBase
    {
        [Display(Name = "Language")]
        public int TechnologyLanguageID { get; set; }
        public virtual TechnologyLanguage TechnologyLanguage { get; set; }

        [Display(Name = "Concept")]
        public int TechnologyConceptID { get; set; }
        public virtual TechnologyConcept TechnologyConcept { get; set; }

        [Display(Name = "Is Active")]
        public bool Active { get; set; }
    }
}
