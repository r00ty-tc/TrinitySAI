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
        public IEnumerable<smart_script_config> GetConfigDataByTypeQuery(int type)
        {
            var result =
            (
                from row in Db.smart_script_config
                where row.config_type == type
                select row
            );

            return result.AsEnumerable();
        }
    }
}
