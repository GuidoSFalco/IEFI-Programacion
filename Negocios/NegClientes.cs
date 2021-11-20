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
    public class NegClientes
    {
        DatosClientes objDatosClientes = new DatosClientes();


        public int abmClientes(string accion, Cliente objCliente)
        {
            return objDatosClientes.abmClientes(accion, objCliente);
        }
        public DataSet listadoClientes(string todo)
        {
            return objDatosClientes.listadoClientes(todo);
        }
    }
}
