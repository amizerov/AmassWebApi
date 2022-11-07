namespace AmassWebApi.Tools
{
    public class Secrets
    {
        public static string GetConnectionString()
        {
            string sqlConnectionString = "";
            
            string path = Environment.GetEnvironmentVariable(
                "SecretsFolder", EnvironmentVariableTarget.Machine)!
                + "\\SqlConnectionStringForAmassProgerX.txt";

            if (File.Exists(path))
                sqlConnectionString = File.ReadAllText(path);
            else
                throw new Exception("File with Sql Connection string is not found!");
            
            return sqlConnectionString;
        }
    }
}
