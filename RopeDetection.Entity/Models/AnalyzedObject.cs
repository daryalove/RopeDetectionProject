using RopeDetection.Entities.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace RopeDetection.Entities.Models
{
    public class AnalyzedObject
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Type { get; set; }
        public Guid? TrainedModelId { get; set; }
        public string Owner { get; set; }
        public DateTime DownloadedDate { get; set; }
        public string Characteristic { get; set; }
        public string UserId { get; set; }

        public TrainedModel trainedModel;

        public void Insert()
        {
            using (var db = new ModelContext())
            {
                db.AnalyzedObjects.Add(this);
                db.SaveChanges();
            }
        }
    }
}
