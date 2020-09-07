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
    public partial class Bulgaria_form : Form
    {
        public Bulgaria_form()
        {
            InitializeComponent();
        }
        int s = 0;
        private void Meniu_bulgaria_MouseClick(object sender, MouseEventArgs e)
        {
            s++;
            if (s % 2 == 1)
            {
                Istorie_bulgaria.Visible = true;
                Geografie_bulgaria.Visible = true;
                Economie_bulgaria.Visible = true;

            }
            else
            {
                Istorie_bulgaria.Visible = false;
                Geografie_bulgaria.Visible = false;
                Economie_bulgaria.Visible = false;
            }
        }

        private void Istorie_bulgaria_Click(object sender, EventArgs e)
        {
            Istorie_bulgaria form = new Istorie_bulgaria();
            form.ShowDialog();
        }

        private void Geografie_bulgaria_Click(object sender, EventArgs e)
        {
            geografie_bulgaria form1 = new geografie_bulgaria();
            form1.ShowDialog();

        }

        private void Economie_bulgaria_Click(object sender, EventArgs e)
        {
            Economie_austria form2 = new Economie_austria();
            form2.ShowDialog();
        }

        private void Bulgaria_form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
