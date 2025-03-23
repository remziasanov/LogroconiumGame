using LiteDB;

namespace LogroconiumGame.Repository.DbContext
{
	public class LiteDbContext
	{
		private readonly string _databaseName;
		public LiteDatabase Database { get; private set; }
		public LiteDbContext(string dbName)
		{
			_databaseName = dbName;
			ReconfigureDB();
		}

		public void ReconfigureDB()
		{
			Database = new LiteDatabase(_databaseName);
		}
	}
}
