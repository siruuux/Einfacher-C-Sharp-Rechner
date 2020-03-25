using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Einfacher_Rechner_mit_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rBtnAdd.Checked = true;
        }

        private void btnRechnen_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txtZahl1.Text);
            double num2 = Convert.ToDouble(txtZahl2.Text);


            if (rBtnAdd.Checked == true)
            {
                double ergebnisAdd = num1 + num2;
                lblErgebnis.Text = "Ergebnis = " + ergebnisAdd;
            }

            else if (rBtnSub.Checked == true)
            {
                double ergebnisSub = num1 - num2;
                lblErgebnis.Text = "Ergebnis = " + ergebnisSub;
            }

            else if (rBtnMulti.Checked == true)
            {
                double ergebnisMulti = num1 * num2;
                lblErgebnis.Text = "Ergebnis = " + ergebnisMulti;
            }

            else if (rBtnDiv.Checked == true)
            {
                double ergebnisDiv = num1 / num2;
                lblErgebnis.Text = "Ergebnis = " + ergebnisDiv;
            }

            else lblErgebnis.Text = "Ergebnis = Fehler";
        }

        private void txtZahl1_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
