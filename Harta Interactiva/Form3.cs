using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Harta_Interactiva
{
    public partial class Form0 : Form
    {

        public Form0()
        {
            InitializeComponent();
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void Form0_Load(object sender, EventArgs e)
        {
           // label1.Text = "Felicitari! Ai obtinut scorul de" + test.s + "puncte la primul test. Esti gata pentru urmatorul?";

        }



        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            Harta_Muta form = new Harta_Muta();
            form.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_MouseClick_1(object sender, MouseEventArgs e)
        {
            this.Hide();
            Europa form = new Europa();
            form.ShowDialog();
        }
    }
}
