using Microsoft.Data.SqlClient;

public static class DatabaseConfig
{
    public static string ConnectionString =
        "Server=127.0.0.1,1433;" +
        "Database=practice_db;" +
        "User Id=sa;" +
        "Password=Vansh@77;" +
        "Encrypt=False;" +
        "TrustServerCertificate=True;";

    public static SqlConnection GetConnection()
    {
        SqlConnection connection = new SqlConnection(ConnectionString);
        connection.Open();
        return connection;
    }
}
