using LiteDB;

namespace LogroconiumGame.Repository.DbContext
{
	public class LiteDbContext
	{
		private readonly string _databaseName;
		public LiteDatabase Database { get; private set; }
		public LiteDbContext()
		{
			_databaseName = "values*.db";
			ReconfigureDB();
		}

		public void ReconfigureDB()
		{
			var dbName = _databaseName.Replace("*", DateTime.UtcNow.AddDays(-(int)DateTime.UtcNow.DayOfWeek).ToString("yyyyMMdd"));

			Database = new LiteDatabase(dbName);
		}
	}
}
