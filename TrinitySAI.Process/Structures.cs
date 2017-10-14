using System;
using System.Collections.Generic;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Trinity.DB;

namespace TrinitySAI
{
    public partial class Process
    {
        public class EventInfo
        {
            public UInt32 EventId;
            public string EventName;
            public string ParamName1;
            public string ParamName2;
            public string ParamName3;
            public string ParamName4;
            public UInt32 AllowedFlagMask;
            public bool IsHidden;
        }
    }
}
