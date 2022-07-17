using System;
using System.Data.SqlClient;

namespace Datos
{
    public class cls_Conexion
    {
        public SqlConnection connection = new SqlConnection("Data Source=DESKTOP-URA3VSU\\OSCAR;Initial Catalog=DBS_ComercioElectronico;integrated security = true");
    }
}
