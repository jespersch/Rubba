using System;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;

namespace OOP
{
	public class Game
	{
		SqlConnection connection;
		public Game()
		{
			connection = new SqlConnection();

		}
	}
}
