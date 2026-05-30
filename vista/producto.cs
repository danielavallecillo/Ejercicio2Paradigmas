using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2Paradigmas.vista
{
    public partial class producto : Form

    {
        List<Modelo.M_Producto> L_P = new List<Modelo.M_Producto>();
        public producto()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void producto_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            L_P.Add(
    new Modelo.M_Producto(
        textBox1.Text,
        textBox2.Text,
        Convert.ToDouble(numericUpDown1.Value),
        Convert.ToDouble(numericUpDown2.Value)
    )
);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = L_P;

            textBox1.Clear();
            textBox2.Clear();
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;

        }

        private void buttonMostrar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = L_P.ToList();

        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
