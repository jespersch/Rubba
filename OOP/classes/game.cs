using System;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;

namespace OOP
{
	public class Game
	{
		private SqlConnection connection = new SqlConnection();

		private Dictionary<int, string> table_Data = new Dictionary<int, string>();

		private KeyValuePair<int, string> record = default;

		public Game()
		{

			table_Data.Add(1, "battlefield 2024");
			table_Data.Add(2, "m");
			table_Data.Add(3, "rs");

		}
		public KeyValuePair<int, string> find(int id)
		{
			var key = id;

			var value = table_Data[key];

			var record = new KeyValuePair<int, string>(key, value);

			this.record = record;

			return record;


		}
	}
}


