using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fonadin
{
    public partial class FormAddDelegacion : Form
    {
        colDelegaciones colDelegaciones = new colDelegaciones();
        public FormAddDelegacion()
        {
            InitializeComponent();
        }
        private void FormAddDelegacion_Load(object sender, EventArgs e)
        {
            this.LlenarTablas();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Delegacion newDelegacion = new Delegacion();
            newDelegacion.nombre = this.txtNombre.Text;

            var writeConcern = colDelegaciones.save(newDelegacion);
            this.txtResponse.Text = "";

            if (writeConcern["err"].ToString() == "BsonNull" && writeConcern["ok"] == 1.0)
            {
                this.LlenarTablas();
                this.txtResponse.Text = "La delegacion fue  ingresado satisfactoriamente";
            }
            else
            {
                this.txtResponse.Text = "La delegacion no pudo ser Agregado a la base de datos" + writeConcern[2].ToString() + " " + writeConcern[3];

            }
        }
        private void LlenarTablas()
        {
            BindingList<Delegacion> docList = new BindingList<Delegacion>();
            var delegaciones = colDelegaciones.getAll();
            foreach (var delegacion in delegaciones)
            {
                docList.Add(delegacion);
            }
            this.dataGridView1.DataSource = docList;
            this.dataGridView1.Columns[0].Visible = false;

        }


    }
}
