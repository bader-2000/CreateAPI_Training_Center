using System;
using System.Collections.Generic;

namespace LarningHub.Core.Data
{
    public partial class Login
    {
        public decimal Loginid { get; set; }
        public string? Username { get; set; }
        public string? User_Password { get; set; }
        public decimal? Roleid { get; set; }
        public decimal? Studentid { get; set; }

        public virtual Role? Role { get; set; }
        public virtual Student? Student { get; set; }
    }
}
