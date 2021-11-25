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
    public class DatosEmpleados : BD
    {
        public int abmEmpleados(string accion, Empleado objEmpleado)
        {
            int resultado = -1;
            string orden = string.Empty;
            if (accion == "Alta")
            {
                
                orden = "Insert into Empleados values (@Nombre, @Apellido,@DNI,@Telefono,@Direccion,@Genero,@Area);";
                OleDbCommand cmd = new OleDbCommand(orden, conexion);
                try
                {

                    Abrirconexion();
                    cmd.Parameters.AddWithValue("@Nombre", objEmpleado.Nombre);
                    cmd.Parameters.AddWithValue("@Apellido", objEmpleado.Apellido);
                    cmd.Parameters.AddWithValue("@DNI", objEmpleado.Dni);
                    cmd.Parameters.AddWithValue("@Telefono", objEmpleado.Telefono);
                    cmd.Parameters.AddWithValue("@Direccion", objEmpleado.Direccion);
                    cmd.Parameters.AddWithValue("@Genero", objEmpleado.Genero);
                    cmd.Parameters.AddWithValue("@Area", objEmpleado.Area);
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
                orden = "delete from Empleados where Nombre ='" + objEmpleado.Nombre.ToString() + "';";
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

                orden = "Update Empleados set Nombre = @Nombre, Apellido = @Apellido,DNI = @DNI, Telefono= @Telefono, Direccion=@Direccion,Genero=@Genero,Area=@Area where DNI = @DNI";
                OleDbCommand cmd = new OleDbCommand(orden, conexion);
                try
                {
                    Abrirconexion();
                    cmd.Parameters.AddWithValue("@Nombre", objEmpleado.Nombre);
                    cmd.Parameters.AddWithValue("@Apellido", objEmpleado.Apellido);
                    cmd.Parameters.AddWithValue("@DNI", objEmpleado.Dni);
                    cmd.Parameters.AddWithValue("@Telefono", objEmpleado.Telefono);
                    cmd.Parameters.AddWithValue("@Direccion", objEmpleado.Direccion);
                    cmd.Parameters.AddWithValue("@Genero", objEmpleado.Genero);
                    cmd.Parameters.AddWithValue("@Area", objEmpleado.Area);

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

        public DataSet listadoEmpleados(string todos)
        {
            string orden = string.Empty;
            orden = "select * from Empleados;";
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

                throw new Exception("Error al listar Empleados", e);
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
