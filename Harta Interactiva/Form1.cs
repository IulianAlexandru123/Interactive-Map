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
    public partial class Introducere : Form
    {
        public Introducere()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//Start
        {
            Europa form = new Europa();
            form.ShowDialog();
        }
    }
}
