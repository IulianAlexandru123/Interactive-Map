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
    public partial class Harta_Muta : Form
    {
        public Harta_Muta()
        {
            InitializeComponent();
        }




        int[] array0 = new int[] { 1, 2, 3};
        string[] array1 = new string[] { "Italia", "Rusia", "Da"};
        int i = 0, scor = 0;
        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button1.Visible = false;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button1.Visible = true;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button4.Visible = true;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button4.Visible = false;
        }

        private void label2_MouseClick(object sender, MouseEventArgs e)
        {
            if (array0[i] == 1) { MessageBox.Show("Corect!"); scor++; }
            else MessageBox.Show("Incorect");
            label5.Text = "Scorul tau este: " + scor;
            label1.Text = "Unde este " + array1[i] + "?";
            i++;
            if (i == 3)
            {
                this.Hide();
                testgata teste = new testgata();
                teste.ShowDialog();

            }
        }

        private void label3_MouseClick(object sender, MouseEventArgs e)
        {
            if (array0[i] == 2) { MessageBox.Show("Corect!"); scor++; }
            else MessageBox.Show("Incorect");
            label5.Text = "Scorul tau este: " + scor;
            label1.Text = "Unde este " + array1[i] + "?";
            i++;
            if (i == 3)
            {
                this.Hide();
                testgata teste = new testgata();
                teste.ShowDialog();

            }
        }

        private void button6_MouseEnter(object sender, EventArgs e)
        {
            button7.Visible = true;
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            button7.Visible = false;
        }

        private void label4_MouseClick(object sender, MouseEventArgs e)
        {
            if (array0[i] == 3) { MessageBox.Show("Corect!"); scor++; }
            else MessageBox.Show("Incorect");
            label5.Text = "Scorul tau este: " + scor; 
            label1.Text = "Unde este " + array1[i] + "?";
            i++;

            if(i == 3)
            {
                this.Hide();
                testgata teste = new testgata();
                teste.ShowDialog();

            }
        }
    }
}
