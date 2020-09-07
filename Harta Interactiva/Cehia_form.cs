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
    public partial class Cehia_form : Form
    {
        public Cehia_form()
        {
            InitializeComponent();
        }
        int s = 0;
        private void Meniu_cehia_MouseClick(object sender, MouseEventArgs e)
        {
            s++;
            if (s % 2 == 1)
            {
                Istorie_cehia.Visible = true;
                Geografie_cehia.Visible = true;
                Economie_cehia.Visible = true;
            }
            else
            {
                Istorie_cehia.Visible = false;
                Geografie_cehia.Visible = false;
                Economie_cehia.Visible = false;
            }
        }

        private void Istorie_cehia_Click(object sender, EventArgs e)
        {
            Istorie_cehia form = new Istorie_cehia();
            form.ShowDialog();
        }

        private void Geografie_cehia_Click(object sender, EventArgs e)
        {
            Geografie_cehia form1 = new Geografie_cehia();
            form1.ShowDialog();
        }

        private void Economie_cehia_Click(object sender, EventArgs e)
        {
            Economie_cehia form2 = new Economie_cehia();
            form2.ShowDialog();
        }

        private void Cehia_form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
    
}
