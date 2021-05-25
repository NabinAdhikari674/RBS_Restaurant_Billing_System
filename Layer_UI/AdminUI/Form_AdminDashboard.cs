using RBS_Restaurant_Billing_System.Layer_UI.AdminUI;
using RBS_Restaurant_Billing_System.Layer_UI.AdminUI.MoreUI;
using RBS_Restaurant_Billing_System.Layer_UI.AdminUI.ProductsUI;
using RBS_Restaurant_Billing_System.Layer_UI.AdminUI.TransactionsUI;
using RBS_Restaurant_Billing_System.Layer_UI.AdminUI.UsersUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RBS_Restaurant_Billing_System.Layer_UI
{
    public partial class Form_AdminDashboard : Form
    {
        private Form activeForm = null;
        public Form_AdminDashboard()
        {
            InitializeComponent();
            hideAllSubMenus();
        }


        #region MENU HIDE/UNHIDE
        private void hideAllSubMenus()
        {
            sbm_btn_User_AD.Visible = false;
            sbm_btn_Products_AD.Visible = false;
        }
        private void hideSubMenu()
        {
            if (sbm_btn_User_AD.Visible == true)
                sbm_btn_User_AD.Visible = false;
            if (sbm_btn_Products_AD.Visible == true)
                sbm_btn_Products_AD.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }

        }
        #endregion


        private void openContainerForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnl_Container_AD.Controls.Add(childForm);
            pnl_Container_AD.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }




        #region USER BUTTONS
        private void btn_Users_AD_Click(object sender, EventArgs e)
        {
            showSubMenu(sbm_btn_User_AD);
        }
        private void btn_viewUsers_frmAD_Click(object sender, EventArgs e)
        {
            openContainerForm(new Form_ViewUsers());
        }
        private void btn_AddUsers_frmAD_Click(object sender, EventArgs e)
        {
            openContainerForm(new Form_AddUsers());
        }

        private void btn_removeUsers_frmAD_Click(object sender, EventArgs e)
        {
            openContainerForm(new Form_DeleteUsers());
        }
        #endregion





        #region PRODUCT BUTTONS
        private void btn_Product_AD_Click(object sender, EventArgs e)
        {
            showSubMenu(sbm_btn_Products_AD);
        }

        private void btn_viewProducts_frmAD_Click(object sender, EventArgs e)
        {
            openContainerForm(new Form_ViewProducts());
        }

        private void btn_pMgmt_frmAD_Click(object sender, EventArgs e)
        {
            openContainerForm(new Form_ManageProducts());
        }
        #endregion



        private void btn_Transactions_AD_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openContainerForm(new Form_Transactions());
        }

        private void btn_More_AD_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openContainerForm(new Form_More());
        }

        private void btn_About_frmAD_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openContainerForm(new Form_About());
        }
    }
}
