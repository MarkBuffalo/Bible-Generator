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
    public partial class SQLServer : UserControl
    {
        public SQLServer()
        {
            InitializeComponent();
        }

        public string GetConnectionString() { return this.rtb_ConnectionString.Text; }
    }
}
