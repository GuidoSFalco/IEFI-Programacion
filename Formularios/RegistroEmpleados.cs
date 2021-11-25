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

            dataGridView1.ColumnCount = 7;
            dataGridView1.Columns[0].HeaderText = "Nombre";
            dataGridView1.Columns[1].HeaderText = "Apellido";
            dataGridView1.Columns[2].HeaderText = "DNI";
            dataGridView1.Columns[3].HeaderText = "Telefono";
            dataGridView1.Columns[4].HeaderText = "Direccion";
            dataGridView1.Columns[5].HeaderText = "Genero";
            dataGridView1.Columns[6].HeaderText = "Area";


            dataGridView1.Columns[0].Width = 185;
            dataGridView1.Columns[1].Width = 60;
            dataGridView1.Columns[2].Width = 75;
            dataGridView1.Columns[3].Width = 75;
            dataGridView1.Columns[4].Width = 125;
            dataGridView1.Columns[5].Width = 75;
            dataGridView1.Columns[6].Width = 125;

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

            if (txtNombre.Text == "" || txtApellido.Text == "" || txtDni.Text == "" || txtDireccion.Text == "" || txtTelefono.Text == "" || genero == null || comboBox1 == null)
            {
                MessageBox.Show("Debe completar todos los campos para poder agregar un empleado", "Error");
            }
            else
            {
                int nAdd = -1;
                TxtObj();

                nAdd = objNegEmpleado.abmEmpleados("Alta", objEntEmpleado);
                if (nAdd == -1)
                {
                    MessageBox.Show("No pudo grabar el nuevo empleado en el sistema");
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
                MessageBox.Show("Debe completar todos los campos para poder agregar un empleado", "Error");
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
                    if (dr[5].ToString() == "M")
                    {
                        dr[5] = "Masculino";
                    }
                    if (dr[5].ToString() == "F")
                    {
                        dr[5] = "Femenino";
                    }
                    if (dr[5].ToString() == "O")
                    {
                        dr[5] = "Otro";
                    }
                    dataGridView1.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString());


                }
            }
            else
            {
                MessageBox.Show("No hay empleados cargados en el sistema", "Advertencia");
            }
        }

        private void TxtObj()
        {
            try
            {
            objEntEmpleado.Nombre = txtNombre.Text;
            objEntEmpleado.Apellido = txtApellido.Text;
            objEntEmpleado.Dni = Convert.ToInt32(txtDni.Text);
            objEntEmpleado.Direccion = txtDireccion.Text;
            objEntEmpleado.Telefono = Convert.ToInt32(txtTelefono.Text);
            objEntEmpleado.Area = comboBox1.Text;
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

            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
        }

        private void DGVaObj()
        {
            int pos = dataGridView1.CurrentRow.Index;
            objEntEmpleado.Nombre = (dataGridView1[0, pos].Value.ToString());

        }
        private void Limpiar()
        {
            txtNombre.Text = "Nombre";
            txtApellido.Text = "Apellido";
            txtDireccion.Text = "Direccion";
            txtDni.Text = "DNI";
            txtTelefono.Text = "Telefono";
            comboBox1.Text = "";
        }

        private void txtNombre_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "Nombre")
            {
                txtNombre.Text = "";
            }
        }

        private void txtApellido_Click(object sender, EventArgs e)
        {
            if (txtApellido.Text == "Apellido")
            {
                txtApellido.Text = "";
            }
        }

        private void txtDni_Click(object sender, EventArgs e)
        {
            if (txtDni.Text == "DNI")
            {
                txtDni.Text = "";
            }
        }

        private void txtTelefono_Click(object sender, EventArgs e)
        {
            if (txtTelefono.Text == "Telefono")
            {
                txtTelefono.Text = "";
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnModificar.Enabled = true;
            int pos = dataGridView1.CurrentRow.Index;
            if (dataGridView1[1, pos].Value == null)
            {
                MessageBox.Show("La fila debe contener datos");
            }
            else
            {

                txtNombre.Text = dataGridView1[0, pos].Value.ToString();
                txtApellido.Text = dataGridView1[1, pos].Value.ToString();
                txtDni.Text = dataGridView1[2, pos].Value.ToString();
                txtTelefono.Text = dataGridView1[3, pos].Value.ToString();
                txtDireccion.Text = dataGridView1[4, pos].Value.ToString();
                comboBox1.Text = dataGridView1[6, pos].Value.ToString();
                if (dataGridView1[5, pos].Value.ToString() == "Masculino")
                {
                    radioButtonM.Checked = true;
                }
                else if (dataGridView1[5, pos].Value.ToString() == "Femenino")
                {
                    radioButtonF.Checked = true;
                }
                else if(dataGridView1[5, pos].Value.ToString() == "Otro")
                {
                    radioButtonO.Checked = true;
                }

            }
        }

        private void txtDireccion_Click(object sender, EventArgs e)
        {
            if (txtDireccion.Text == "Direccion")
            {
                txtDireccion.Text = "";
            }
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            Form form = new RegistroClientes();
            form.Show();
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Error");
                e.Handled = true;
                return;
            }
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Error");
                e.Handled = true;
                return;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            {
                MessageBox.Show("No se permiten numeros", "Error");
                e.Handled = true;
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            {
                MessageBox.Show("No se permiten numeros", "Error");
                e.Handled = true;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "Nombre";
            txtApellido.Text = "Apellido";
            txtDni.Text = "DNI";
            txtDireccion.Text = "Direccion";
            txtTelefono.Text="Telefono";
            comboBox1.Text = "";

            btnModificar.Enabled=false;
        }
    }
}
