using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAutentikasi
{
    public static class DbConfig
    {
        private static String dbServer = "localhost";
        private static String dbUser = "root";
        private static String dbPassword = "";
        private static String dbName = "univ_db";

        public static String ConnStr => $"server={dbServer};user={dbUser}; database={dbName}; password={dbPassword}";
    }
}
