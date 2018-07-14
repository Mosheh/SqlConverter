using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlConvert.Domain
{
    public enum ServerType
    {
        MSSqlServer,
        PostGres
    }

    public static class Extentions
    {
        public static ServerType GetEnumByName(this string value)
        {
            switch (value)
            {
                case "MSSqlServer":
                    return ServerType.MSSqlServer;
                case "PostGres":
                    return ServerType.PostGres;

                default:
                    return ServerType.MSSqlServer;
            }
        }
    }
}
