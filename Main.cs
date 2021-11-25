using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealBolig
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home frm1 = new Home() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frm1.FormBorderStyle = FormBorderStyle.None;
            this.pContainer.Controls.Add(frm1);
            frm1.Show();
        }

        private void btnBolig_Click(object sender, EventArgs e)
        {
            AdminBolig frm2 = new AdminBolig() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frm2.FormBorderStyle = FormBorderStyle.None;
            this.pContainer.Controls.Add(frm2);
            frm2.Show();
        }
    }
}
