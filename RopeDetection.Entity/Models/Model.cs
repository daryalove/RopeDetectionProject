using RopeDetection.Entities.Context;
using System;
using System.Collections.Generic;

namespace RopeDetection.Entities.Models
{
    public class Model
    {
        public Model()
        {
            this.AnalysisHistories = new List<AnalysisHistory>();
            this.ModelAndObjects = new List<ModelAndObject>();
            this.TrainedModel = new TrainedModel();
        }

        public Guid Id { get; set; } = Guid.NewGuid();
        public int Name { get; set; }
        public string Type { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Creator { get; set; }
        public bool LearningStatus { get; set; }
        public DateTime ChangedDate { get; set; }
        public string UserId { get; set; }

        public List<ModelAndObject> ModelAndObjects { get; set; }
        public List<AnalysisHistory> AnalysisHistories { get; set; }
        public TrainedModel TrainedModel { get; set; }

        public void Insert()
        {
            using(var db = new ModelContext())
            {
                db.Models.Add(this);
                db.SaveChanges();
            }
        }

        public void UpdateChangedOn()
        {
            this.ChangedDate = DateTime.Now;
        }
    }
}
