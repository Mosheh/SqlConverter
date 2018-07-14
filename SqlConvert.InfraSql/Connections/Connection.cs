using SqlConvert.Domain.Connections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlConvert.Domain;
using System.Data;
using System.Data.SqlClient;
using Npgsql;

namespace SqlConvert.InfraSql.Connections
{
    public class Connection : IConnection
    {
        public bool Connected
        {
            get;

            set;
        }

        public IDbConnection DbConnectionSql
        {
            get;
            set;
        }

        public ServerType ServerType
        {
            get;

            set;
        }

        public void Connect(ConnectionParam param)
        {
            ValidParam(param);
            this.ServerType = param.ServerType;
            try
            {
                switch (param.ServerType)
                {
                    case ServerType.MSSqlServer:
                        var sqlConn = new SqlConnection(param.ToString());
                        sqlConn.Open();
                        this.DbConnectionSql = sqlConn;
                        Connected = true;
                        break;
                    case ServerType.PostGres:
                        var pgConnection = new NpgsqlConnection(param.ToString());
                        pgConnection.Open();
                        this.DbConnectionSql = pgConnection;
                        Connected = true;
                        break;
                    default:
                        break;
                }
            }
            catch (Exception)
            {
                Connected = false;
                throw;
            }
           
        }

        private void ValidParam(ConnectionParam param)
        {
            if (param == null)
                throw new ArgumentNullException(nameof(param));
        }
    }
}
