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
        colNiveles colNiveles;
        public Form1()
        {
            colNiveles = new colNiveles();
           
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.txtResponse.Text = "";
            Nivel newNivel = new Nivel( this.txtNombre.Text );
            var result = colNiveles.save(newNivel);
            string response = (result["err"].ToString() == "BsonNull" && result["ok"] == 1.0) ? "El nivel fue  ingresado satisfactoriamente" : "El nivel no pudo ser Agregado a la base de datos" + result[2].ToString() + " " + result[3];
            this.txtResponse.Text = response;
        }
    }
}
