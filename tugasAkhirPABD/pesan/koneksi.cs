using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugasAkhirPABD.pesan
{
    class koneksi
    {
       public SqlConnection GetConn()

        {
            SqlConnection com = new SqlConnection();
            com.ConnectionString = @"Data Source=DESKTOP-8MPJNA9\MELINDARAHMAH;Initial Catalog=tokoroti; Integrated Security=True;";
            return com;


        }


    }
}
