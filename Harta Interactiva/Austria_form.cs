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
    public partial class Austria_form : Form
    {
        public Austria_form()
        {
            InitializeComponent();
        }

        private void Geografie_austria_Click(object sender, EventArgs e)
        {
            Geografie_austria form1 = new Geografie_austria();
            form1.ShowDialog();
        }
        int s = 0;
        private void Meniu_austria_MouseClick(object sender, MouseEventArgs e)
        {
            s++;
            if (s % 2 == 1)
            {
                Istorie_austria.Visible = true;
                Economie_austria.Visible = true;
                Geografie_austria.Visible = true;
            }
            else
            {
                Istorie_austria.Visible = false;
                Geografie_austria.Visible = false;
                Economie_austria.Visible = false;
                    
            }
        }

        private void Istorie_austria_Click(object sender, EventArgs e)
        {
            Istorie_austria form = new Istorie_austria();
            form.ShowDialog();
        }

        private void Economie_austria_Click(object sender, EventArgs e)
        {
            Economie_austria form2 = new Economie_austria();
            form2.ShowDialog();
        }

        private void Austria_form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
