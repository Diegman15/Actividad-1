using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace holimundo
{
    public partial class Holi : Form
    {
        public Holi()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            string textBox1;
            textBox1 = Console.ReadLine();
        }

        private void Bb_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text;
            MessageBox.Show("Bienvenido " + nombre );
        }
    }
}
