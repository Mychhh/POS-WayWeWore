using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WWWPOS.SideBarControl
{
    public partial class UserControlActivityLog : UserControl
    {
        public UserControlActivityLog()
        {
            InitializeComponent();
        }

        private void UserControlActivityLog_Load(object sender, EventArgs e)
        {
            Class_LoadData C_LoadData = new Class_LoadData();
            C_LoadData.GetActivityLog();
        }
    }
}
