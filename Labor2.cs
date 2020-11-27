using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaarmaVisualProgram
{
    public partial class Labor2 : Form
    {
        public Labor2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Labor1 Main = this.Owner as Labor1;

            if (textBox1.Text != "")
            {
                if (this.radioButton1.Checked == true)
                Main.listBox1.Items.Add(this.textBox1.Text);
                else Main.listBox2.Items.Add(this.textBox1.Text);

                this.Close();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
