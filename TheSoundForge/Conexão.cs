using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace TheSoundForge
{
    class Conexão
    {
        public static SqlConnection conectar()
        {
            //conecta ao banco de dados
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = Properties.Settings.Default.dbTheSoundForgerConnectionString;
            return (cn);
        }
    }
}
