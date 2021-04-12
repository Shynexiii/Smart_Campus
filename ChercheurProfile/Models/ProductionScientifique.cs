using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChercheurProfile.Models
{
    public class ProductionScientifique
    {
        public int Id{ get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Reference { get; set; }
        public string Type { get; set; }
        public string Created_at { get; set; }
        public int Created_by { get; set; }
    }
}