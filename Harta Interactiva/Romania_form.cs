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
    public partial class Romania_form : Form
    {
        public Romania_form()
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
            Istorie_rou form = new Istorie_rou();
            form.ShowDialog();
        }

        private void Geografie_Click(object sender, EventArgs e)
        {
            Geografie_rou form1 = new Geografie_rou();
            form1.ShowDialog();
        }

        private void Economie_Click(object sender, EventArgs e)
        {
            Economie_rou frm = new Economie_rou();
            frm.ShowDialog();
        }

        private void Romania_form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
