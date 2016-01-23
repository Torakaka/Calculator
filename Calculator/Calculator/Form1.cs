using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string Anzeige;

        double [] zahl = new double[100];

        private void zahl1Button_Click(object sender, EventArgs e)
        {
            Anzeige = Anzeige + Convert.ToString(1);
            AnzeigeTextBox.Text = Anzeige;
        }

        private void zahl2Button_Click(object sender, EventArgs e)
        {
            Anzeige = Anzeige + Convert.ToString(2);
            AnzeigeTextBox.Text = Anzeige;
        }

        private void zahl3Button_Click(object sender, EventArgs e)
        {
            Anzeige = Anzeige + Convert.ToString(3);
            AnzeigeTextBox.Text = Anzeige;
        }

        private void zahl4Button_Click(object sender, EventArgs e)
        {
            Anzeige = Anzeige + Convert.ToString(4);
            AnzeigeTextBox.Text = Anzeige;
        }

        private void zahl5Button_Click(object sender, EventArgs e)
        {
            Anzeige = Anzeige + Convert.ToString(5);
            AnzeigeTextBox.Text = Anzeige;
        }

        private void zahl6Button_Click(object sender, EventArgs e)
        {
            Anzeige = Anzeige + Convert.ToString(6);
            AnzeigeTextBox.Text = Anzeige;
        }

        private void zahl7Button_Click(object sender, EventArgs e)
        {
            Anzeige = Anzeige + Convert.ToString(7);
            AnzeigeTextBox.Text = Anzeige;
        }

        private void zahl8Button_Click(object sender, EventArgs e)
        {
            Anzeige = Anzeige + Convert.ToString(8);
            AnzeigeTextBox.Text = Anzeige;
        }

        private void zahl9Button_Click(object sender, EventArgs e)
        {
            Anzeige = Anzeige + Convert.ToString(9);
            AnzeigeTextBox.Text = Anzeige;
        }

        private void zahl0Button_Click(object sender, EventArgs e)
        {
            Anzeige = Anzeige + Convert.ToString(0);
            AnzeigeTextBox.Text = Anzeige;
        }
    }
}
