using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ZIO
{
    public partial class ZIO : Form
    {
        public ZIO()
        {
            InitializeComponent();
        }

        private void ZIO_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
        }
    }
}
