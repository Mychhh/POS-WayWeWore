﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using WWWPOS.SideBarControl.Inventory;
using System.Runtime.CompilerServices;
using System.Windows.Media;

namespace WWWPOS.SideBarControl
{
    public partial class UserControlInventory : UserControl
    {
        public UserControlInventory()
        {
            InitializeComponent();
        }

        private void UserControlInventory_Load(object sender, EventArgs e)
        {

            UserControlRead UC_Read = new UserControlRead();
            panel_Inventory.Controls.Clear();
            panel_Inventory.Controls.Add(UC_Read);
            UC_Read.Dock = DockStyle.Fill;
        }

        private void btn_AddProduct_Click(object sender, EventArgs e)
        {
            UserControlCreate UC_Create = new UserControlCreate();

            panel_Inventory.Controls.Clear();
            panel_Inventory.Controls.Add(UC_Create);
            UC_Create.Dock = DockStyle.Fill;
        }

        private void btn_UpdateProduct_Click(object sender, EventArgs e)
        {
            UserControlViewUpdate UC_ViewUpdate = new UserControlViewUpdate();
            panel_Inventory.Controls.Clear();
            panel_Inventory.Controls.Add(UC_ViewUpdate);
            UC_ViewUpdate.Dock = DockStyle.Fill;

            //Loads product item
            Class_LoadData LD = new Class_LoadData();
            LD.selectProduct(UC_ViewUpdate.flowLayoutPanel, "panelEdit");
        }
        
        private void btn_DeleteProduct_Click_1(object sender, EventArgs e)
        {
            UserControlDelete UC_Delete = new UserControlDelete();
            panel_Inventory.Controls.Clear();
            panel_Inventory.Controls.Add(UC_Delete);
            UC_Delete.Dock = DockStyle.Fill;

            Class_LoadData LD = new Class_LoadData();
            LD.selectProduct(UC_Delete.flowLayoutPanel, "panelDelete");
        }

    }
}
