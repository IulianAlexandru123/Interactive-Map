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
    public partial class Regatul_Unit_form : Form
    {
        public Regatul_Unit_form()
        {
            InitializeComponent();
        }
        int s = 0;
        private void Meniu_Click(object sender, EventArgs e)
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
            Istorie_gbr form = new Istorie_gbr();
            form.ShowDialog();
        }

        private void Geografie_Click(object sender, EventArgs e)
        {
            Geografie_gbr form1 = new Geografie_gbr();
            form1.ShowDialog();
        }

        private void Economie_Click(object sender, EventArgs e)
        {
            Economie_gbr frm = new Economie_gbr();
            frm.ShowDialog();
        }

        private void Regatul_Unit_form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
