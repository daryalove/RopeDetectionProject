using RopeDetection.Entities.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace RopeDetection.Entities.Models
{
    public class ModelObjectType
    {
        public ModelObjectType()
        {
            this.ModelObjects = new List<ModelObject>();
        }
        public Guid id { get; set; } = Guid.NewGuid();
        // Прогнозируемой значение(тип дефекта)
        public string Label { get; set; } 
        public List<ModelObject> ModelObjects { get; set; }

        public void Insert()
        {
            using (var db = new ModelContext())
            {
                db.ModelObjectTypes.Add(this);
                db.SaveChanges();
            }
        }
    }
}
