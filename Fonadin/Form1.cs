﻿using System;
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

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddCategorias FormAddCategorias = new FormAddCategorias();
            FormAddCategorias.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormAddDelegacion FormAddDelegacion = new FormAddDelegacion();
            FormAddDelegacion.Show();
        }

        private void agregarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormAddSubdelegacion FormAddSubdelegacion = new FormAddSubdelegacion();
            FormAddSubdelegacion.Show();
        }

     
    }
}
