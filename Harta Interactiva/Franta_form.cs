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
    public partial class Franta_form : Form
    {
        public Franta_form()
        {
            InitializeComponent();
        }

        private void Franta_form_Load(object sender, EventArgs e)
        {

        }

        private void Franta_form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }


        }
        int s = 0;
        private void Menu_Click(object sender, EventArgs e)
        {
            s++;
            if (s % 2 == 1)
            {
                Istorie.Visible = true;
                Economie.Visible = true;
                Geografie.Visible = true;
            }
            else
            {
                Istorie.Visible = false;
                Geografie.Visible = false;
                Economie.Visible = false;

            }
        }

        private void Istorie_Click(object sender, EventArgs e)
        {
            Istorie_franta form = new Istorie_franta();
            form.ShowDialog();
        }

        private void Geografie_Click(object sender, EventArgs e)
        {
            Geografie_franta form1 = new Geografie_franta();
            form1.ShowDialog();

        }

        private void Economie_Click(object sender, EventArgs e)
        {
            Economie_franta form2 = new Economie_franta();
            form2.ShowDialog();

        }
    }
}
