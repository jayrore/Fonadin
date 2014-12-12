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
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.subDelegacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.quitarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subNivelesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.quitarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tlHerramientas.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlHerramientas
            // 
            this.tlHerramientas.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tlHerramientas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton2,
            this.toolStripDropDownButton1});
            this.tlHerramientas.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.tlHerramientas.Location = new System.Drawing.Point(5, 5);
            this.tlHerramientas.Name = "tlHerramientas";
            this.tlHerramientas.Size = new System.Drawing.Size(1292, 23);
            this.tlHerramientas.TabIndex = 4;
            this.tlHerramientas.Text = "toolStrip1";
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.subDelegacionToolStripMenuItem});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(106, 20);
            this.toolStripDropDownButton2.Tag = "Delegaciones";
            this.toolStripDropDownButton2.Text = "Delegaciones";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(155, 22);
            this.toolStripMenuItem1.Text = "Agregar";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(155, 22);
            this.toolStripMenuItem2.Text = "Quitar";
            // 
            // subDelegacionToolStripMenuItem
            // 
            this.subDelegacionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem2,
            this.quitarToolStripMenuItem2});
            this.subDelegacionToolStripMenuItem.Name = "subDelegacionToolStripMenuItem";
            this.subDelegacionToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.subDelegacionToolStripMenuItem.Text = "Sub delegacion";
            // 
            // agregarToolStripMenuItem2
            // 
            this.agregarToolStripMenuItem2.Name = "agregarToolStripMenuItem2";
            this.agregarToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.agregarToolStripMenuItem2.Text = "Agregar";
            this.agregarToolStripMenuItem2.Click += new System.EventHandler(this.agregarToolStripMenuItem2_Click);
            // 
            // quitarToolStripMenuItem2
            // 
            this.quitarToolStripMenuItem2.Name = "quitarToolStripMenuItem2";
            this.quitarToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.quitarToolStripMenuItem2.Text = "Quitar";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.quitarToolStripMenuItem,
            this.subNivelesToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(92, 20);
            this.toolStripDropDownButton1.Tag = "Categorias";
            this.toolStripDropDownButton1.Text = "Categorias";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.agregarToolStripMenuItem.Text = "Agregar";
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
            // 
            // quitarToolStripMenuItem
            // 
            this.quitarToolStripMenuItem.Name = "quitarToolStripMenuItem";
            this.quitarToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.quitarToolStripMenuItem.Text = "Quitar";
            // 
            // subNivelesToolStripMenuItem
            // 
            this.subNivelesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem1,
            this.quitarToolStripMenuItem1});
            this.subNivelesToolStripMenuItem.Name = "subNivelesToolStripMenuItem";
            this.subNivelesToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.subNivelesToolStripMenuItem.Text = "Sub Categorias";
            // 
            // agregarToolStripMenuItem1
            // 
            this.agregarToolStripMenuItem1.Name = "agregarToolStripMenuItem1";
            this.agregarToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.agregarToolStripMenuItem1.Text = "Agregar";
            // 
            // quitarToolStripMenuItem1
            // 
            this.quitarToolStripMenuItem1.Name = "quitarToolStripMenuItem1";
            this.quitarToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.quitarToolStripMenuItem1.Text = "Quitar";
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
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subNivelesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quitarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem subDelegacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem quitarToolStripMenuItem2;
    }
}

