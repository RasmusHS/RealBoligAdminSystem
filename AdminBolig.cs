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
    public partial class AdminBolig : Form
    {
        public AdminBolig()
        {
            InitializeComponent();
        }

        private void AdminBolig_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCreateBolig_Click(object sender, EventArgs e)
        {
            pContainer.Controls.Clear();
            CreateBolig frmCBolig = new CreateBolig() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmCBolig.FormBorderStyle = FormBorderStyle.None;
            this.pContainer.Controls.Add(frmCBolig);
            AdminBolig frmABolig = new AdminBolig();
            frmABolig.Hide();
            frmCBolig.Show();
        }

        
    }
}
