﻿using System;
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
            SubMenuStart();
        }

        private void SubMenuStart()
        {
            panelBoligSubMenu.Visible = false;
            panelKunderSubMenu.Visible = false;
            panelMæglerSubMenu.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelBoligSubMenu.Visible == true)
                panelBoligSubMenu.Visible = false;
            if (panelKunderSubMenu.Visible == true)
                panelKunderSubMenu.Visible = false;
            if (panelMæglerSubMenu.Visible == true)
                panelMæglerSubMenu.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }




        private void btnHome_Click_1(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            hideSubMenu();
            //flere koder
        }

        private void btnBolig_Click(object sender, EventArgs e)
        {
            showSubMenu(panelBoligSubMenu);
        }

        #region BoligSubMenu

        private void btnSubMenuOpretBolig_Click(object sender, EventArgs e)
        {
            openFormsLoader(new CreateBolig());

            /* Hvis submenuen ønskes at hides når der trykkes
            hideSubMenu();
            */
        }

        private void btnSubMenuIndlæsBolig_Click(object sender, EventArgs e)
        {
            openFormsLoader(new ReadBolig());

            /* Hvis submenuen ønskes at hides når der trykkes
            hideSubMenu();
            */
        }

        private void btnSubMenuOpdaterBolig_Click(object sender, EventArgs e)
        {
            openFormsLoader(new UpdateBolig());

            /* Hvis submenuen ønskes at hides når der trykkes
            hideSubMenu();
            */
        }

        private void btnSubMenuSletBolig_Click(object sender, EventArgs e)
        {
            openFormsLoader(new DeleteBolig());

            /* Hvis submenuen ønskes at hides når der trykkes
            hideSubMenu();
            */
        }

        #endregion

        private void btnKunder_Click(object sender, EventArgs e)
        {
            showSubMenu(panelKunderSubMenu);
        }

        #region KunderSubMenu

        private void btnSubMenuOpretKunde_Click(object sender, EventArgs e)
        {
            openFormsLoader(new CreateKunde());

            /* Hvis submenuen ønskes at hides når der trykkes
            hideSubMenu();
            */
        }

        private void btnSubMenuIndlæsKunde_Click(object sender, EventArgs e)
        {
            openFormsLoader(new ReadKunde());

            /* Hvis submenuen ønskes at hides når der trykkes
            hideSubMenu();
            */
        }

        private void btnSubMenuOpdaterKunde_Click(object sender, EventArgs e)
        {
            openFormsLoader(new UpdateKunde());

            /* Hvis submenuen ønskes at hides når der trykkes
            hideSubMenu();
            */
        }

        private void btnSubMenuSletKunde_Click(object sender, EventArgs e)
        {
            openFormsLoader(new DeleteKunde());

            /* Hvis submenuen ønskes at hides når der trykkes
            hideSubMenu();
            */
        }

        #endregion

        private void btnMægler_Click_1(object sender, EventArgs e)
        {
            showSubMenu(panelMæglerSubMenu);
        }

        #region MæglerSubMenu
        private void button12_Click_1(object sender, EventArgs e)
        {
            //Indtast kode

            /* Hvis submenuen ønskes at hides når der trykkes
            hideSubMenu();
            */
        }


        private void button11_Click_1(object sender, EventArgs e)
        {
            //Indtast kode

            /* Hvis submenuen ønskes at hides når der trykkes
            hideSubMenu();
            */
        }


        private void button10_Click(object sender, EventArgs e)
        {
            //Indtast kode

            /* Hvis submenuen ønskes at hides når der trykkes
            hideSubMenu();
            */
        }


        private void button9_Click(object sender, EventArgs e)
        {
            //Indtast kode

            /* Hvis submenuen ønskes at hides når der trykkes
            hideSubMenu();
            */
        }

        #endregion

        private void btnHjælp_Click_1(object sender, EventArgs e)
        {
            //indtast kode til den form den skal linke til

            hideSubMenu();
        }

        private Form activeForm = null;
        private void openFormsLoader(Form loadedForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = loadedForm;
            loadedForm.TopLevel = false;
            loadedForm.FormBorderStyle = FormBorderStyle.None;
            loadedForm.Dock = DockStyle.Fill;
            panelFormsLoader.Controls.Add(loadedForm);
            panelFormsLoader.Tag = loadedForm;
            loadedForm.BringToFront();
            loadedForm.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


    }
}
