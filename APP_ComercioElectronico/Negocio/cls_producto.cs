using System;
using System.Data.SqlClient;
using System.Data;
using Datos;

namespace Negocio
{
    public class cls_producto
    {
        private String str_Codigo;
        private String str_Nombre;
        private String str_Precio;
        private int int_Stock;
        private String str_Categoria;
        private String str_Fecha;
        private String str_Especificaciones;

        public cls_producto(String Codigo, String Nombre, String Precio, int Stock, String Categoria,
                            String Fecha, String Especificaciones)
        {
            cls_Conexion objconect = new cls_Conexion();
            SqlCommand con = new SqlCommand("SP_Guardar", objconect.connection);
            con.CommandType = CommandType.StoredProcedure;
            con.Parameters.AddWithValue("@PKCodigo", Codigo);
            con.Parameters.AddWithValue("@Nombre", Nombre);
            con.Parameters.AddWithValue("@Fecha", Fecha);
            con.Parameters.AddWithValue("@Stock", Stock);
            con.Parameters.AddWithValue("@FKCodigo_tbl_Categoria", Categoria);
            con.Parameters.AddWithValue("@Precio", Precio);
            con.Parameters.AddWithValue("@Especificaciones", Especificaciones);
            objconect.connection.Open();
            con.ExecuteNonQuery();
            objconect.connection.Close();
        }
        public cls_producto() { }

        public void fnt_Consultar_Producto(String Codigo) 
        {
            cls_Conexion objconect = new cls_Conexion();
            SqlCommand con; SqlDataReader Lectura;
            con = new SqlCommand("SP_ConsultarProducto", objconect.connection);
            con.CommandType = CommandType.StoredProcedure;
            con.Parameters.AddWithValue("@PKCodigo", Codigo);
            objconect.connection.Open();
            Lectura = con.ExecuteReader();
            if (Lectura.Read() == true)
            {
                str_Nombre = Convert.ToString(Lectura[0]);
                str_Fecha = Convert.ToString(Lectura[1]);
                int_Stock = Convert.ToInt32(Lectura[2]);
                str_Categoria = Convert.ToString(Lectura[3]);
                str_Precio = Convert.ToString(Lectura[4]);
                str_Especificaciones = Convert.ToString(Lectura[5]);   
            }
            objconect.connection.Close();
        }

        public String getNombre() { return str_Nombre; }
        public String getFecha() { return str_Fecha; }
        public int getStock() { return int_Stock; }
        public String getCategoria() { return str_Categoria; }
        public String getPrecio() { return str_Precio; }
        public String getEspecificaciones() { return str_Especificaciones; }
    }
}
   