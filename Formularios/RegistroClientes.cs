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
    public partial class RegistroClientes : Form
    {
        public RegistroClientes()
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

        

        private void btnFormEmpleados_Click(object sender, EventArgs e)
        {
            Form form = new RegistroEmpleados();
            form.Show();
        }

        public Cliente objEntCliente = new Cliente();
        public NegClientes objNegCliente = new NegClientes();






        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 1)
            {
                MessageBox.Show("No existen datos para modificar","Error");
            }
            else
            {

            if (objEntCliente.NombResponsable == "")
            {
                MessageBox.Show("Debe completar todos los campos para poder agregar un cliente", "Error");
            }
            else
            {
                int nAdd = -1;
                TxtObj();

                nAdd = objNegCliente.abmClientes("Modificar", objEntCliente);
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
            btnEliminar.Enabled = false;
            btnReservar.Enabled = true;
            btnModificar.Enabled = false;

        }




        

        private void FillDGV()
        {
            dataGridView1.Rows.Clear();
            DataSet ds = new DataSet();
            ds = objNegCliente.listadoClientes("Todos");
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    
                    dataGridView1.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), Convert.ToDateTime(dr[4]).ToShortDateString(), Convert.ToDateTime(dr[5]).ToShortDateString());


                }
            }
        }


        private void TxtObj()
        {
            objEntCliente.NombResponsable = txtResponsable.Text;
            objEntCliente.Adultos = Convert.ToInt32(Adultos.Value);
            objEntCliente.Menores = Convert.ToInt32(Menores.Value);
            objEntCliente.Habitaciones = Convert.ToInt32(Habitaciones.Value);
            objEntCliente.FechIng = dateTimeIng.Value;
            objEntCliente.FechFin = dateTimeFin.Value;
        }

        private void DGVaObj()
        {
            try
            {
            int pos = dataGridView1.CurrentRow.Index;
            objEntCliente.NombResponsable = (dataGridView1[0, pos].Value.ToString());

            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }

        }

        private void Limpiar()
        {
            txtResponsable.Clear();
            Adultos.Value = 0;
            Menores.Value = 0;
            Habitaciones.Value = 0;

        }


        

        private void btnReservar_Click(object sender, EventArgs e)
        {
            if (txtResponsable.Text == "" ||  Habitaciones.Value == 0)
            {
                MessageBox.Show("Debe registrar el nombre del responsable y al menos una habitacion", "Error");
            }
            if (Adultos.Value == 0 && Menores.Value == 0)
            {
                MessageBox.Show("Debe registrar al menos un adulto o un menor incluyendolo","Error");
            }
            else
            {
                int nAdd = -1;
                TxtObj();

                nAdd = objNegCliente.abmClientes("Alta", objEntCliente);
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

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count.Equals(0))
            {
                MessageBox.Show("No se pueden borrar mas filas", "Error en la tabla");
            }
            else
            {

                int nDel = -1;
                DGVaObj();
                nDel = objNegCliente.abmClientes("Baja", objEntCliente);
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

        private void txtResponsable_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            {
                MessageBox.Show("No se permiten numeros", "Error");
                e.Handled = true;
            }
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            if (txtResponsable.Text == "" || Habitaciones.Value == 0)
            {
                MessageBox.Show("Debe registrar el nombre del responsable y al menos una habitacion", "Error");
            }
            if (Adultos.Value == 0 && Menores.Value == 0)
            {
                MessageBox.Show("Debe registrar al menos un adulto o un menor incluyendolo", "Error");
            }
            else
            {

            if (objEntCliente.NombResponsable == "")
            {
                MessageBox.Show("Debe completar todos los campos para poder agregar un cliente", "Error");
            }
            else
            {
                int nAdd = -1;
                TxtObj();

                nAdd = objNegCliente.abmClientes("Modificar", objEntCliente);
                if (nAdd == -1)
                {
                    MessageBox.Show("No pudo grabar cliente en el sistema");
                }
                else
                {
                    FillDGV();
                    Limpiar();
                }

            }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int pos = dataGridView1.CurrentRow.Index;
            if (dataGridView1[1, pos].Value == null)
            {
                MessageBox.Show("La fila debe contener datos");
            }
            else
            {

                txtResponsable.Text = dataGridView1[0, pos].Value.ToString();
                Adultos.Text = dataGridView1[1, pos].Value.ToString();
                Menores.Text = dataGridView1[2, pos].Value.ToString();
                Habitaciones.Text = dataGridView1[3, pos].Value.ToString();
                dateTimeIng.Value = System.Convert.ToDateTime(dataGridView1[4, pos].Value);
                dateTimeFin.Value = System.Convert.ToDateTime(dataGridView1[5, pos].Value);


            }
        }
    }
}
