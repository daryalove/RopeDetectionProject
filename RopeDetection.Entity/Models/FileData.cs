using Microsoft.EntityFrameworkCore;
using RopeDetection.Entities.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace RopeDetection.Entities.Models
{
    //[Owned]
    public class FileData
    {
        public Guid id { get; set; } = Guid.NewGuid();
        public string FileName { get; set; }
        public string FileType { get; set; }
        public byte[] FileContent { get; set; }
        public Guid ParentCode { get; set; }
        public int FileIndex { get; set; }
        public string ParentType { get; set; }
        public string UserId { get; set; }

        public void Insert()
        {
            using (var db = new ModelContext())
            {
                db.FileDatas.Add(this);
                db.SaveChanges();
            }
        }
    }
}
