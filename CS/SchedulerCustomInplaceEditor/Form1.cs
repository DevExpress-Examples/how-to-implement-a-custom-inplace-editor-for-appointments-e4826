using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraScheduler;

namespace SchedulerCustomInplaceEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region #inplaceeditorshowing
        private void schedulerControl1_InplaceEditorShowing(object sender, InplaceEditorEventArgs e)
        {
            e.InplaceEditorEx = new MyInplaceEditorControl(e.SchedulerInplaceEditorEventArgs);
        }
        #endregion #inplaceeditorshowing
    }
}
