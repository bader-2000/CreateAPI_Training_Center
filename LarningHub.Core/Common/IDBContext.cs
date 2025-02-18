using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LarningHub.Core.Common
{
    public interface IDBContext
    {
        DbConnection Connection { get; }
    }
}
