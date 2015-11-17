using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algor1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            label5.Text = "???ms";
            richTextBox1.Text = "???";
            sw.Reset();
            sw.Start();
            List<int> resultList = Algor.GetNumberListByList((int)numericUpDownN.Value, (int)numericUpDownS.Value, (int)numericUpDownI.Value, (int)numericUpDownT.Value);
            sw.Stop();
            label5.Text = (sw.Elapsed.TotalMilliseconds.ToString() + " ms").ToString();
            richTextBox1.Text = string.Join(",", resultList.ToArray());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            label5.Text = "???ms";
            richTextBox1.Text = "???";
            sw.Reset();
            sw.Start();
            int[] array = Algor.GetNumberListByArray((int)numericUpDownN.Value, (int)numericUpDownS.Value, (int)numericUpDownI.Value, (int)numericUpDownT.Value);
            sw.Stop();
            label5.Text = (sw.Elapsed.TotalMilliseconds.ToString() + " ms").ToString();
            richTextBox1.Text = string.Join(",", array);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            label5.Text = "???ms";
            richTextBox1.Text = "???";
            sw.Reset();
            sw.Start();
            List<int> resultList = Algor.GetNumberListByArrayWithNotRemove((int)numericUpDownN.Value, (int)numericUpDownS.Value, (int)numericUpDownI.Value, (int)numericUpDownT.Value);
            sw.Stop();
            label5.Text = (sw.Elapsed.TotalMilliseconds.ToString() + " ms").ToString();
            richTextBox1.Text = string.Join(",", resultList.ToArray());
        }
    }
}
