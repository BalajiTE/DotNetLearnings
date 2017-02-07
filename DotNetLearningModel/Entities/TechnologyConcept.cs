using System.ComponentModel.DataAnnotations;

namespace DotNetLearningModel.Entities
{
    public class TechnologyConcept : EntityBase
    {
        [Display(Name = "Concept")]
        [Required(ErrorMessage = Constants.TechnologyConceptName)]
        public string Name { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        [Display(Name = "Is Active")]
        public bool Active { get; set; }
    }
}
