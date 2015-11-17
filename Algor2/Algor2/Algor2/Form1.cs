using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algor2
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
            label3.Text = "???ms";
            label4.Text = "Total is ";
            richTextBox1.Text = "";
            sw.Reset();
            sw.Start();
            List<int> resultList = primeNumbers.calPrimeNumber1((int)numericUpDown1.Value, (int)numericUpDown2.Value);
            sw.Stop();
            label3.Text = (sw.Elapsed.TotalMilliseconds.ToString() + " ms").ToString();
            label4.Text = "Total is " + resultList.Count;
            //sw.Reset();
            //sw.Start();
            /*DataTable dt = new DataTable();
            dt.Columns.Add("prime", typeof(int));
            foreach (var item in resultList)
                dt.Rows.Add(item);

            this.listView1.DataBindings.Add("Prime", dt, "prime");*/


            new System.Threading.Tasks.TaskFactory().StartNew(() => {
                string a = string.Join(",", resultList.ToArray());
                //sw.Stop();
                //Console.WriteLine((sw.Elapsed.TotalMilliseconds.ToString() + " ms").ToString());
                richTextBox1.Invoke((MethodInvoker)delegate {
                    sw.Reset();
                    sw.Start();
                    richTextBox1.AppendText(a);
                    sw.Stop();
                    Console.WriteLine((sw.Elapsed.TotalMilliseconds.ToString() + " ms").ToString());
                }
                );
            });
        }


    }
}
