using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConexionBD
{
    public class DatosClientes : BD
    {
        public int abmClientes(string accion, Cliente objCliente)
        {
            int resultado = -1;
            string orden = string.Empty;
            if (accion == "Alta")
            {
                orden = "Insert into Clientes values (@Responsable, @Adultos,@Menores,@Habitaciones,@FechaIng,@FechaFin);";
                OleDbCommand cmd = new OleDbCommand(orden, conexion);
                try
                {

                    Abrirconexion();
                    cmd.Parameters.AddWithValue("@Responsable", objCliente.NombResponsable);
                    cmd.Parameters.AddWithValue("@Adultos", objCliente.Adultos);
                    cmd.Parameters.AddWithValue("@Menores", objCliente.Menores);
                    cmd.Parameters.AddWithValue("@Habitaciones", objCliente.Habitaciones);
                    cmd.Parameters.AddWithValue("@FechaIng", objCliente.FechIng);
                    cmd.Parameters.AddWithValue("@FechaFin", objCliente.FechFin);
                    resultado = cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {

                    MessageBox.Show(e.Message);
                }
                finally
                {
                    Cerrarconexion();
                    cmd.Dispose();
                }
            }
            if (accion == "Baja")
            {
                orden = "delete from Clientes where Responsable ='" + objCliente.NombResponsable.ToString() + "';";
                OleDbCommand cmd = new OleDbCommand(orden, conexion);
                try
                {
                    Abrirconexion();
                    resultado = cmd.ExecuteNonQuery();
                }
                catch (Exception ez)
                {

                    MessageBox.Show(ez.Message);
                }
                finally
                {
                    Cerrarconexion();
                    cmd.Dispose();
                }
            }
            if (accion == "Modificar")
            {

                orden = "Update Clientes set Responsable = @Responsable, Adultos = @Adultos, Menores= @Menores, Habitaciones= @Habitaciones, FechaIng=@FechaIng,FechaFin=@FechaFin where Responsable = @Responsable";
                OleDbCommand cmd = new OleDbCommand(orden, conexion);
                try
                {
                    Abrirconexion();
                    cmd.Parameters.AddWithValue("@Responsable", objCliente.NombResponsable);
                    cmd.Parameters.AddWithValue("@Adultos", objCliente.Adultos);
                    cmd.Parameters.AddWithValue("@Menores", objCliente.Menores);
                    cmd.Parameters.AddWithValue("@Habitaciones", objCliente.Habitaciones);
                    cmd.Parameters.AddWithValue("@FechaIng", objCliente.FechIng);
                    cmd.Parameters.AddWithValue("@FechaFin", objCliente.FechFin);

                    resultado = cmd.ExecuteNonQuery();
                }
                catch (Exception ez)
                {

                    MessageBox.Show(ez.Message);
                }
                finally
                {
                    Cerrarconexion();
                    cmd.Dispose();
                }
            }


            return resultado;
        }

        public DataSet listadoClientes(string todos)
        {
            string orden = string.Empty;
            orden = "select * from Clientes;";
            OleDbCommand cmd = new OleDbCommand(orden, conexion);
            DataSet ds = new DataSet();
            OleDbDataAdapter da = new OleDbDataAdapter();
            try
            {
                Abrirconexion();
                cmd.ExecuteNonQuery();
                da.SelectCommand = cmd;
                da.Fill(ds);
            }
            catch (Exception e)
            {

                throw new Exception("Error al listar Clientes", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return ds;
        }
    }
}
