namespace Restaurante_Inventario
{
    partial class stock_manager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(stock_manager));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.nombreprod = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigoBarras = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtidsuplidor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtstock = new System.Windows.Forms.TextBox();
            this.guardarprod = new System.Windows.Forms.Button();
            this.editarprod = new System.Windows.Forms.Button();
            this.eliminarprod = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(828, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(540, 318);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(660, 71);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(164, 20);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // nombreprod
            // 
            this.nombreprod.AutoSize = true;
            this.nombreprod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreprod.Location = new System.Drawing.Point(589, 71);
            this.nombreprod.Name = "nombreprod";
            this.nombreprod.Size = new System.Drawing.Size(65, 20);
            this.nombreprod.TabIndex = 3;
            this.nombreprod.Text = "Nombre";
            this.nombreprod.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(589, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Codigo de Barras";
            // 
            // txtCodigoBarras
            // 
            this.txtCodigoBarras.Location = new System.Drawing.Point(721, 111);
            this.txtCodigoBarras.Name = "txtCodigoBarras";
            this.txtCodigoBarras.Size = new System.Drawing.Size(103, 20);
            this.txtCodigoBarras.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(589, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Descripcion";
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(687, 149);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(137, 20);
            this.txtdescripcion.TabIndex = 6;
            this.txtdescripcion.TextChanged += new System.EventHandler(this.txtdescripcion_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(589, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Cantidad";
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(668, 189);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(156, 20);
            this.txtcantidad.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(589, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "IdSuplidor";
            // 
            // txtidsuplidor
            // 
            this.txtidsuplidor.Location = new System.Drawing.Point(676, 229);
            this.txtidsuplidor.Name = "txtidsuplidor";
            this.txtidsuplidor.Size = new System.Drawing.Size(148, 20);
            this.txtidsuplidor.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(589, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Stock";
            // 
            // txtstock
            // 
            this.txtstock.Location = new System.Drawing.Point(660, 276);
            this.txtstock.Name = "txtstock";
            this.txtstock.Size = new System.Drawing.Size(164, 20);
            this.txtstock.TabIndex = 12;
            // 
            // guardarprod
            // 
            this.guardarprod.BackColor = System.Drawing.SystemColors.HotTrack;
            this.guardarprod.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guardarprod.Location = new System.Drawing.Point(593, 310);
            this.guardarprod.Name = "guardarprod";
            this.guardarprod.Size = new System.Drawing.Size(101, 41);
            this.guardarprod.TabIndex = 14;
            this.guardarprod.Text = "Guardar";
            this.guardarprod.UseVisualStyleBackColor = false;
            this.guardarprod.Click += new System.EventHandler(this.guardarprod_Click);
            // 
            // editarprod
            // 
            this.editarprod.Location = new System.Drawing.Point(24, 357);
            this.editarprod.Name = "editarprod";
            this.editarprod.Size = new System.Drawing.Size(71, 33);
            this.editarprod.TabIndex = 15;
            this.editarprod.Text = "Editar";
            this.editarprod.UseVisualStyleBackColor = true;
            this.editarprod.Click += new System.EventHandler(this.editarprod_Click);
            // 
            // eliminarprod
            // 
            this.eliminarprod.Location = new System.Drawing.Point(101, 357);
            this.eliminarprod.Name = "eliminarprod";
            this.eliminarprod.Size = new System.Drawing.Size(71, 33);
            this.eliminarprod.TabIndex = 16;
            this.eliminarprod.Text = "Eliminar";
            this.eliminarprod.UseVisualStyleBackColor = true;
            this.eliminarprod.Click += new System.EventHandler(this.eliminarprod_Click);
            // 
            // stock_manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(870, 450);
            this.Controls.Add(this.eliminarprod);
            this.Controls.Add(this.editarprod);
            this.Controls.Add(this.guardarprod);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtstock);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtidsuplidor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodigoBarras);
            this.Controls.Add(this.nombreprod);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "stock_manager";
            this.Text = "stock_manager";
            this.Load += new System.EventHandler(this.stock_manager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label nombreprod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigoBarras;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtidsuplidor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtstock;
        private System.Windows.Forms.Button guardarprod;
        private System.Windows.Forms.Button editarprod;
        private System.Windows.Forms.Button eliminarprod;
    }
}