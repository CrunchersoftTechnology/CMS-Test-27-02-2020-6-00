﻿using System;
using System.Web;

namespace CMS.Domain.Storage.Projections
{
    public class AssignmentProjection
    {
        public int UploadAssignmentsId { get; set; }

        public string BoardName { get; set; }

        public string ClassName { get; set; }

        public string SubjectName { get; set; }

        public string Title { get; set; }

        public DateTime UploadDate { get; set; }

        public string FileName { get; set; }

        public string LogoName { get; set; }

        public bool IsVisible { get; set; }

        public HttpPostedFileBase FilePath { get; set; }

        public HttpPostedFileBase LogoPath { get; set; }

        public int BoardId { get; set; }

        public int ClassId { get; set; }

        public int SubjectId { get; set; }
    }
}
