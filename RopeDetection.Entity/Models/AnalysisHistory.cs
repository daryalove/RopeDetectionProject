using RopeDetection.Entities.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RopeDetection.Entities.Models
{
    public enum Result
    {
        OK,
        Warning,
        Error
    }

    public class AnalysisHistory
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime StartedDate { get; set; }
        public Guid ModelId { get; set; }
        public DateTime FinishedDate { get; set; }
        public Result AnalysisResult { get; set; }
        public string Message { get; set; }
        public string AnalysisType { get; set; }
        public string UserId { get; set; }

        public Model Model { get; set; }
        public AnalysisResult analysisResult { get; set; }

        public void Insert()
        {
            using (var db = new ModelContext())
            {
                db.AnalysisHistories.Add(this);
                db.SaveChanges();
            }
        }

        public void UpdatedMessageOn(string newMessage)
        {
            this.Message = newMessage;
        }

        public void UpdatedResultOn(Result newResult)
        {
            this.AnalysisResult = newResult;
        }

        public void UpdatedFinishedOn()
        {
            this.FinishedDate = DateTime.Now;
        }
    }
}
