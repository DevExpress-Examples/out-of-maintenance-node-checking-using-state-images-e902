using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication69
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Control c = new DevExpress.XtraTreeList.Demos.Tutorials.NodeChecking();
            c.Dock = DockStyle.Fill;
            this.Controls.Add(c);
        }
    }
}