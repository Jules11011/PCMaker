using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
	public abstract class BaseRepository
	{
		private readonly string _connectionString;
		protected BaseRepository(string connectionString)
		{
			_connectionString = connectionString;
		}

		protected SqlConnection GetConnection()
		{
			return new SqlConnection(_connectionString);
		}
	}
}
