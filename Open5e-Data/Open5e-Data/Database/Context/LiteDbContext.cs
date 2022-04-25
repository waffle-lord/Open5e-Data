using LiteDB;

namespace Open5e_Data.Database.Context
{
    internal class LiteDbContext : IDisposable
    {
        private readonly string _dbFile = Path.Join(Directory.GetCurrentDirectory(), "/open5e.db");

        public LiteDatabase Database;

        internal LiteDbContext(string path = "")
        {
            if (path == "") path = _dbFile;

            var connectionString = new ConnectionString(path)
            {
                Connection = ConnectionType.Shared
            };

            Database = new LiteDatabase(connectionString);
        }

        public void Dispose()
        {
            Database.Dispose();
        }
    }
}
