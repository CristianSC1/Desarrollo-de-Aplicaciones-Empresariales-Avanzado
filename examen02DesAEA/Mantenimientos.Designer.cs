﻿namespace Mantenimiento_Ventas
{
    partial class Mantenimientos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.operacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.medicinasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTiposPago = new System.Windows.Forms.ToolStripMenuItem();
            this.hospitalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantHospitalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagarConsultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbHospital = new System.Windows.Forms.ComboBox();
            this.btnEnfermeras = new System.Windows.Forms.Button();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.btnMedicos = new System.Windows.Forms.Button();
            this.btnPaciente = new System.Windows.Forms.Button();
            this.btnConsultorio = new System.Windows.Forms.Button();
            this.btnTriaje = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operacionesToolStripMenuItem,
            this.mantHospitalesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(835, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // operacionesToolStripMenuItem
            // 
            this.operacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuProveedores,
            this.medicinasToolStripMenuItem,
            this.menuTiposPago,
            this.hospitalesToolStripMenuItem});
            this.operacionesToolStripMenuItem.Name = "operacionesToolStripMenuItem";
            this.operacionesToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.operacionesToolStripMenuItem.Text = "Mant. Generales";
            // 
            // menuProveedores
            // 
            this.menuProveedores.Name = "menuProveedores";
            this.menuProveedores.Size = new System.Drawing.Size(180, 22);
            this.menuProveedores.Text = "Proveedores";
            this.menuProveedores.Click += new System.EventHandler(this.menuProveedores_Click);
            // 
            // medicinasToolStripMenuItem
            // 
            this.medicinasToolStripMenuItem.Name = "medicinasToolStripMenuItem";
            this.medicinasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.medicinasToolStripMenuItem.Text = "Medicinas";
            this.medicinasToolStripMenuItem.Click += new System.EventHandler(this.medicinasToolStripMenuItem_Click);
            // 
            // menuTiposPago
            // 
            this.menuTiposPago.Name = "menuTiposPago";
            this.menuTiposPago.Size = new System.Drawing.Size(180, 22);
            this.menuTiposPago.Text = "Tipos de pagos";
            this.menuTiposPago.Click += new System.EventHandler(this.menuTiposPago_Click);
            // 
            // hospitalesToolStripMenuItem
            // 
            this.hospitalesToolStripMenuItem.Name = "hospitalesToolStripMenuItem";
            this.hospitalesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hospitalesToolStripMenuItem.Text = "Hospitales";
            this.hospitalesToolStripMenuItem.Click += new System.EventHandler(this.hospitalesToolStripMenuItem_Click);
            // 
            // mantHospitalesToolStripMenuItem
            // 
            this.mantHospitalesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pagarConsultaToolStripMenuItem});
            this.mantHospitalesToolStripMenuItem.Name = "mantHospitalesToolStripMenuItem";
            this.mantHospitalesToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.mantHospitalesToolStripMenuItem.Text = "Operaciones";
            // 
            // pagarConsultaToolStripMenuItem
            // 
            this.pagarConsultaToolStripMenuItem.Name = "pagarConsultaToolStripMenuItem";
            this.pagarConsultaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pagarConsultaToolStripMenuItem.Text = "Pagar Consulta";
            this.pagarConsultaToolStripMenuItem.Click += new System.EventHandler(this.pagarConsultaToolStripMenuItem_Click);
            // 
            // cmbHospital
            // 
            this.cmbHospital.DropDownHeight = 100;
            this.cmbHospital.FormattingEnabled = true;
            this.cmbHospital.IntegralHeight = false;
            this.cmbHospital.Location = new System.Drawing.Point(88, 31);
            this.cmbHospital.Name = "cmbHospital";
            this.cmbHospital.Size = new System.Drawing.Size(146, 21);
            this.cmbHospital.TabIndex = 7;
            this.cmbHospital.SelectedValueChanged += new System.EventHandler(this.cmbHospital_SelectedValueChanged);
            // 
            // btnEnfermeras
            // 
            this.btnEnfermeras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEnfermeras.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnfermeras.Location = new System.Drawing.Point(367, 26);
            this.btnEnfermeras.Name = "btnEnfermeras";
            this.btnEnfermeras.Size = new System.Drawing.Size(393, 47);
            this.btnEnfermeras.TabIndex = 1;
            this.btnEnfermeras.Text = "ENFERMERAS";
            this.btnEnfermeras.UseVisualStyleBackColor = false;
            this.btnEnfermeras.Click += new System.EventHandler(this.btnEnfermeras_Click);
            // 
            // btnConsulta
            // 
            this.btnConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnConsulta.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsulta.Location = new System.Drawing.Point(8, 132);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(332, 47);
            this.btnConsulta.TabIndex = 2;
            this.btnConsulta.Text = "CONSULTAS";
            this.btnConsulta.UseVisualStyleBackColor = false;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // btnMedicos
            // 
            this.btnMedicos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnMedicos.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedicos.Location = new System.Drawing.Point(8, 26);
            this.btnMedicos.Name = "btnMedicos";
            this.btnMedicos.Size = new System.Drawing.Size(332, 47);
            this.btnMedicos.TabIndex = 3;
            this.btnMedicos.Text = "MÉDICOS";
            this.btnMedicos.UseVisualStyleBackColor = false;
            this.btnMedicos.Click += new System.EventHandler(this.btnMedicos_Click);
            // 
            // btnPaciente
            // 
            this.btnPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnPaciente.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaciente.Location = new System.Drawing.Point(8, 79);
            this.btnPaciente.Name = "btnPaciente";
            this.btnPaciente.Size = new System.Drawing.Size(332, 47);
            this.btnPaciente.TabIndex = 4;
            this.btnPaciente.Text = "PACIENTES";
            this.btnPaciente.UseVisualStyleBackColor = false;
            this.btnPaciente.Click += new System.EventHandler(this.btnPaciente_Click);
            // 
            // btnConsultorio
            // 
            this.btnConsultorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnConsultorio.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultorio.Location = new System.Drawing.Point(367, 132);
            this.btnConsultorio.Name = "btnConsultorio";
            this.btnConsultorio.Size = new System.Drawing.Size(393, 47);
            this.btnConsultorio.TabIndex = 6;
            this.btnConsultorio.Text = "CONSULTORIOS";
            this.btnConsultorio.UseVisualStyleBackColor = false;
            this.btnConsultorio.Click += new System.EventHandler(this.btnConsultorio_Click);
            // 
            // btnTriaje
            // 
            this.btnTriaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnTriaje.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTriaje.Location = new System.Drawing.Point(367, 79);
            this.btnTriaje.Name = "btnTriaje";
            this.btnTriaje.Size = new System.Drawing.Size(393, 47);
            this.btnTriaje.TabIndex = 8;
            this.btnTriaje.Text = "TRIAJES";
            this.btnTriaje.UseVisualStyleBackColor = false;
            this.btnTriaje.Click += new System.EventHandler(this.btnTriaje_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnTriaje);
            this.groupBox1.Controls.Add(this.btnConsultorio);
            this.groupBox1.Controls.Add(this.btnPaciente);
            this.groupBox1.Controls.Add(this.btnMedicos);
            this.groupBox1.Controls.Add(this.btnConsulta);
            this.groupBox1.Controls.Add(this.btnEnfermeras);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(11, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(812, 262);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MANTENIMIENTOS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "hospitales";
            // 
            // Mantenimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(835, 312);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbHospital);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Mantenimientos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimientos";
            this.Load += new System.EventHandler(this.Mantenimientos_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem operacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuProveedores;
        private System.Windows.Forms.ToolStripMenuItem mantHospitalesToolStripMenuItem;
        private System.Windows.Forms.ComboBox cmbHospital;
        private System.Windows.Forms.ToolStripMenuItem medicinasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagarConsultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuTiposPago;
        private System.Windows.Forms.ToolStripMenuItem hospitalesToolStripMenuItem;
        private System.Windows.Forms.Button btnEnfermeras;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Button btnMedicos;
        private System.Windows.Forms.Button btnPaciente;
        private System.Windows.Forms.Button btnConsultorio;
        private System.Windows.Forms.Button btnTriaje;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
    }
}

