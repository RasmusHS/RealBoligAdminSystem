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

        /*public Panel MainPanel
        {
            get {return pContainer; }
            set {pContainer = value; }
        }*/

        private void AdminBolig_Load(object sender, EventArgs e)
        {

        }

        public void btnCreateBolig_Click(object sender, EventArgs e)
        {
            /*pContainer2.Controls.Clear();
            CreateBolig frmCBolig = new CreateBolig() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmCBolig.FormBorderStyle = FormBorderStyle.None;
            pContainer2.Controls.Add(frmCBolig);
            frmCBolig.Show();*/
            
            CreateBolig frmCBolig = new CreateBolig() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Hide();
            if(pContainer2.Visible == false)
            {
                MessageBox.Show("test");
            }
            //frmCBolig.Show();
            //Close();
        }
    }
}
