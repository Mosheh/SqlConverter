using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlConvert.Domain.Structs
{
    public interface ITableRepository
    {
        List<Table> GetTables();

        void CreateTable(string tableName, IEnumerable<Column> columns);
    }
}
