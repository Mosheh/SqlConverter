using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlConvert.Domain.Connections
{
    public class ConnectionParam
    {
        public ConnectionParam()            
        {
            Port = 1433;
        }
        public ConnectionParam(ServerType type)
            :this()
        {
            this.ServerType = type;
        }

        private ServerType _serverType;

        public ServerType ServerType
        {
            get { return _serverType; }
            set {
                _serverType = value;
                SetPort(value);
            }
        }

        private void SetPort(ServerType value)
        {
            switch (value)
            {
                case ServerType.MSSqlServer:
                    Port = 1433;
                    break;
                case ServerType.PostGres:
                    Port = 5432;
                    break;
                default:
                    break;
            }
        }

        private string _server;

        public string Server
        {
            get {
                if (string.IsNullOrEmpty(_server))
                    _server = "localhost";
                return _server;
            }
            set { _server = value; }
        }

        public string User { get; set; }
        public string Password { get; set; }
        public string Database { get; set; }
        public int Port { get; set; }

        public override string ToString()
        {
            switch (ServerType)
            {
                case ServerType.MSSqlServer:
                    var serverNameParts = Server.Split('\\');
                    var instance = "";
                    var server = "";
                    if (serverNameParts.Length > 1)
                    {
                        server = serverNameParts[0];
                        instance = "\\"+serverNameParts[1];
                    }

                                   
                    return $"Server={Server};Database={Database};User Id={User};Password = {Password};";
                case ServerType.PostGres:

                    return $"host={Server}; database={Database}; user id={User}; password={Password}; port={Port}";
                default:
                    return $"Server={Server}; User Id={User}; Password={Password}; Database={Database};";
            }
        }
    }
}
