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
    public partial class FormPresupuesto : Form
    {
        ColAutopistas colAutopistas = new ColAutopistas();
        ColCorredores colCorredores = new ColCorredores();
        ColProgramas colProgramas = new ColProgramas();
        ColPresupuesto colPresupuesto = new ColPresupuesto();
        public FormPresupuesto()
        {
            InitializeComponent();
            setAutopistasList();
            setCorredoresList();
            setProgramasList();
            
            llenarTabla();
        }

        public void setCorredoresList()
        {
            var corredores = colCorredores.getAll();
            BindingList<String> docList = new BindingList<String>();
            foreach (var corredor in corredores)
            {
                docList.Add(corredor.nombre.ToString());
            }
            this.comboBox1.DataSource = docList;
            
        }
        public void setProgramasList()
        {
            var programas = colProgramas.getNiveles();
            BindingList<String> docList = new BindingList<String>();
            foreach (var pgrm in programas)
            {
                docList.Add(pgrm.nombre.ToString());
            }
            this.comboBox2.DataSource = docList;

        }

        public void setAutopistasList() 
        {
            var autopistas = colAutopistas.getAll();
            BindingList<String> docList = new BindingList<String>();
            foreach (var autopista in autopistas)
            {
                docList.Add(autopista.nombre.ToString());
            }
            this.comboBox3.DataSource = docList;
        }
        private void llenarTabla()
        {
            var autopistas = colPresupuesto.getAll();
            BindingList<Presupuesto> docList = new BindingList<Presupuesto>();
            foreach (var auto in autopistas)
            {
                docList.Add(auto);
            }
            this.dataGridView1.DataSource = docList;
        }
        private void savePresupuesto()
        {
            Presupuesto auto = new Presupuesto();
            auto.nombre = this.comboBox3.SelectedValue.ToString();
            auto.corredor = this.comboBox1.SelectedValue.ToString();
            auto.programa = this.comboBox2.SelectedValue.ToString();
            auto.obra = (this.txtObra.Text == String.Empty)?0 : Convert.ToDouble( this.txtObra.Text );
            auto.supervision = (this.txtSup.Text == String.Empty) ? 0 : Convert.ToDouble(this.txtSup.Text);
            auto.inversion = auto.supervision + auto.obra;
            Console.WriteLine(auto.nombre);
            Console.WriteLine(auto.corredor);
            Console.WriteLine(auto.programa);
            Console.WriteLine(auto.obra);
            Console.WriteLine(auto.supervision);
            guardarAutopista(auto);
        }
        private void guardarAutopista(Presupuesto auto) 
        {
            if (isValidAutopista(auto))
            {
                colPresupuesto.save(auto);
                this.llenarTabla();
            }
           
        }

        private bool isValidAutopista(Presupuesto auto)
        {
            bool isValid = true;
            isValid = (isValid && auto.nombre != String.Empty);
            return isValid;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.savePresupuesto();
        }
    }
}
