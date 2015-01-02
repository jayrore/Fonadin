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
    public partial class FormAddAutopista : Form
    {
        ColAutopistas colAutopistas = new ColAutopistas();
        public FormAddAutopista()
        {
            InitializeComponent();
            llenarTabla();
        }
        private void llenarTabla()
        {
           var autopistas = colAutopistas.getAll();
           BindingList<Autopista> docList = new BindingList<Autopista>();
           foreach (var auto in autopistas.ToList<Autopista>())
            {
                docList.Add(auto);
            }
            this.dataGridView1.DataSource = docList;
            this.dataGridView1.Columns[0].Visible = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.guardar();
        }
        private void guardar()
        {
            var autopista = new Autopista();
            autopista.nombre = this.txtNombre.Text;
            colAutopistas.save(autopista);
            llenarTabla();
        }
        private void ResponseWrite(String text)
        {
            this.txtResponse.AppendText("programas >" + text);
            this.txtResponse.AppendText(Environment.NewLine);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.borrar(e);
        }

        private void borrar(DataGridViewCellEventArgs e) 
        {
            var prgmName = this.dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            Console.WriteLine(prgmName);

            string message = "Esta seguro de que desea borrar este Programa de la lista?";
            string caption = "Borrar Programa: <" + prgmName + ">";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Preguntar si desea borrar elemento de la base de datos

            result = MessageBox.Show(message, caption, buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {

                var isRemoved = colAutopistas.delete(prgmName);
                Console.WriteLine(isRemoved);
                if (isRemoved)
                {
                   // this.ResponseWrite("El programa ha sido eliminado de la base de datos");
                   this.setDefaultState();
                }

            } 
        }
        private void setDefaultState()
        {
            this.llenarTabla();
            this.txtNombre.Text = String.Empty;
            this.txtNombre.Focus();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                this.guardar();
            }
        }
    }
}
