using System;
using System.Collections.Generic;

namespace LarningHub.Core.Data
{
    public partial class Stdcourse
    {
        public decimal Id { get; set; }
        public decimal? Stid { get; set; }
        public decimal? Courseid { get; set; }
        public decimal? Markofsid { get; set; }
        public DateTime? Dateofregister { get; set; }

        public virtual Course? Course { get; set; }
        public virtual Student? St { get; set; }
    }
}
