using System.Data;
using System.Data.SqlClient;

namespace DataAcces
{
    public class Conexion
    {
        private string cadena = @"Server=DESKTOP-A2HL4RA\SQLDEVELOPER;Database=Proyecto_Integrador;Trusted_Connection=True;TrustServerCertificate=True;";

        public SqlConnection Conectar()
        {
            return new SqlConnection(cadena);
        }

        // AULA 

        public DataTable MostrarAula()
        {
            SqlConnection cn = Conectar();
            string query = "SELECT * FROM AULA";

            SqlDataAdapter da = new SqlDataAdapter(query, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public void InsertarAula(string nombre, string ubicacion)
        {
            SqlConnection cn = Conectar();
            cn.Open();

            string query = "INSERT INTO AULA (nombre, ubicacion) VALUES (@nombre, @ubicacion)";
            SqlCommand cmd = new SqlCommand(query, cn);

            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Parameters.AddWithValue("@ubicacion", ubicacion);

            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public void EditarAula(int idAula, string nombre, string ubicacion)
        {
            SqlConnection cn = Conectar();
            cn.Open();

            string query = "UPDATE AULA SET nombre=@nombre, ubicacion=@ubicacion WHERE idAula=@id";
            SqlCommand cmd = new SqlCommand(query, cn);

            cmd.Parameters.AddWithValue("@id", idAula);
            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Parameters.AddWithValue("@ubicacion", ubicacion);

            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public void EliminarAula(int idAula)
        {
            SqlConnection cn = Conectar();
            cn.Open();

            string query1 = "DELETE FROM SENSOR WHERE idAula=@id";
            SqlCommand cmd1 = new SqlCommand(query1, cn);
            cmd1.Parameters.AddWithValue("@id", idAula);
            cmd1.ExecuteNonQuery();

            string query2 = "DELETE FROM AULA WHERE idAula=@id";
            SqlCommand cmd2 = new SqlCommand(query2, cn);
            cmd2.Parameters.AddWithValue("@id", idAula);
            cmd2.ExecuteNonQuery();

            cn.Close();
        }
        // TIPO_SENSOR 

        public DataTable MostrarTipoSensor()
        {
            SqlConnection cn = Conectar();

            string query = @"SELECT 
                        idTipo,
                        nombre + ' - ' + variable + ' (' + unidad + ')' AS descripcion
                     FROM TIPO_SENSOR";

            SqlDataAdapter da = new SqlDataAdapter(query, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public void InsertarTipoSensor(string nombre, string variable, string unidad)
        {
            SqlConnection cn = Conectar();
            cn.Open();

            string query = "INSERT INTO TIPO_SENSOR (nombre, variable, unidad) VALUES (@nombre, @variable, @unidad)";
            SqlCommand cmd = new SqlCommand(query, cn);

            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Parameters.AddWithValue("@variable", variable);
            cmd.Parameters.AddWithValue("@unidad", unidad);

            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public void EditarTipoSensor(int idTipo, string nombre, string variable, string unidad)
        {
            SqlConnection cn = Conectar();
            cn.Open();

            string query = "UPDATE TIPO_SENSOR SET nombre=@nombre, variable=@variable, unidad=@unidad WHERE idTipo=@id";
            SqlCommand cmd = new SqlCommand(query, cn);

            cmd.Parameters.AddWithValue("@id", idTipo);
            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Parameters.AddWithValue("@variable", variable);
            cmd.Parameters.AddWithValue("@unidad", unidad);

            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public void EliminarTipoSensor(int idTipo)
        {
            SqlConnection cn = Conectar();
            cn.Open();

            string query0 = @"DELETE FROM MEDICION 
                      WHERE idSensor IN (
                          SELECT idSensor FROM SENSOR WHERE idTipo=@id
                      )";
            SqlCommand cmd0 = new SqlCommand(query0, cn);
            cmd0.Parameters.AddWithValue("@id", idTipo);
            cmd0.ExecuteNonQuery();

            string query1 = "DELETE FROM SENSOR WHERE idTipo=@id";
            SqlCommand cmd1 = new SqlCommand(query1, cn);
            cmd1.Parameters.AddWithValue("@id", idTipo);
            cmd1.ExecuteNonQuery();

            string query2 = "DELETE FROM TIPO_SENSOR WHERE idTipo=@id";
            SqlCommand cmd2 = new SqlCommand(query2, cn);
            cmd2.Parameters.AddWithValue("@id", idTipo);
            cmd2.ExecuteNonQuery();

            cn.Close();
        }
        // ----SENSOR--

        public DataTable MostrarSensor()
        {
            SqlConnection cn = Conectar();

            string query = @"SELECT s.idSensor, a.nombre AS Aula, t.nombre AS TipoSensor
                     FROM SENSOR s
                     INNER JOIN AULA a ON s.idAula = a.idAula
                     INNER JOIN TIPO_SENSOR t ON s.idTipo = t.idTipo";

            SqlDataAdapter da = new SqlDataAdapter(query, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public void InsertarSensor(int idAula, int idTipo)
        {
            SqlConnection cn = Conectar();
            cn.Open();

            string query = "INSERT INTO SENSOR (idAula, idTipo) VALUES (@idAula, @idTipo)";
            SqlCommand cmd = new SqlCommand(query, cn);

            cmd.Parameters.AddWithValue("@idAula", idAula);
            cmd.Parameters.AddWithValue("@idTipo", idTipo);

            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public void EliminarSensor(int idSensor)
        {
            SqlConnection cn = Conectar();
            cn.Open();

            string query = "DELETE FROM SENSOR WHERE idSensor=@id";
            SqlCommand cmd = new SqlCommand(query, cn);

            cmd.Parameters.AddWithValue("@id", idSensor);

            cmd.ExecuteNonQuery();
            cn.Close();
        }
    }
}
