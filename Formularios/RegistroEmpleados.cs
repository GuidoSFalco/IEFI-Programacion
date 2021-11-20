using Entidades;
using Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class RegistroEmpleados : Form
    {
        public RegistroEmpleados()
        {
            InitializeComponent();

            dataGridView1.ColumnCount = 6;
            dataGridView1.Columns[0].HeaderText = "Responsable";
            dataGridView1.Columns[1].HeaderText = "Adultos";
            dataGridView1.Columns[2].HeaderText = "Menores";
            dataGridView1.Columns[3].HeaderText = "Habitaciones";
            dataGridView1.Columns[4].HeaderText = "Fecha Ingreso";
            dataGridView1.Columns[5].HeaderText = "Fecha Salida";


            dataGridView1.Columns[0].Width = 200;
            dataGridView1.Columns[1].Width = 60;
            dataGridView1.Columns[2].Width = 75;
            dataGridView1.Columns[3].Width = 75;
            dataGridView1.Columns[4].Width = 75;
            dataGridView1.Columns[5].Width = 75;

            FillDGV();
        }
        public Empleado objEntEmpleado = new Empleado();
        public NegEmpleados objNegEmpleado = new NegEmpleados();
        string genero;

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (radioButtonM.Checked == true)
            {
                genero = "Masculino";
                objEntEmpleado.Genero = "Masculino";
            }

            if (radioButtonF.Checked == true)
            {
                genero = "Femenino";
                objEntEmpleado.Genero = "Femenino";

            }

            if (radioButtonO.Checked == true)
            {
                genero = "Otro";
                objEntEmpleado.Genero = "Otro";
            }

            if (txtNombre.Text == "" || txtApellido.Text == "" || txtDni.Text == "" || txtDireccion.Text == "" || txtTelefono.Text == "" || comboBox1.Text == "")
            {
                MessageBox.Show("Debe completar todos los campos para poder agregar un alumno", "Error");
            }
            else
            {
                int nAdd = -1;
                TxtObj();

                nAdd = objNegEmpleado.abmEmpleados("Alta", objEntEmpleado);
                if (nAdd == -1)
                {
                    MessageBox.Show("No pudo grabar el alumno en el sistema");
                }
                else
                {
                    FillDGV();
                    Limpiar();
                }

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count.Equals(0))
            {
                MessageBox.Show("No se pueden borrar mas filas", "Error en la tabla");
            }
            else
            {

                int nDel = -1;
                DGVaObj();
                nDel = objNegEmpleado.abmEmpleados("Baja", objEntEmpleado);
                if (nDel == -1)
                {
                    MessageBox.Show("No se pudo borrar", "Error");
                }
                else
                {
                    FillDGV();
                    Limpiar();
                }


            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            if (objEntEmpleado.Nombre == "")
            {
                MessageBox.Show("Debe completar todos los campos para poder agregar un alumno", "Error");
            }
            else
            {
                int nAdd = -1;
                TxtObj();

                nAdd = objNegEmpleado.abmEmpleados("Modificar", objEntEmpleado);
                if (nAdd == -1)
                {
                    MessageBox.Show("No pudo grabar alumnos en el sistema");
                }
                else
                {
                    FillDGV();
                    Limpiar();
                }

            }
            btnEliminar.Enabled = false;
            btnRegistrar.Enabled = true;
            btnModificar.Enabled = false;

        }

        private void FillDGV()
        {
            dataGridView1.Rows.Clear();
            DataSet ds = new DataSet();
            ds = objNegEmpleado.listadoEmpleados("Todos");
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {

                    dataGridView1.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), Convert.ToDateTime(dr[4]).ToShortDateString(), Convert.ToDateTime(dr[5]).ToShortDateString());


                }
            }
            else
            {
                MessageBox.Show("No hay alumnos cargados en el sistema", "Error");
            }
        }

        private void TxtObj()
        {
            objEntEmpleado.Nombre = txtNombre.Text;
            objEntEmpleado.Apellido = txtApellido.Text;
            objEntEmpleado.Dni = Convert.ToInt32(txtDni.Text);
            objEntEmpleado.Direccion = txtDireccion.Text;
            objEntEmpleado.Caract = Convert.ToInt32(comboBox1.Text);
            objEntEmpleado.Telefono = Convert.ToInt32(txtTelefono.Text);
            objEntEmpleado.Genero = genero;
        }

        private void DGVaObj()
        {
            int pos = dataGridView1.CurrentRow.Index;
            objEntEmpleado.Nombre = (dataGridView1[0, pos].Value.ToString());

        }
        private void Limpiar()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtDireccion.Clear();
            txtDni.Clear();
            txtTelefono.Clear();
            comboBox1.Text = "";
        }
    }
}
