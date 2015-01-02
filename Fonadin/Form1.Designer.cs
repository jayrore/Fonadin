namespace Fonadin
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tlHerramientas = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton3 = new System.Windows.Forms.ToolStripDropDownButton();
            this.corredoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autopistasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tlHerramientas.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlHerramientas
            // 
            this.tlHerramientas.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tlHerramientas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton3,
            this.toolStripButton1});
            this.tlHerramientas.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.tlHerramientas.Location = new System.Drawing.Point(5, 5);
            this.tlHerramientas.Name = "tlHerramientas";
            this.tlHerramientas.Size = new System.Drawing.Size(1292, 23);
            this.tlHerramientas.TabIndex = 4;
            this.tlHerramientas.Text = "toolStrip1";
            // 
            // toolStripDropDownButton3
            // 
            this.toolStripDropDownButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.corredoresToolStripMenuItem,
            this.autopistasToolStripMenuItem,
            this.programasToolStripMenuItem});
            this.toolStripDropDownButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton3.Image")));
            this.toolStripDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton3.Name = "toolStripDropDownButton3";
            this.toolStripDropDownButton3.Size = new System.Drawing.Size(89, 20);
            this.toolStripDropDownButton3.Tag = "Catalogos";
            this.toolStripDropDownButton3.Text = "Catalogos";
            // 
            // corredoresToolStripMenuItem
            // 
            this.corredoresToolStripMenuItem.Name = "corredoresToolStripMenuItem";
            this.corredoresToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.corredoresToolStripMenuItem.Text = "Corredores";
            this.corredoresToolStripMenuItem.Click += new System.EventHandler(this.corredoresToolStripMenuItem_Click);
            // 
            // autopistasToolStripMenuItem
            // 
            this.autopistasToolStripMenuItem.Name = "autopistasToolStripMenuItem";
            this.autopistasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.autopistasToolStripMenuItem.Text = "Autopistas";
            this.autopistasToolStripMenuItem.Click += new System.EventHandler(this.autopistasToolStripMenuItem_Click);
            // 
            // programasToolStripMenuItem
            // 
            this.programasToolStripMenuItem.Name = "programasToolStripMenuItem";
            this.programasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.programasToolStripMenuItem.Text = "Programas";
            this.programasToolStripMenuItem.Click += new System.EventHandler(this.programasToolStripMenuItem_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(92, 20);
            this.toolStripButton1.Text = "Presupuesto";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Fonadin.Properties.Resources.footer_lodyas;
            this.ClientSize = new System.Drawing.Size(1302, 524);
            this.Controls.Add(this.tlHerramientas);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FONADIN V1.1";
            this.tlHerramientas.ResumeLayout(false);
            this.tlHerramientas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tlHerramientas;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton3;
        private System.Windows.Forms.ToolStripMenuItem corredoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autopistasToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}

