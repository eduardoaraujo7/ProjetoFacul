using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class Conexao
    {
        public string ConnectionString()
        {
            return @"Data Source=.\sqlexpress;Initial Catalog=Login;Integrated Security=True";
        }

        public SqlConnection CriarConexao()
        {
            return new SqlConnection(ConnectionString());
        }
    }
}
