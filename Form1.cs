using System.Text.RegularExpressions;

namespace Bin2Dec
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_zero_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void btn_one_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            long myDecimal = Convert.ToInt64(textBox1.Text, 2);
            textBox2.Text = Convert.ToString(myDecimal);
        }

        private List<Keys> allowedKeys = new List<Keys>() { Keys.D0, Keys.D1, Keys.NumPad0, Keys.NumPad1, Keys.Back };

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = !allowedKeys.Contains(e.KeyCode);
        }
    }
}