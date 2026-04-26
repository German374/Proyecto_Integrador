using System.Data;
using DataAcces;

namespace BusinessLogic
{
    public class LogicaMedicion
    {
        DatosMedicion datos = new DatosMedicion();

        public void InsertarMedicion(double valor, int idSensor)
        {
            datos.InsertarMedicion(valor, idSensor);
        }

        public DataTable MostrarMedicion()
        {
            return datos.MostrarMedicion();
        }
    }
}
