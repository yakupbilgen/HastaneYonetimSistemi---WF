using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace HastaneYonetimSistemi
{
	class SqlConn
	{
		public SqlConnection Baglanti()
		{
			SqlConnection conn = new SqlConnection("Data Source=DESKTOP-LU5VIM4\\MSSQLSERVER1;Initial Catalog=DBHastaneYonetim;Integrated Security=True");
			if (conn.State==System.Data.ConnectionState.Open)
			{
				conn.Close();
			}
			conn.Open();

			return conn;
		}
	}
}
