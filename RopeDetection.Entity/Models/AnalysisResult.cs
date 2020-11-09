using RopeDetection.Entities.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace RopeDetection.Entities.Models
{
    public class AnalysisResult
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid FileId { get; set; }
        public string PredictedValue { get; set; }
        public DateTime DownloadDate { get; set; }
        public Guid HistoryId { get; set; }
        public string Characteristic { get; set; }
        public int MaxScore { get; set; }
        public string Label { get; set; }

        public AnalysisHistory History { get; set; }

        public void Insert()
        {
            using (var db = new ModelContext())
            {
                db.AnalysisResults.Add(this);
                db.SaveChanges();
            }
        }
    }
}
