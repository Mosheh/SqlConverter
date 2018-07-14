using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlConvert.Domain.Structs
{
    public class Column
    {
       
        public string Name { get; set; }
        public DbType Type { get; set; }
        public int Size { get; set; }

        private string _dbTypeName;
        public ServerType ServerType { get; set; }

        public string DbTypeName
        {
            get { return _dbTypeName; }
            set { _dbTypeName = value;
                SetDbType();
            }
        }

        private void SetDbType()
        {
            
        }

        public string GetDbTypeName(ServerType type)
        {
            switch (type)
            {
                case ServerType.MSSqlServer:
                    return GetSqlServerType();
                case ServerType.PostGres:

                    return GetPgSqlServerType();
                default:
                    return GetSqlServerType();
            }
        }

        private string GetSqlServerType()
        {
            switch (Type)
            {
                case DbType.AnsiString:                
                    return $"nvarchar ({Size})";
                case DbType.Binary:
                    return "";
                    
                case DbType.Byte:
                    return "";
                case DbType.Boolean:
                    return "bit ";
                case DbType.Currency:
                    return "decimal (16,2)";
                    
                case DbType.Date:
                    return "Datetime";
                    
                case DbType.DateTime:
                    return "DateTime";
                case DbType.Decimal:
                    return "decimal(16,2)";
                case DbType.Double:
                    return "float";                    
                case DbType.Guid:
                    return "Guid";
                case DbType.Int16:
                    return "smallint";
                case DbType.Int32:
                    return "int"; 
                case DbType.Int64:
                    return "bigint";
                case DbType.Object:
                    return "sql_variant";
                case DbType.SByte:
                    return "binary";
                case DbType.Single:
                    return "sql_variant";
                case DbType.String:
                    return $"nvarchar ({Size})";                    
                case DbType.Time:
                    return "time";
                case DbType.UInt16:
                    return "int";
                case DbType.UInt32:
                    return "int";
                case DbType.UInt64:
                    return "int";
                case DbType.VarNumeric:
                    return "int";
                case DbType.AnsiStringFixedLength:
                    return $"nvarchar ({Size})";
                case DbType.StringFixedLength:
                    return $"nvarchar ({Size})";
                case DbType.Xml:
                    return "xml";
                case DbType.DateTime2:
                    return "Datetime";
                case DbType.DateTimeOffset:
                    return "Datetime";
                default:
                    return $"nvarchar ({Size})"; 
            }
        }

        private string GetPgSqlServerType()
        {
            switch (Type)
            {
                case DbType.AnsiString:
                    return $"nvarchar ({Size})";
                case DbType.Binary:
                    return "";

                case DbType.Byte:
                    return "";
                case DbType.Boolean:
                    return "bit ";
                case DbType.Currency:
                    return "decimal (16,2)";

                case DbType.Date:
                    return "Datetime";

                case DbType.DateTime:
                    return "DateTime";
                case DbType.Decimal:
                    return "decimal(16,2)";
                case DbType.Double:
                    return "float";
                case DbType.Guid:
                    return "Guid";
                case DbType.Int16:
                    return "smallint";
                case DbType.Int32:
                    return "int";
                case DbType.Int64:
                    return "bigint";
                case DbType.Object:
                    return "sql_variant";
                case DbType.SByte:
                    return "binary";
                case DbType.Single:
                    return "sql_variant";
                case DbType.String:
                    return $"nvarchar ({Size})";
                case DbType.Time:
                    return "time";
                case DbType.UInt16:
                    return "int";
                case DbType.UInt32:
                    return "int";
                case DbType.UInt64:
                    return "int";
                case DbType.VarNumeric:
                    return "int";
                case DbType.AnsiStringFixedLength:
                    return $"nvarchar ({Size})";
                case DbType.StringFixedLength:
                    return $"nvarchar ({Size})";
                case DbType.Xml:
                    return "xml";
                case DbType.DateTime2:
                    return "Datetime";
                case DbType.DateTimeOffset:
                    return "Datetime";
                default:
                    return $"nvarchar ({Size})";
            }
        }
    }
}
