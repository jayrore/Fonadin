using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Bson;

namespace Fonadin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void corredoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddCorredor FormAddCorredor = new FormAddCorredor();
            FormAddCorredor.Show();
        }

        private void programasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddPrograma FormAddPrograma = new FormAddPrograma();
            FormAddPrograma.Show();
        }

        private void autopistasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddAutopista FormAddAutopista = new FormAddAutopista();
            FormAddAutopista.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FormPresupuesto FormAutopistas = new FormPresupuesto();
            FormAutopistas.Show();
        }

     
    }
}
