using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LarningHub.Core.DTO
{
    public class TotalStudent
    {
       
            public string? CourseName { get; set; }

            [Column("COUNTSTUDENT")]  
            public decimal? CountStudent { get; set; }
        

    }
}
