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
    public partial class Spania_form : Form
    {
        public Spania_form()
        {
            InitializeComponent();
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

        private void Geografie_Click(object sender, EventArgs e)
        {
            Geografie_mb form1 = new Geografie_mb();
            form1.ShowDialog();
        }

        private void Istorie_Click(object sender, EventArgs e)
        {
            Istorie_mb form = new Istorie_mb();
            form.ShowDialog();
        }

        private void Economie_Click(object sender, EventArgs e)
        {
            Economie_mb form2 = new Economie_mb();
            form2.ShowDialog();

        }

        private void Spania_form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
