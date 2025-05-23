using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
	public class AccountRepository : BaseRepository
	{
		public AccountRepository(string connectionString) : base(connectionString)
		{
		}

		//Use a model class for the account
		public void AddAccount(string accountName)
		{
			using (var connection = GetConnection())
			{
				connection.Open();
				var command = connection.CreateCommand();
				command.CommandText = "INSERT INTO Accounts (Name) VALUES (@name)";
				command.Parameters.AddWithValue("@name", accountName);
				command.ExecuteNonQuery();
			}
		}
	}
}
