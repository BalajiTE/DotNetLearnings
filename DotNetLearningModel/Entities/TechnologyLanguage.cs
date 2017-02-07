using System.ComponentModel.DataAnnotations;

namespace DotNetLearningModel.Entities
{
    public class TechnologyLanguage : EntityBase
    {
        [Display(Name = "Language")]
        [Required(ErrorMessage = Constants.TechnologyLanguageName)]
        public string Name { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        [Display(Name = "Is Active")]
        public bool Active { get; set; }

        public int TechnologyTypeID { get; set; }
        public virtual TechnologyType TechnologyType { get; set; }
    }
}
