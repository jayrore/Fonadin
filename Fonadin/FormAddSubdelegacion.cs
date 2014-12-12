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
using MongoDB.Driver.Operations;
using MongoDB.Driver.Builders;
using MongoDB.Driver.GridFS;
using MongoDB.Driver.Linq;
using MongoDB.Bson;
using MongoDB.Bson.IO;
using MongoDB.Bson.Serialization.Attributes;

namespace Fonadin
{
    public partial class FormAddSubdelegacion : Form
    {
        colDelegaciones colDelegaciones = new colDelegaciones();
        public FormAddSubdelegacion()
        {
            InitializeComponent();
        }

        private void FormAddSubdelegacion_Load(object sender, EventArgs e)
        {
            this.LlenarTablas();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
           

        }
        private void LlenarTablas()
        {
            var delegaciones = colDelegaciones.getAll();
            foreach (var delegacion in delegaciones)
            {
                this.listBox1.Items.Add(delegacion.nombre);
            }         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = listBox1.SelectedItem.ToString();

            String[] newSub = {this.textBox1.Text};
            
            var list = new List<String>();
            try
            {
                var cursor = colDelegaciones.getByNombre(nombre);
                list.AddRange(newSub);
                try
                {
                    list.AddRange(cursor.subdelegaciones);

                }
                catch (Exception)
                {
                }
                cursor.subdelegaciones = list.ToArray();
                colDelegaciones.save(cursor);
                Console.WriteLine(cursor.ToJson());
            }
            catch (Exception es)
            {
                Console.WriteLine(es.Message.ToString());
                throw;
            }

        }
    }
}
