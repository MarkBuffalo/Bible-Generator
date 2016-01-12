using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibleProject.Forms.Usercontrols
{
    public partial class MySQL : UserControl
    {
        public MySQL()
        {
            InitializeComponent();
        }

        public string GetServerName() { return this.tb_Server.Text; }
        public string GetUsername() { return this.tb_Username.Text; }
        public string GetPassword() { return this.tb_Password.Text; }
        public string GetDatabase() {return this.tb_Database.Text; }
    }
}
