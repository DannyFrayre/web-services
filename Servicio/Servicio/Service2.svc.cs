 using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.SqlClient;

namespace Servicio
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service2" en el código, en svc y en el archivo de configuración a la vez.
    public class Service2 : IService2
    {
        public void guardar (string nom, int c1, int c2, int c3, int c4, int c5)
        {
            SqlConnection con;
            SqlCommand cmd;
            string cadena = "";
            con = new SqlConnection("Data Source= DESKTOP-882OB3B; Initial Catalog=calificaciones;Integrated Security=false;user=danny;password=sanchez");
            con.Open();
            cadena = "insert into calificaciones1 values('" + nom + "','" + c1 + "','" + c2 + "','" + c3 + "','" + c4 + "','" + c5 + "')";
            cmd = new SqlCommand(cadena, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public string[] buscar(string nom)
        {
            SqlConnection con;
            SqlCommand cmd;
            SqlDataReader dato;
            string cadena = "";
            string [] datos = new string[6];
            con = new SqlConnection("Data Source= DESKTOP-882OB3B; Initial Catalog=calificaciones;Integrated Security=false;user=danny;password=sanchez");
            con.Open();
            cadena = "select * from calificaciones1 where Nombre='" + nom + "'";
            cmd = new SqlCommand(cadena, con);
            dato = cmd.ExecuteReader();
            if (dato.Read())
            {
                datos[0] = dato.GetString(0);
                datos[1] = dato.GetInt32(1).ToString();
                datos[2] = dato.GetInt32(2).ToString();
                datos[3] = dato.GetInt32(3).ToString();
                datos[4] = dato.GetInt32(4).ToString();
                datos[5] = dato.GetInt32(5).ToString();
            }
            con.Close();
            return datos;
        }
        public float promedio(float c1, float c2, float c3, float c4, float c5)
        {
            float r;
            return r = (c1 + c2 + c3 + c4 + c5) / 5;
        }


    }
   
}
