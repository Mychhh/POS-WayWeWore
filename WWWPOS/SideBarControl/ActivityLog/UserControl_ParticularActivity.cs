using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WWWPOS.SideBarControl.ActivityLog
{
    public partial class UserControl_ParticularActivity : UserControl
    {
        public UserControl_ParticularActivity(string whatHappend, string time)
        {
            InitializeComponent();

            lbl_WhatHappend.Text = whatHappend;
            lbl_Time.Text = time;

        }
    }
}
