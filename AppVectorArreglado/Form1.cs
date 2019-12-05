using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppVectorArreglado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerarVector_Click(object sender, EventArgs e)
        {
            int tamanio = Convert.ToInt32(this.txtTamanio.Text);
            int[] vector = Vector.generar(tamanio);

            lstVecctorOriginal.Items.Clear();
            for (int i=0; i<tamanio;i++)
            {
                lstVecctorOriginal.Items.Add(vector[i].ToString());
            }

            Vector.ordenar(vector, tamanio);
            listBoxVector.Items.Clear();
            for (int i = 0; i < tamanio; i++)
            {
                listBoxVector.Items.Add(vector[i].ToString());
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
