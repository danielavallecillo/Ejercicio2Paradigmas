namespace Ejercicio2Paradigmas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vista.producto forma = new vista.producto();
            forma.MdiParent = this;
            forma.Show();

        }
    }
}
