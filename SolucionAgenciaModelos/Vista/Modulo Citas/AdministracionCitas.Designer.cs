namespace Vista
{
    partial class AdministracionCitas
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
            this.goToCreateCita = new System.Windows.Forms.ToolStripMenuItem();
            this.goToEditCita = new System.Windows.Forms.ToolStripMenuItem();
            this.goToSearchCita = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.goToListCitas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goToCreateCita,
            this.goToEditCita,
            this.goToListCitas});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(462, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // goToCreateCita
            // 
            this.goToCreateCita.Name = "goToCreateCita";
            this.goToCreateCita.Size = new System.Drawing.Size(71, 20);
            this.goToCreateCita.Text = "Crear Cita";
            this.goToCreateCita.Click += new System.EventHandler(this.goToCreateCita_Click);
            // 
            // goToEditCita
            // 
            this.goToEditCita.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goToSearchCita,
            this.toolStripSeparator1,
            this.toolStripTextBox1});
            this.goToEditCita.Name = "goToEditCita";
            this.goToEditCita.Size = new System.Drawing.Size(73, 20);
            this.goToEditCita.Text = "Editar Cita";
            // 
            // goToSearchCita
            // 
            this.goToSearchCita.Name = "goToSearchCita";
            this.goToSearchCita.Size = new System.Drawing.Size(100, 23);
            this.goToSearchCita.Text = "Buscar Cita";
            this.goToSearchCita.Click += new System.EventHandler(this.goToSearchCita_Click);
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
            // goToListCitas
            // 
            this.goToListCitas.Name = "goToListCitas";
            this.goToListCitas.Size = new System.Drawing.Size(57, 20);
            this.goToListCitas.Text = "Listado";
            // 
            // AdministracionCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 252);
            this.Controls.Add(this.menuStrip1);
            this.Name = "AdministracionCitas";
            this.Text = "Administracion de la Citas";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem goToCreateCita;
        private System.Windows.Forms.ToolStripMenuItem goToEditCita;
        private System.Windows.Forms.ToolStripTextBox goToSearchCita;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripMenuItem goToListCitas;
    }
}