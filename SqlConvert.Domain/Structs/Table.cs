using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlConvert.Domain.Structs
{
    public class Table
    {
        public string ObjectId { get; set; }
        public string Name { get; set; }

       public List<Column> Columns { get; private set; }

        public void SetColumns(IEnumerable<Column> columns)
        {
            this.Columns = columns.ToList();
        }
    }
}
