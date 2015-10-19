/*
Created by Matthew Ho
Created on 10-19-15
Created for ICS3U
Daily Task 3-12
This program uses For Each loops to change a property of all control objects.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForEachProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(Control aControl in this.Controls)
            {
                aControl.Text = "Hello World";
            }
        }
    }
}
