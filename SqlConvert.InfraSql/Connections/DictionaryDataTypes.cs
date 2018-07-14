using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlConvert.InfraSql.Connections
{
    public class DictionaryDataTypes
    {
        private static Dictionary<string, DbType> _postgresTypes;
        private static Dictionary<string, DbType> _sqlServerTypes;

        public Dictionary<string, DbType> PostgresTypes
        {
            get {
                if (_postgresTypes == null)
                {
                    _postgresTypes = new Dictionary<string, DbType>();
                    InitPosgresTypes(_postgresTypes);
                }
                return _postgresTypes;
            }
        }

        public Dictionary<string, DbType> SqlServerTypes
        {
            get
            {
                return _sqlServerTypes;
            }
        }

        private void InitPosgresTypes(Dictionary<string, DbType> _postgresTypes)
        {
            _postgresTypes = new Dictionary<string, DbType>();
            _postgresTypes.Add("text", DbType.String);
            _postgresTypes.Add("char", DbType.String);
            _postgresTypes.Add("smallint", DbType.Int32);
            _postgresTypes.Add("integer", DbType.Int32);
            _postgresTypes.Add("timestamp without time zone", DbType.DateTime);
            _postgresTypes.Add("boolean", DbType.Boolean);
        }
    }
}
