using System;

namespace DotNetLearningModel.Entities
{
    public abstract class EntityBase
    {
        public int ID { get; set; }

        public DateTime? CreateDate { get; set; }

        public DateTime? ModifiedDate { get; set; }
    }
}
