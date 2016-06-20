using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace WarehouseSystem
{
    class ConnectDB
    {
        public string HOST { get; set; }
        public string UID { get; set; }
        public string DB { get; set; }
        public string PASSWD { get; set; }

        public ConnectDB()
        {
            XmlReader reader = XmlReader.Create("data.xml");


            List<string> names = new List<string> { "uid", "password", "server", "database" };

            int index;
            while (reader.Read())
            {
                if (reader.IsStartElement() && names.IndexOf(reader.Name) >= 0)
                {
                    index = names.IndexOf(reader.Name);
                    reader.Read();
                    switch (index)
                    {
                        case 0:
                            UID = reader.Value;
                            break;
                        case 1:
                            PASSWD = reader.Value;
                            break;
                        case 2:
                            HOST = reader.Value;
                            break;
                        case 3:
                            DB = reader.Value;
                            break;
                    }
                }
            }

            reader.Close();
        }

        public override string ToString()
        {
            string connectionString;

            connectionString = "SERVER=" + HOST + ";DATABASE=" +
            DB + ";" + "UID=" + UID + ";" + "PASSWORD=" + PASSWD + ";";

            return connectionString;
        }
    }
}
