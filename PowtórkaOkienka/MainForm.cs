using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowtórkaOkienka
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //pkt. 7
        private void Wyczysc(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
            richTextBox1.Text = String.Empty;
        }

        //pkt. 8
        private void Wyslij(object sender, EventArgs e)
        {
            MessageBox.Show("Wiadomość została wysłana "+ textBox2.Text,"Wysłano");
        }
    }
}
