using System.Data;
using DataAcces;

namespace BusinessLogic
{
    public class LogicaAula
    {
        Conexion con = new Conexion();

        public DataTable MostrarAula()
        {
            return con.MostrarAula();
        }
        

        public void InsertarAula(string nombre, string ubicacion)
        {
            con.InsertarAula(nombre, ubicacion);
        }

        public void EditarAula(int idAula, string nombre, string ubicacion)
        {
            con.EditarAula(idAula, nombre, ubicacion);
        }

        public void EliminarAula(int idAula)
        {
            con.EliminarAula(idAula);
        }
    }
}
