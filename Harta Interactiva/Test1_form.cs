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
    public partial class Test1_form : Form
    {
        public Test1_form()
        {
            InitializeComponent();
        }

        private void Test1_form_Load(object sender, EventArgs e)
        {

        }
        int i = 0, s = 0,p=0;
        int[] array0 = new int[] { 3, 2, 3, 4, 1, 2, 1, 2, 2, 2 };
        string[] array1 = new string[] { "Oslo", "Dublin", "Berna", "Ankara", "Sofia", "Bruxelles", "Viena", "Skopje", "Madrid" };
        string[] array2 = new string[] { "Sofia", "Copenhaga", "Atena", "Baku", "Riga", "Sarajevo", "Praga", "Roma", "Zagreb" };
        string[] array3 = new string[] { "Tallinn", "Paris", "San Marino", "Moscova", "Amsterdam", "Belgrad", "Varsovia", "Vilnius", "Chisinau" };
        string[] array4 = new string[] { "Paris", "Lisabona", "Lisabona", "Berlin", "Helsinki", "Ljubljana", "Kiev", "Bratislava", "Erevan" };
        string[] arrayLabel = new string[] { "Care e capitala Bulgariei?", "Care e capitala Frantei?", "Care e capitala Portugaliei?", "Care e capitala Turciei?", "Care e capitala Letoniei?", "Care e capitala Belgiei?", "Care e capitala Cehiei?", "Care e capitala Italiei?", "Care e capitala Croatiei?", };

        

        
 private void back_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            Europa form1234 = new Europa();
            form1234.ShowDialog();
        }
       

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            if (array0[i] == 1)
            {
                MessageBox.Show("Corect");
                s++;
            }

            else
            {
                if (i != 0)
                {
                    if (array0[i] == 2) MessageBox.Show("Incorect. Raspunsul corect este: " + array2[i - 1]);
                    if (array0[i] == 3) MessageBox.Show("Incorect. Raspunsul corect este: " + array3[i - 1]);
                    if (array0[i] == 4) MessageBox.Show("Incorect. Raspunsul corect este: " + array4[i - 1]);
                }
                if (i == 0) MessageBox.Show("Incorect. Raspunsul corect este: Bucuresti");
            }

            if (i <= 8)
            {
                button1.Text = array1[i];
                button2.Text = array2[i];
                button3.Text = array3[i];
                button4.Text = array4[i];
                label1.Text = arrayLabel[i];
            }

            if (i == 9)
            {
                MessageBox.Show("Ai raspuns corect la " + s + " intrebari");
                this.Hide();
                Form0 frm = new Form0();
                frm.ShowDialog();
            }
            label2.Text = "Scorul tau este: " + s + "/10";
            p = i + 2;
            pagina.Text = "Pagina: " + p;
            i++;

        }

       

        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            if (array0[i] == 3)
            {
                MessageBox.Show("Corect");
                s++;
            }

            else
            {
                if (i != 0)
                {
                    if (array0[i] == 1) MessageBox.Show("Incorect. Raspunsul corect este: " + array1[i - 1]);
                    if (array0[i] == 2) MessageBox.Show("Incorect. Raspunsul corect este: " + array2[i - 1]);
                    if (array0[i] == 4) MessageBox.Show("Incorect. Raspunsul corect este: " + array4[i - 1]);
                }
                if (i == 0) MessageBox.Show("Incorect. Raspunsul corect este: Bucuresti");
            }

            if (i <= 8)
            {
                button1.Text = array1[i];
                button2.Text = array2[i];
                button3.Text = array3[i];
                button4.Text = array4[i];
                label1.Text = arrayLabel[i];
            }

            if (i == 9)
            {

                MessageBox.Show("Ai raspuns corect la " + s + " intrebari");
                this.Hide();
                Form0 frm = new Form0();
                frm.ShowDialog();
            }
            label2.Text = "Scorul tau este: " + s + "/10";
            p = i + 2;
            pagina.Text = "Pagina: " + p;
            i++;
        }

        

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            if (array0[i] == 2)
            {
                MessageBox.Show("Corect");
                s++;
            }

            else
            {
                if (i != 0)
                {
                    if (array0[i] == 1) MessageBox.Show("Incorect. Raspunsul corect este: " + array1[i - 1]);
                    if (array0[i] == 3) MessageBox.Show("Incorect. Raspunsul corect este: " + array3[i - 1]);
                    if (array0[i] == 4) MessageBox.Show("Incorect. Raspunsul corect este: " + array4[i - 1]);
                }
                if (i == 0) MessageBox.Show("Incorect. Raspunsul corect este: Bucuresti");
            }

            if (i <= 8)
            {
                button1.Text = array1[i];
                button2.Text = array2[i];
                button3.Text = array3[i];
                button4.Text = array4[i];
                label1.Text = arrayLabel[i];
            }

            if (i == 9)
            {
                MessageBox.Show("Ai raspuns corect la " + s + " intrebari");
                this.Hide();
                Form0 frm = new Form0();
                frm.ShowDialog();
            }
            label2.Text = "Scorul tau este: " + s + "/10";
            p = i + 2;
            pagina.Text = "Pagina: " + p;
            i++;
        }

        private void button4_MouseClick(object sender, MouseEventArgs e)
        {
            if (array0[i] == 4)
            {
                MessageBox.Show("Corect");
                s++;
            }

            else
            {
                if (i != 0)
                {
                    if (array0[i] == 1) MessageBox.Show("Incorect. Raspunsul corect este: " + array1[i - 1]);
                    if (array0[i] == 2) MessageBox.Show("Incorect. Raspunsul corect este: " + array2[i - 1]);
                    if (array0[i] == 3) MessageBox.Show("Incorect. Raspunsul corect este: " + array3[i - 1]);
                }
                if (i == 0) MessageBox.Show("Incorect. Raspunsul corect este: Bucuresti");
            }

            if (i <= 8)
            {
                button1.Text = array1[i];
                button2.Text = array2[i];
                button3.Text = array3[i];
                button4.Text = array4[i];
                label1.Text = arrayLabel[i];
            }

            if (i == 9)
            {
                MessageBox.Show("Ai raspuns corect la " + s + " intrebari");
                this.Hide();
                Form0 frm = new Form0();
                frm.ShowDialog();
            }
            label2.Text = "Scorul tau este: " + s + "/10";
            p = i + 2;
            pagina.Text = "Pagina: " + p;
            i++;
        }

        
    }
}
