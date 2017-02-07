using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DotNetLearningModel.Entities
{
    public class TechnologyType : EntityBase
    {
        [Display(Name = "Technology")]
        [Required(ErrorMessage = Constants.TechnologyTypeName)]
        public string Name { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        [Display(Name = "Is Active")]
        [DefaultValue(false)]
        public bool Active { get; set; }
    }
}
