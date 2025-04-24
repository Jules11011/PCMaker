using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCMaker___Logic_layer
{
	public class Account
	{
		public int? AccountID { get; private set; }
		public string Name { get; private set; }
		public string Email { get; private set; }
		public string Password { get; private set; }
		public int Role { get; private set; }
		public int Publicity { get; private set; }

		public Account(string name, string email, string password)
		{
			Name = name;
			Email = email;
			Password = password;
			Role = 0;
			Publicity = 0;
		}
	}
}
