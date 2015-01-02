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
    public partial class FormAddCorredor : Form
    {
        ColCorredores colDelegaciones = new ColCorredores();
        public FormAddCorredor()
        {
            InitializeComponent();
        }
        private void FormAddDelegacion_Load(object sender, EventArgs e)
        {
            this.LlenarTablas();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Corredor corredor = new Corredor();
            
            corredor.nombre = this.txtNombre.Text.ToLower();

            var writeConcern = colDelegaciones.save(corredor);
            this.txtResponse.Text = "";

            if (writeConcern["err"].ToString() == "BsonNull" && writeConcern["ok"] == 1.0)
            {
                this.LlenarTablas();
                this.txtResponse.Text = "El Corredor <" + corredor.nombre + "> fue  ingresado satisfactoriamente a la base de datos";
            }
            else
            {
                this.txtResponse.Text = "<Error> El Corredor <" + corredor.nombre + "> no pudo ser Agregado a la base de datos" + writeConcern[2].ToString() + " " + writeConcern[3];

            }
        }
        private void LlenarTablas()
        {
            BindingList<Corredor> docList = new BindingList<Corredor>();
            var delegaciones = colDelegaciones.getAll();
            foreach (var delegacion in delegaciones)
            {
                docList.Add(delegacion);
            }
            this.dataGridView1.DataSource = docList;
            this.dataGridView1.Columns[0].Visible = false;

        }
        private void setDefaultState()
        {
            this.LlenarTablas();
            this.txtNombre.Text = String.Empty;
            this.txtNombre.Focus();
        }
        private void ResponseWrite(String text)
        {
            this.txtResponse.AppendText("Corredores >" + text);
            this.txtResponse.AppendText(Environment.NewLine);
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.borrar(e);
        }

        private void borrar(DataGridViewCellEventArgs e) 
        {
            var corredor = this.dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            Console.WriteLine(corredor);

            string message = "Esta seguro de que desea borrar este Corredor de la lista?";
            string caption = "Borrar Corredor: <" + this.dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value + ">";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Preguntar si desea borrar elemento de la base de datos

            result = MessageBox.Show(message, caption, buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                var isRemoved = colDelegaciones.delete(corredor);

                Console.WriteLine(isRemoved);
                if (isRemoved)
                {
                    this.ResponseWrite("El Corredor: <" + corredor + "> ha sido eliminado de la base de datos");
                  this.setDefaultState();
                }

            }
        }


    }
}
