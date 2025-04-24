using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PCMaker___Logic_layer;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace DAL.Repositories
{
	public class AccountRepository
	{
		public int AddAccount(Account account)
		{
			using (SqlConnection conn = new(_connectionStringBuilder))
			{
				conn.Open();
				using (SqlCommand cmd = new("INSERT INTO accounts (name, email, password, role, publicity) VALUES (@Name, @Email, @Password, @Role, @Publicity) SELECT CAST(scope_identity() AS int)", conn )) //later query ergens anders vandaan halen
				{
					cmd.Parameters.AddWithValue("@Name", account.Name);
					cmd.Parameters.AddWithValue("@Email", account.Email);
					cmd.Parameters.AddWithValue("@Password", account.Password);
					cmd.Parameters.AddWithValue("@Role", account.Role);
					cmd.Parameters.AddWithValue("@Publicity", account.Publicity);

					return (int)cmd.ExecuteScalar();

				}
			}

		}

		private string _connectionStringBuilder = @"Server=mssqlstud.fhict.local;Database=dbi476661;User Id=dbi476661;Password=Kmd0c!3zkP;TrustedServerCertificate=True;";
	}
}
