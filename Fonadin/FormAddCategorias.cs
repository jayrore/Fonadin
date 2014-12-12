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
    public partial class FormAddCategorias : Form
    {
        colNiveles colNiveles;
        public FormAddCategorias()
        {   
             colNiveles = new colNiveles();
            InitializeComponent();
        }
        private void FormAddCategorias_Load_1(object sender, EventArgs e)
        {
            this.LlenarTablas();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {            
            
            Nivel newNivel = new Nivel();
            newNivel.nombre = this.txtNombre.Text;
            
            var writeConcern = colNiveles.save(newNivel);
            this.txtResponse.Text = "";
            
            if (writeConcern["err"].ToString() == "BsonNull" && writeConcern["ok"] == 1.0)
            {
                this.LlenarTablas();
                this.txtResponse.Text = "El nivel fue  ingresado satisfactoriamente";
            }
            else 
            {
                this.txtResponse.Text = "El nivel no pudo ser Agregado a la base de datos" + writeConcern[2].ToString() + " " + writeConcern[3];

            }

        
        }

        private void LlenarTablas()
        {
            BindingList<Nivel> docList = new BindingList<Nivel>();
            var niveles = colNiveles.getNiveles();
            foreach (Nivel nivel in niveles)
            {
                Console.Write(nivel.ToJson<Nivel>());
                docList.Add(nivel);
            }
            this.dataGridView1.DataSource = docList;
        }

    }
}
