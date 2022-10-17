using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpliLearnProj4WebAPI.Models
{
    public class MarksModel
    {
        public decimal marks { get; set; }
        public Nullable<int> StudId { get; set; }
        public Nullable<int> SubjectId { get; set; }
    }
}