using Npgsql;

namespace QuantityMeasurementAppRepositoryLayer.Utils
{
    public static class DbConnectionFactory
    {
        private static readonly string connectionString =
            "Host=ep-little-meadow-ammlx367.c-5.us-east-1.aws.neon.tech;Database=neondb;Username=neondb_owner;Password=npg_UzQ0APRmS1aH;SSL Mode=Require;Trust Server Certificate=true";

        public static NpgsqlConnection CreateConnection()
        {
            return new NpgsqlConnection(connectionString);
        }
    }
}
