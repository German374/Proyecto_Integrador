using DataAcces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BusinessLogic
{
    public class LogicaSensor
    {
        Conexion con = new Conexion();

        public DataTable MostrarSensor()
        {
            return con.MostrarSensor();
        }

        public void InsertarSensor(int idAula, int idTipo)
        {
            con.InsertarSensor(idAula, idTipo);
        }

        public void EliminarSensor(int idSensor)
        {
            con.EliminarSensor(idSensor);
        }
    }
}
