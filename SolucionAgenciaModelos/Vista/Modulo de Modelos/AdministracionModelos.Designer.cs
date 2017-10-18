namespace Vista
{
    partial class AdministracionModelos
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.goToCreateModelo = new System.Windows.Forms.ToolStripMenuItem();
            this.goToEditModelo = new System.Windows.Forms.ToolStripMenuItem();
            this.goToSearchModelo = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.goToListModelos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goToCreateModelo,
            this.goToEditModelo,
            this.goToListModelos});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(430, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // goToCreateModelo
            // 
            this.goToCreateModelo.Name = "goToCreateModelo";
            this.goToCreateModelo.Size = new System.Drawing.Size(91, 20);
            this.goToCreateModelo.Text = "Crear Modelo";
            this.goToCreateModelo.Click += new System.EventHandler(this.goToCreateModelo_Click);
            // 
            // goToEditModelo
            // 
            this.goToEditModelo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goToSearchModelo,
            this.toolStripSeparator1,
            this.toolStripTextBox1});
            this.goToEditModelo.Name = "goToEditModelo";
            this.goToEditModelo.Size = new System.Drawing.Size(93, 20);
            this.goToEditModelo.Text = "Editar Modelo";
            // 
            // goToSearchModelo
            // 
            this.goToSearchModelo.Name = "goToSearchModelo";
            this.goToSearchModelo.Size = new System.Drawing.Size(100, 23);
            this.goToSearchModelo.Text = "Buscar Modelo";
            this.goToSearchModelo.Click += new System.EventHandler(this.goToSearchModelo_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(157, 6);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            // 
            // goToListModelos
            // 
            this.goToListModelos.Name = "goToListModelos";
            this.goToListModelos.Size = new System.Drawing.Size(57, 20);
            this.goToListModelos.Text = "Listado";
            // 
            // AdministracionModelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 261);
            this.Controls.Add(this.menuStrip1);
            this.Name = "AdministracionModelos";
            this.Text = "Administracion de Modelos";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem goToEditModelo;
        private System.Windows.Forms.ToolStripTextBox goToSearchModelo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripMenuItem goToListModelos;
        private System.Windows.Forms.ToolStripMenuItem goToCreateModelo;
    }
}