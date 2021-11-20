using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace ConexionBD
{
    public class BD
    {
        public OleDbConnection conexion;
        public string cadenaConexion = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Usuario\Documents\IEFIProgramacion.accdb";
        public BD()
        {
            conexion = new OleDbConnection(cadenaConexion);
        }

        public void Abrirconexion()
        {
            try
            {
                if (conexion.State == ConnectionState.Broken || conexion.State ==
                ConnectionState.Closed)
                    conexion.Open();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de abrir la conexión", e);
            }
        }

        public void Cerrarconexion()
        {
            try
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de cerrar la conexión", e);
            }
        }


        public void SaveCliente(string nomresp, int adultos, int menores, int habit, DateTime feching, DateTime fechfin)
        {
            Abrirconexion();
            OleDbCommand guardar = new OleDbCommand("insert into Alumnos values(@Responsable, @Adultos,@Menores,@Habitaciones,@FechaIng,@FechaFin)", conexion);

            try
            {

                guardar.Parameters.Clear();
                guardar.Parameters.AddWithValue("@Responsable", nomresp);
                guardar.Parameters.AddWithValue("@Adultos", adultos);
                guardar.Parameters.AddWithValue("@Menores", menores);
                guardar.Parameters.AddWithValue("@Habitaciones", habit);
                guardar.Parameters.AddWithValue("@FechaIng", feching);
                guardar.Parameters.AddWithValue("@FechaFin", fechfin);
                guardar.ExecuteNonQuery();


            }
            catch (Exception ez)
            {
                
                MessageBox.Show(ez.Message);
            }
            finally
            {
                Cerrarconexion();
            }
        }

        public void SaveEmpleado(string nombre, string apellido, int dni, int caract, int telefono, string direccion, string genero)
        {
            Abrirconexion();
            OleDbCommand guardar = new OleDbCommand("insert into Docente values(@Nombre, @Apellido,@DNI,@Telefono,@Direccion,@Genero)", conexion);

            try
            {

                guardar.Parameters.Clear();
                guardar.Parameters.AddWithValue("@Nombre", nombre);
                guardar.Parameters.AddWithValue("@Apellido", apellido);
                guardar.Parameters.AddWithValue("@DNI", dni);
                guardar.Parameters.AddWithValue("@Telefono", caract+telefono);
                guardar.Parameters.AddWithValue("@Direccion", direccion);
                guardar.Parameters.AddWithValue("@Genero", genero);
                guardar.ExecuteNonQuery();


            }
            catch (Exception ez)
            {

                MessageBox.Show(ez.Message);
            }
            finally
            {
                Cerrarconexion();
            }
        }

        public void Delete(string dni, DataGridView dgv, string cadenaA, string cadenaB)
        {
            Abrirconexion();

            if (cadenaA == "delete from Alumnos where Dni = (@Dni)")
            {
                OleDbCommand Borrar = new OleDbCommand(cadenaA, conexion);
                try
                {
                    int posicion = dgv.CurrentRow.Index;
                    Borrar.Parameters.Clear();
                    Borrar.Parameters.AddWithValue("@Dni", dgv[1, posicion].Value.ToString());
                    Borrar.ExecuteNonQuery();
                }
                catch (Exception ez)
                {
                    MessageBox.Show(ez.Message);
                }
                finally
                {
                    conexion.Close();
                }
            }
            else
            {
                OleDbCommand Borrar = new OleDbCommand(cadenaB, conexion);
                try
                {
                    int posicion = dgv.CurrentRow.Index;
                    Borrar.Parameters.Clear();
                    Borrar.Parameters.AddWithValue("@Dni", dgv[1, posicion].Value.ToString());
                    Borrar.ExecuteNonQuery();
                }
                catch (Exception ez)
                {
                    MessageBox.Show(ez.Message);
                }
                finally
                {
                    conexion.Close();
                }
            }

        }
    }
}
