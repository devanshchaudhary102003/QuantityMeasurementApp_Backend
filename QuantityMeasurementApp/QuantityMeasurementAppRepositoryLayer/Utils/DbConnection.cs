using Npgsql;

namespace QuantityMeasurementAppRepositoryLayer.Utils
{
    public static class DbConnectionFactory
    {
        private static readonly string connectionString =
            Environment.GetEnvironmentVariable("ConnectionStrings__DefaultConnection")
            ?? "Host=localhost;Database=QuantityMeasurementDB;Username=postgres;Password=yourpassword";

        public static NpgsqlConnection CreateConnection()
        {
            return new NpgsqlConnection(connectionString);
        }
    }
}
