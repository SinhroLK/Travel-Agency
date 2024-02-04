using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    public interface IEntity
    {
        string TableName { get; }
        string Values { get; }
        int id { get; }
        string idColumnName { get; }
        string zaJoin { get; }
        string zaSet { get; }
        List<IEntity> VratiReaderListu(SqlDataReader reader);
    }
}
