using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TrinitySAI
{
    public class Config
    {
        private Configuration config;

        [XmlRoot("TrinitySAI")]
        public class Configuration
        {
            public List<ServerEntry> ServerData;
            public int DefaultServer;

            public Configuration()
            {
                ServerData = new List<ServerEntry>();
            }
        }

        public class ServerEntry
        {
            [XmlAttribute("id")]
            public int ServerId;
            public string Hostname;
            public string Database;
            public string Username;
            public string Password;
        }

        public Config()
        {
            config = new Configuration();
        }

        public bool Save(string fileName = "TrinitySAI.xml")
        {
            try
            {
                XmlSerializer configSerial = new XmlSerializer(config.GetType());
                using (TextWriter configWriter = new StreamWriter(fileName))
                {
                    configSerial.Serialize(configWriter, config);
                }
            }
            catch(Exception ex)
            {
                throw ex;
                return false;
            }
            return true;
        }

        public bool Load(string fileName = "TrinitySAI.xml")
        {
            try
            {
                XmlSerializer configSerial = new XmlSerializer(config.GetType());
                TextReader configReader = new StreamReader(fileName);
                config = (Configuration) configSerial.Deserialize(configReader);
                configReader.Close();
            }
            catch(Exception ex)
            {
                throw ex;
                return false;
            }
            return true;
        }

        public ServerEntry GetServer(int id) => config?.ServerData?.FirstOrDefault(line => line.ServerId == id);
        private int GetHighServerId() => config?.ServerData?.OrderByDescending(line => line.ServerId).Select(line => line.ServerId).FirstOrDefault() ?? 0;
        public int GetDefaultServerId() => config?.DefaultServer ?? 0;

        public void AddServer(string Hostname, string Database, string Username, string Password)
        {
            var serverInfo = new ServerEntry();
            serverInfo.Hostname = Hostname;
            serverInfo.Database = Database;
            serverInfo.Username = Username;
            serverInfo.Password = Password;
            serverInfo.ServerId = GetHighServerId() + 1;
            AddServer(serverInfo);
        }

        public void AddServer(ServerEntry entry)
        {
            if (entry.ServerId == 0)
                entry.ServerId = GetHighServerId() + 1;

            config.ServerData.Add(entry);
        }
    }
}
