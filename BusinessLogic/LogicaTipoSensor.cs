using System.Data;
using DataAcces;

namespace BusinessLogic
{
    public class LogicaTipoSensor
    {
        Conexion con = new Conexion();

        public DataTable MostrarTipoSensor()
        {
            return con.MostrarTipoSensor();
        }

        public void InsertarTipoSensor(string nombre, string variable, string unidad)
        {
            con.InsertarTipoSensor(nombre, variable, unidad);
        }

        public void EditarTipoSensor(int idTipo, string nombre, string variable, string unidad)
        {
            con.EditarTipoSensor(idTipo, nombre, variable, unidad);
        }

        public void EliminarTipoSensor(int idTipo)
        {
            con.EliminarTipoSensor(idTipo);
        }
    }
}
