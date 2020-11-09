using RopeDetection.Entities.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace RopeDetection.Entities.Models
{
    public class ModelObject
    {
        public ModelObject()
        {
            this.ModelObjectType = new ModelObjectType();
        }
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime DownloadedDate { get; set; }
        public string Characteristic { get; set; }
        //public Guid ModelId { get; set; }
        public Guid TypeId { get; set; }
        public ModelObjectType ModelObjectType { get; set; }

        public List<ModelAndObject> ModelAndObjects { get; set; }
        //public List<Model> Models { get; set; }

        public void Insert()
        {
            using(var db = new ModelContext())
            {
                db.ModelObjects.Add(this);
                db.SaveChanges();
            }
        }
    }
}
