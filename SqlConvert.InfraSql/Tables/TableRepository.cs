using Dapper;
using SqlConvert.Domain.Connections;
using SqlConvert.Domain.Structs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlConvert.InfraSql.Tables
{
    public class TableRepository : ITableRepository
    {
        private IConnection _connection;

        public TableRepository(IConnection connection)
        {
            _connection = connection;
        }
        public List<Table> GetTables()
        {
            var sqlSelect = GetTableSqlSelect();

            var tables = _connection.DbConnectionSql.Query<Table>(sqlSelect).ToList();

            foreach (var table in tables)
            {
                var columns = _connection.DbConnectionSql.Query<Column>(GetColumnSqlSelect(
                    _connection.DbConnectionSql.Database, table.ObjectId));
                table.SetColumns(columns);
            }

            return tables;
        }

        private string GetTableSqlSelect()
        {
            var sqlServerSelect = "SELECT [name] as [Name], [object_id] as [ObjectId] FROM SYS.tables ";
            switch (_connection.ServerType)
            {
                case Domain.ServerType.MSSqlServer:
                    return sqlServerSelect;
                case Domain.ServerType.PostGres:
                    return "select \"table_name\" as \"Name\", \"table_name\" as \"ObjectId\" from information_schema.tables where table_schema='public'";
                default:
                    return sqlServerSelect;
            }
        }
        private string GetColumnSqlSelect(string databaseName, string tableNameOrObjectId)
        {
            var sqlServerSelect = $@"
                SELECT sys.[all_columns].[Name], ServerType=0, [object_id] as [ObjectId], [sys].types.[name] as [DbTypeName]
                FROM sys.all_columns
                    inner join sys.types on sys.types.user_type_id = sys.all_columns.user_type_id
                        where[object_id] = {tableNameOrObjectId}";
            switch (_connection.ServerType)
            {
                case Domain.ServerType.MSSqlServer:
                    return sqlServerSelect;
                case Domain.ServerType.PostGres:
                    return $"select  column_name as \"Name\", 1 as \"ServerType\", data_type as DbTypeName, character_maximum_length as \"Size\" from INFORMATION_SCHEMA.COLUMNS where table_name = '{tableNameOrObjectId}' ";
                default:
                    return sqlServerSelect;
            }
        }

        public void CreateTable(string tableName, IEnumerable<Column> columns)
        {
            
        }
    }
}
