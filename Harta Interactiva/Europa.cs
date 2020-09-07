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
    public partial class Europa : Form
    {
        
        public Europa()
        {
            InitializeComponent();
            
        }

        private void România_Click(object sender, EventArgs e)
        {
            Romania_form form4 = new Romania_form();
            form4.ShowDialog();
            
        }

        

        private void Franța_Click(object sender, EventArgs e)
        {
            Franta_form form6 = new Franta_form();
            form6.ShowDialog();
            
        }

        private void Germania_Click(object sender, EventArgs e)
        {
            Germania_form form1 = new Germania_form();
            form1.ShowDialog();
          

        }

        private void Spania_Click(object sender, EventArgs e)
        {
            Spania_form form2 = new Spania_form();
            form2.ShowDialog();
            
        }

        private void Italia_Click(object sender, EventArgs e)
        {
            Italia_form form134 = new Italia_form();
            form134.ShowDialog();
            
        }

        private void Cehia_Click(object sender, EventArgs e)
        {
            Cehia_form form7 = new Cehia_form();
            form7.ShowDialog();

        }

        private void Polonia_Click(object sender, EventArgs e)
        {
            Polonia_form form11 = new Polonia_form();
            form11.ShowDialog();
        }

        private void Ungaria_Click(object sender, EventArgs e)
        {
            Ungaria_form form9 = new Ungaria_form();
            form9.ShowDialog();
        }

        private void Bulgaria_Click(object sender, EventArgs e)
        {
            Bulgaria_form form8 = new Bulgaria_form();
            form8.ShowDialog();
        }

        private void Grecia_Click(object sender, EventArgs e)
        {
            Grecia_form form12 = new Grecia_form();
            form12.ShowDialog();
        }

        private void Britania_Click(object sender, EventArgs e)
        {
            Regatul_Unit_form form13 = new Regatul_Unit_form();
            form13.ShowDialog();
        }




        private void Ucraina_Click(object sender, EventArgs e)
        {
            Ucraina_form form14 = new Ucraina_form();
            form14.ShowDialog();
        }



        private void Austria_Click(object sender, EventArgs e)
        {
            Austria_form form15 = new Austria_form();
            form15.ShowDialog();
        }

       private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Polonia_MouseEnter(object sender, EventArgs e)
        {
            hoverPolonia.Visible = true;
        }

        private void Polonia_MouseLeave(object sender, EventArgs e)
        {
            hoverPolonia.Visible = false;
        }

      private void Germania_MouseEnter(object sender, EventArgs e)
        {
            hovergermania.Visible = true;
        }

        private void Germania_MouseLeave(object sender, EventArgs e)
        {
            hovergermania.Visible = false;
        }

        private void Ucraina_MouseEnter(object sender, EventArgs e)
    {
        hoverUcraina.Visible = true;
    }

        private void Ucraina_MouseLeave(object sender, EventArgs e)
    {
        hoverUcraina.Visible = false;
    }

        private void Britania_MouseEnter(object sender, EventArgs e)
        {
            hoverbritania.Visible = true;
        }

        private void Britania_MouseLeave(object sender, EventArgs e)
        {
            hoverbritania.Visible = false;
        }

        private void Franța_MouseEnter(object sender, EventArgs e)
        {
            hoverfranta.Visible = true;
        }

        private void Franța_MouseLeave(object sender, EventArgs e)
        {
            hoverfranta.Visible = false;
        }

        private void Spania_MouseEnter(object sender, EventArgs e)
        {
            hoverspania.Visible = true;
        }

        private void Spania_MouseLeave(object sender, EventArgs e)
        {
            hoverspania.Visible = false;
        }

        private void Italia_MouseEnter(object sender, EventArgs e)
        {
            hoveritalia.Visible = true;
        }

        private void Italia_MouseLeave(object sender, EventArgs e)
        {
            hoveritalia.Visible = false;
        }

        private void Grecia_MouseEnter(object sender, EventArgs e)
        {
            hovergrecia.Visible = true;
        }

        private void Grecia_MouseLeave(object sender, EventArgs e)
        {
            hovergrecia.Visible = false;
        }

        private void România_MouseEnter(object sender, EventArgs e)
        {
            hoverromania.Visible = true;
        }

        private void România_MouseLeave(object sender, EventArgs e)
        {
            hoverromania.Visible = false;
        }

        private void Bulgaria_MouseEnter(object sender, EventArgs e)
        {
            hbulgaria.Visible = true;
        }

        private void Bulgaria_MouseLeave(object sender, EventArgs e)
        {
            hbulgaria.Visible = false;
        }

        private void Cehia_MouseEnter(object sender, EventArgs e)
        {
            hcehia.Visible = true;
        }

        private void Cehia_MouseLeave(object sender, EventArgs e)
        {
            hcehia.Visible = false;
        }

        private void Ungaria_MouseEnter(object sender, EventArgs e)
        {
            hungaria.Visible = true;
        }

        private void Ungaria_MouseLeave(object sender, EventArgs e)
        {
            hungaria.Visible = false;
        }

        private void Austria_MouseEnter(object sender, EventArgs e)
        {
            haustria.Visible = true;
        }

        private void Austria_MouseLeave(object sender, EventArgs e)
        {
            haustria.Visible = false;
        }

        private void Europa_Load(object sender, EventArgs e)
        {

        }

        

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            Test1_form testform = new Test1_form();
            testform.ShowDialog();

        }

        private void button_mut_MouseClick(object sender, MouseEventArgs e)
        {

            Harta_Muta hm = new Harta_Muta() ;
            hm.ShowDialog();
        }
    }
}
