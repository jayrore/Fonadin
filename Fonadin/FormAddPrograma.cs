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
    public partial class FormAddPrograma : Form
    {
        ColProgramas colProgramas = new ColProgramas();
        public FormAddPrograma()
        {   
            InitializeComponent();
        }
        private void FormAddCategorias_Load_1(object sender, EventArgs e)
        {
            this.LlenarTablas();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.GuardarNombre();
        }

        private void GuardarNombre()
        {
            Programas programa = new Programas();
            WriteConcernResult writeConcern;
            programa.nombre = this.txtNombre.Text.ToLower();
            if (this.isValidText(programa.nombre))
            {
                writeConcern = colProgramas.save(programa);
                if (writeConcern.Response["err"].ToString() == "BsonNull" && writeConcern.Response["ok"] == 1.0)
                {
                    this.LlenarTablas();
                    this.ResponseWrite("El Programa <" + programa.nombre + "> fue  ingresado satisfactoriamente a la Base de Datos");
                }
                else
                {
                    this.ResponseWrite("El Programa <" + programa.nombre + "> no pudo ser Agregado a la base de datos.");
                    this.ResponseWrite(writeConcern.Response.ToString());
                }
            }
            else
            {
                this.ResponseWrite("El Formato de el texto no es valido");
            }
            this.setDefaultState();
        }

        private void ResponseWrite(String text) 
        {
            this.txtResponse.AppendText("programas >"+text);
            this.txtResponse.AppendText(Environment.NewLine);
        }

        private void LlenarTablas()
        {
            BindingList<Programas> docList = new BindingList<Programas>();
            var programas = colProgramas.getNiveles();
            foreach (var prgm in programas)
            {
                Console.WriteLine(prgm.ToJson<Programas>());
                docList.Add(prgm);
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

        private bool isValidText(String text)
        {
            bool valid = true;
            valid = (text == "" && valid == true) ? false : true;
            return valid;
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var prgmName = this.dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            Console.WriteLine(prgmName);
            
            string message = "Esta seguro de que desea borrar este Programa de la lista?";
            string caption = "Borrar Programa: <"+ this.dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value +">";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Preguntar si desea borrar elemento de la base de datos

            result = MessageBox.Show(message, caption, buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
               
                var isRemoved = colProgramas.delete(prgmName.ToString());
                
                Console.WriteLine(isRemoved);
                if (isRemoved)
                { 
                    this.ResponseWrite("El programa ha sido eliminado de la base de datos");
                    this.setDefaultState();
                }
               
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                this.GuardarNombre();
            }
        }

    }
}
