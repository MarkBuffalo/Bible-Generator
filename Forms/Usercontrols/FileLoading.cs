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
    public partial class FileLoading : UserControl
    {
        public FileLoading()
        {
            InitializeComponent();
        }

        public void SetProgressMaximum(int i)
        {
            this.pb_FileLoadingProgress.Maximum = i;
        }
        public void SetProgressCurrent(int i)
        {
            this.pb_FileLoadingProgress.Value = i;
        }

        public void IncrementProgress()
        {
            this.pb_FileLoadingProgress.PerformStep();
            this.lbl_CurrentFile.Text = "Current file: " + (this.pb_FileLoadingProgress.Value +1) + " of 3";
        }
    
    }
}
