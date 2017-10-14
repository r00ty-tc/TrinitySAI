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
        private TrinityDB Db;
        private Config config;
        private EventInfo[] EventTable;

        public Process(Config data)
        {
            config = data;
        }

        public void ConnectDb(string UserId, string Password, string Database = "world", string Hostname = "localhost")
        {
            var sql = new MySqlConnectionStringBuilder();
            sql.Password = Password;
            sql.Database = Database;
            sql.UserID = UserId;
            sql.Server = Hostname;
            var dbCon = new MySqlConnection(sql.GetConnectionString(true));
            Db = new TrinityDB(dbCon);
        }

        public void ConnectDb(int serverId = 0)
        {
            if (serverId == 0)
                serverId = config.GetDefaultServerId();

            if (serverId == 0)
                return;

            var serverInfo = config.GetServer(serverId);
            if (serverInfo == null)
                return;

            ConnectDb(serverInfo.Username, serverInfo.Password, serverInfo.Database, serverInfo.Hostname);
        }

        public void LoadEvents()
        {
            var eventList = new List<EventInfo>();
            var results = GetConfigDataByTypeQuery(1);
            foreach (var row in results)
            {
                var ev = new EventInfo();
                ev.EventId = (UInt32)row.config_key;
                ev.EventName = row.config_name;
                ev.ParamName1 = row.param1_name;
                ev.ParamName2 = row.param2_name;
                ev.ParamName3 = row.param3_name;
                ev.ParamName4 = row.param4_name;
                ev.AllowedFlagMask = (UInt32)row.valid_flags;
                ev.IsHidden = row.hidden;
                eventList.Add(ev);
            }

            UInt32 maxEvent = eventList.OrderByDescending(line => line.EventId).Select(line => line.EventId).FirstOrDefault();
            EventTable = new EventInfo[maxEvent+1];
            foreach (var entry in eventList)
                EventTable[entry.EventId] = entry;
        }

        public string TestQuery()
        {
            var result = 
            (
                from row in Db.smart_script_config
                where row.config_type == 1 && row.config_key == 2
                select row
            ).FirstOrDefault();

            return result?.config_name;
        }
}
}
