using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MileageCalculator
{
    public partial class Form1 : Form
    {
        private int startingMileage;

        private int endingMileage;

        private double milesTraveled;

        private double reimburseRate = .39;

        private double amountOwed;

        public Form1()
        {
            InitializeComponent();
            label4.Text = "$0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            startingMileage = (int)numericUpDown1.Value;
            endingMileage = (int)numericUpDown2.Value;

            if (startingMileage <= endingMileage)
            {

                milesTraveled = endingMileage - startingMileage;
                amountOwed = milesTraveled * reimburseRate;
                label4.Text = "$" + amountOwed;
            }
            else
            {
                MessageBox.Show("A quilometragem inicial deve ser menor que a quilometragem final", "Impossível Calcular");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(milesTraveled + " miles", "Miles traveled");
        }
    }
}
