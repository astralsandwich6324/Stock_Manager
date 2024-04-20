namespace Restaurante_Inventario
{
    partial class Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clientes));
            this.btnclientescerrar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnclientescerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnclientescerrar
            // 
            this.btnclientescerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnclientescerrar.Image")));
            this.btnclientescerrar.Location = new System.Drawing.Point(761, -1);
            this.btnclientescerrar.Name = "btnclientescerrar";
            this.btnclientescerrar.Size = new System.Drawing.Size(39, 40);
            this.btnclientescerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnclientescerrar.TabIndex = 0;
            this.btnclientescerrar.TabStop = false;
            this.btnclientescerrar.Click += new System.EventHandler(this.btnclientescerrar_Click);
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnclientescerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Clientes";
            this.Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.btnclientescerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btnclientescerrar;
    }
}