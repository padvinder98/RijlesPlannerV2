namespace RijlesPlanner.Data.Connection
{
    public static class ConnectionString
    {
        private static string connectionString = "";

        public static string GetConnectionString()
        {
            return connectionString;
        }
    }
}