using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public partial class Time : Form
    {
        public Time()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {           
            
        }

        private void TimeToNewYear(object sender, EventArgs e)
        {
            var timeNow = DateTime.Now;
            var timeNew = new DateTime(2023, 01, 01, 0, 0, 0);

            TimeSpan segment = timeNew - timeNow;

            textBox1.Text = segment.ToString().Substring(0, 11);
        }
    }
}
