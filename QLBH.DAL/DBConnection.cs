using Microsoft.Data.SqlClient;

namespace QLBH.DAL
{
    public abstract class DBConnection
    {
        protected SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;
              Initial Catalog=QLBH;
              Integrated Security=True;
              Encrypt=False;
              TrustServerCertificate=True");
       /* protected const string ConnectionString =
           @"Data Source=.\SQLEXPRESS;
              Initial Catalog=QLBH;
              Integrated Security=True;
              Encrypt=True;
              TrustServerCertificate=True";*/
    }
}
