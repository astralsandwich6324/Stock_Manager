namespace Restaurante_Inventario
{
    partial class ventas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ventas));
            this.btnventascerrar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnventascerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnventascerrar
            // 
            this.btnventascerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnventascerrar.Image")));
            this.btnventascerrar.Location = new System.Drawing.Point(762, -1);
            this.btnventascerrar.Name = "btnventascerrar";
            this.btnventascerrar.Size = new System.Drawing.Size(41, 37);
            this.btnventascerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnventascerrar.TabIndex = 1;
            this.btnventascerrar.TabStop = false;
            this.btnventascerrar.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnventascerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ventas";
            this.Text = "ventas";
            this.Load += new System.EventHandler(this.ventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnventascerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btnventascerrar;
    }
}