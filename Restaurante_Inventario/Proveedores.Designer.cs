namespace Restaurante_Inventario
{
    partial class Proveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Proveedores));
            this.gridproveedores = new System.Windows.Forms.DataGridView();
            this.editarproveedores = new System.Windows.Forms.Button();
            this.eliminarproveedores = new System.Windows.Forms.Button();
            this.guardarventas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdetallebanco = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txttaxid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridproveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridproveedores
            // 
            this.gridproveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridproveedores.Location = new System.Drawing.Point(12, 12);
            this.gridproveedores.Name = "gridproveedores";
            this.gridproveedores.Size = new System.Drawing.Size(534, 382);
            this.gridproveedores.TabIndex = 0;
            this.gridproveedores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridproveedores_CellContentClick);
            // 
            // editarproveedores
            // 
            this.editarproveedores.Location = new System.Drawing.Point(12, 417);
            this.editarproveedores.Name = "editarproveedores";
            this.editarproveedores.Size = new System.Drawing.Size(75, 23);
            this.editarproveedores.TabIndex = 1;
            this.editarproveedores.Text = "Editar";
            this.editarproveedores.UseVisualStyleBackColor = true;
            this.editarproveedores.Click += new System.EventHandler(this.editarproveedores_Click);
            // 
            // eliminarproveedores
            // 
            this.eliminarproveedores.Location = new System.Drawing.Point(347, 417);
            this.eliminarproveedores.Name = "eliminarproveedores";
            this.eliminarproveedores.Size = new System.Drawing.Size(75, 23);
            this.eliminarproveedores.TabIndex = 2;
            this.eliminarproveedores.Text = "Eliminar";
            this.eliminarproveedores.UseVisualStyleBackColor = true;
            this.eliminarproveedores.Click += new System.EventHandler(this.eliminarproveedores_Click);
            // 
            // guardarventas
            // 
            this.guardarventas.Location = new System.Drawing.Point(765, 393);
            this.guardarventas.Name = "guardarventas";
            this.guardarventas.Size = new System.Drawing.Size(75, 47);
            this.guardarventas.TabIndex = 3;
            this.guardarventas.Text = "Guardar";
            this.guardarventas.UseVisualStyleBackColor = true;
            this.guardarventas.Click += new System.EventHandler(this.guardarventas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(552, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(646, 122);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(175, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(646, 156);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(175, 20);
            this.txtemail.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(552, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Email";
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(646, 188);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(175, 20);
            this.txttelefono.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(552, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Telefono";
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(646, 229);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(175, 20);
            this.txtdireccion.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(552, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Direccion";
            // 
            // txtdetallebanco
            // 
            this.txtdetallebanco.Location = new System.Drawing.Point(707, 262);
            this.txtdetallebanco.Name = "txtdetallebanco";
            this.txtdetallebanco.Size = new System.Drawing.Size(114, 20);
            this.txtdetallebanco.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(552, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Detalle de banco";
            // 
            // txttaxid
            // 
            this.txttaxid.Location = new System.Drawing.Point(646, 306);
            this.txttaxid.Name = "txttaxid";
            this.txttaxid.Size = new System.Drawing.Size(175, 20);
            this.txttaxid.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(556, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Tax ID";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(816, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 452);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txttaxid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtdetallebanco);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guardarventas);
            this.Controls.Add(this.eliminarproveedores);
            this.Controls.Add(this.editarproveedores);
            this.Controls.Add(this.gridproveedores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Proveedores";
            this.Text = "Proveedores";
            this.Load += new System.EventHandler(this.Proveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridproveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridproveedores;
        private System.Windows.Forms.Button editarproveedores;
        private System.Windows.Forms.Button eliminarproveedores;
        private System.Windows.Forms.Button guardarventas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtdetallebanco;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txttaxid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}