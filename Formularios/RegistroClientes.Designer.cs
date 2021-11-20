
namespace Formularios
{
    partial class RegistroClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnReservar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dateTimeFin = new System.Windows.Forms.DateTimePicker();
            this.dateTimeIng = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnFormEmpleados = new System.Windows.Forms.Button();
            this.txtResponsable = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Adultos = new System.Windows.Forms.NumericUpDown();
            this.Menores = new System.Windows.Forms.NumericUpDown();
            this.Habitaciones = new System.Windows.Forms.NumericUpDown();
            this.lblError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Adultos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Menores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Habitaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(163, 233);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(614, 287);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnReservar
            // 
            this.btnReservar.Location = new System.Drawing.Point(163, 194);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(75, 23);
            this.btnReservar.TabIndex = 1;
            this.btnReservar.Text = "Reservar";
            this.btnReservar.UseVisualStyleBackColor = true;
            this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(318, 194);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(465, 194);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // dateTimeFin
            // 
            this.dateTimeFin.Location = new System.Drawing.Point(577, 70);
            this.dateTimeFin.Name = "dateTimeFin";
            this.dateTimeFin.Size = new System.Drawing.Size(200, 20);
            this.dateTimeFin.TabIndex = 4;
            // 
            // dateTimeIng
            // 
            this.dateTimeIng.Location = new System.Drawing.Point(577, 44);
            this.dateTimeIng.Name = "dateTimeIng";
            this.dateTimeIng.Size = new System.Drawing.Size(200, 20);
            this.dateTimeIng.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Adultos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Menores:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Habitaciones";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(452, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Fecha de Salida";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(450, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Fecha de Ingreso";
            // 
            // btnFormEmpleados
            // 
            this.btnFormEmpleados.Location = new System.Drawing.Point(12, 194);
            this.btnFormEmpleados.Name = "btnFormEmpleados";
            this.btnFormEmpleados.Size = new System.Drawing.Size(75, 23);
            this.btnFormEmpleados.TabIndex = 15;
            this.btnFormEmpleados.Text = "Empleados";
            this.btnFormEmpleados.UseVisualStyleBackColor = true;
            this.btnFormEmpleados.Click += new System.EventHandler(this.btnFormEmpleados_Click);
            // 
            // txtResponsable
            // 
            this.txtResponsable.Location = new System.Drawing.Point(150, 21);
            this.txtResponsable.Name = "txtResponsable";
            this.txtResponsable.Size = new System.Drawing.Size(170, 20);
            this.txtResponsable.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Nombre responsable:";
            // 
            // Adultos
            // 
            this.Adultos.Location = new System.Drawing.Point(150, 48);
            this.Adultos.Name = "Adultos";
            this.Adultos.Size = new System.Drawing.Size(43, 20);
            this.Adultos.TabIndex = 18;
            // 
            // Menores
            // 
            this.Menores.Location = new System.Drawing.Point(150, 74);
            this.Menores.Name = "Menores";
            this.Menores.Size = new System.Drawing.Size(43, 20);
            this.Menores.TabIndex = 19;
            // 
            // Habitaciones
            // 
            this.Habitaciones.Location = new System.Drawing.Point(150, 100);
            this.Habitaciones.Name = "Habitaciones";
            this.Habitaciones.Size = new System.Drawing.Size(43, 20);
            this.Habitaciones.TabIndex = 20;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(12, 163);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 21;
            // 
            // RegistroClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 532);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.Habitaciones);
            this.Controls.Add(this.Menores);
            this.Controls.Add(this.Adultos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtResponsable);
            this.Controls.Add(this.btnFormEmpleados);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimeIng);
            this.Controls.Add(this.dateTimeFin);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnReservar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "RegistroClientes";
            this.Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Adultos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Menores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Habitaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DateTimePicker dateTimeFin;
        private System.Windows.Forms.DateTimePicker dateTimeIng;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnFormEmpleados;
        private System.Windows.Forms.TextBox txtResponsable;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown Adultos;
        private System.Windows.Forms.NumericUpDown Menores;
        private System.Windows.Forms.NumericUpDown Habitaciones;
        private System.Windows.Forms.Label lblError;
    }
}