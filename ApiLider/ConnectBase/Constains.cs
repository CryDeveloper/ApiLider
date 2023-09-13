using System.Data.SqlClient;

namespace ApiLider.ConnectBase
{
    public class Constains
    {
        public static string SqlConnectionIntegratedSecurity
        {
            get 
            {
                var sb = new SqlConnectionStringBuilder
                {
                    DataSource = "DESKTOP-INNHFLC",
                    InitialCatalog = "TestLiderApi",
                    IntegratedSecurity = true,
                    TrustServerCertificate = true
                };
                return sb.ToString();
            }
        }
    }
}
