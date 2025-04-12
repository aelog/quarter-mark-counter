using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quarter_Mark_Counter_GUI.NET_
{
    public partial class Form1 : Form
    {

        public float inp_mark = 0;
        public float inp_coef = 0;
        public string q_m = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                inp_coef = Convert.ToSingle(((TextBox)sender).Text);
            }
            catch (System.FormatException)
            {
                inp_coef = 0;
            }
        }

        private void count_button_Click(object sender, EventArgs e)
        {
            q_m = Program.count_mark(inp_mark, inp_coef);
            MessageBox.Show($"Your quarter mark is {q_m}", "Quarter mark");
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            inp_mark = Convert.ToSingle(numericUpDown1.Value);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1.5 - Admin. CW, Practic CW, CW, Control Dictation, Class essay, Test.\r\n1.4 - Audition, Home essay, Vocabulary Dictation, Exposition.\r\n1.3 - Lab. work, Practic Work, Verification Work.\r\n1.2 - Independent Work.\r\n1.0 - Work on the lesson, HW, Test, Labeling, Dist. lesson, E+Learning.", "Coefficients");
        }

        private void Reset_button_Click(object sender, EventArgs e)
        {
            Program.reset();
        }

        private void watch_button_Click(object sender, EventArgs e)
        {
            q_m = Program.count_mark(0, 0);
            MessageBox.Show($"Your quarter mark is {q_m}", "Quarter mark");
        }

        private void about_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Quarter Mark Counter v. 1.0\n" +
                "This program is licensed under the MIT license.\n" +
                "(C) AntELO, 2025. All right reserved", "О программе");
        }
    }
}
