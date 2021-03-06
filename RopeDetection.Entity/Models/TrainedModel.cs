﻿using RopeDetection.Entities.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace RopeDetection.Entities.Models
{
    public enum TrainingStatus
    {
        NotTrained,
        InProgress,
        Completed
    }

    public class TrainedModel
    {
        public TrainedModel()
        {
            this.AnalyzedObjects = new List<AnalyzedObject>();
        }

        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid? ModelId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ChangedDate { get; set; }
        public string Creator { get; set; }
        public string ZipPath { get; set; }
        public TrainingStatus LearningStatus { get; set; }

        public List<AnalyzedObject> AnalyzedObjects { get; set; }
        public Model Model { get; set; }

        public void Insert()
        {
            using(var db = new ModelContext())
            {
                db.TrainedModels.Add(this);
                db.SaveChanges();
            }
        }

        public void UpdatedChangedOn()
        {
            this.ChangedDate = DateTime.Now;
        }

        public void UpdatedProgressOn(TrainingStatus newStatus)
        {
            this.LearningStatus = newStatus;
        }
    }
}
