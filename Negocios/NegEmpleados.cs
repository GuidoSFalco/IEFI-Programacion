using ConexionBD;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class NegEmpleados
    {
        DatosEmpleados objDatosEmpleados = new DatosEmpleados();


        public int abmEmpleados(string accion, Empleado objEmpleado)
        {
            return objDatosEmpleados.abmEmpleados(accion, objEmpleado);
        }
        public DataSet listadoEmpleados(string todo)

        {
            return objDatosEmpleados.listadoEmpleados(todo);
        }
    }
}
