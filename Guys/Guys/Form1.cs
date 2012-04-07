using System.Windows.Forms;

namespace Guys
{
    public partial class Form1 : Form
    {
        private Guy joe;

        private Guy bob;

        private int bank = 100;

        public void UpdateForm()
        {
            joesCashLabel.Text = joe.Name + " has $" + joe.Cash;
            bobsCashLabel.Text = bob.Name + " has $" + bob.Cash;
            bankCashLabel.Text = "The bank has $" + bank;
        }

        public Form1()
        {
            InitializeComponent();

            bob = new Guy { Name = "Bob", Cash = 100 };
            joe = new Guy { Name = "Joe", Cash = 50 };

            UpdateForm();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            if (bank >= 10)
            {
                bank -= joe.ReceiveCash(10);
                UpdateForm();
            }
            else
            {
                MessageBox.Show("The bank is out of money.");
            }
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            bank += bob.GiveCash(5);
            UpdateForm();
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            bob.ReceiveCash(joe.GiveCash(10));
            UpdateForm();
        }

        private void button4_Click(object sender, System.EventArgs e)
        {
            joe.ReceiveCash(bob.GiveCash(5));
            UpdateForm();
        }
    }
}
