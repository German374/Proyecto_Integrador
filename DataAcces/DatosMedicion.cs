using System;
using System.Data;
using System.Data.SqlClient;

namespace DataAcces
{
    public class DatosMedicion
    {
        Conexion conexion = new Conexion();

        public void InsertarMedicion(double valor, int idSensor)
        {
            SqlConnection cn = conexion.Conectar();
            cn.Open();

            string query = "INSERT INTO Medicion (valor, fecha, hora, idSensor) VALUES (@valor, GETDATE(), GETDATE(), @idSensor)";

            SqlCommand cmd = new SqlCommand(query, cn);
            cmd.Parameters.AddWithValue("@valor", valor);
            cmd.Parameters.AddWithValue("@idSensor", idSensor);

            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public DataTable MostrarMedicion()
        {
            SqlConnection cn = conexion.Conectar();

            string query = @"SELECT 
                        m.idMedicion,
                        t.nombre AS Sensor,
                        t.variable AS Variable,
                        m.valor AS Valor,
                        t.unidad AS Unidad,
                        m.fecha AS Fecha,
                        m.hora AS Hora
                     FROM MEDICION m
                     INNER JOIN SENSOR s ON m.idSensor = s.idSensor
                     INNER JOIN TIPO_SENSOR t ON s.idTipo = t.idTipo
                     ORDER BY m.idMedicion DESC";

            SqlDataAdapter da = new SqlDataAdapter(query, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
    }
}