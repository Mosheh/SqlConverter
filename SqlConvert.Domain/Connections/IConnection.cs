using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlConvert.Domain.Connections
{
    public interface IConnection
    {
        ServerType ServerType { get; }
        bool Connected { get;  }

        void Connect(ConnectionParam param);

        IDbConnection DbConnectionSql { get;  }
    }
}
