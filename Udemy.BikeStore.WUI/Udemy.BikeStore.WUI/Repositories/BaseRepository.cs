using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.BikeStore.WUI.Repositories
{
    public class BaseRepository : IDisposable
    {
        public SqlConnection con { get; set; }

        public BaseRepository()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString);
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
