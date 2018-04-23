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

            this.schedulerStorage1.AppointmentsChanged += OnAppointmentChangedInsertedDeleted;
            this.schedulerStorage1.AppointmentsInserted += OnAppointmentChangedInsertedDeleted;
            this.schedulerStorage1.AppointmentsDeleted += OnAppointmentChangedInsertedDeleted;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'scheduleTestDataSet.Resources' table. You can move, or remove it, as needed.
            this.resourcesTableAdapter.Fill(this.scheduleTestDataSet.Resources);
            // TODO: This line of code loads data into the 'scheduleTestDataSet.Appointments' table. You can move, or remove it, as needed.
            this.appointmentsTableAdapter.Fill(this.scheduleTestDataSet.Appointments);

        }

        private void OnAppointmentChangedInsertedDeleted(object sender, PersistentObjectsEventArgs e)
        {
            appointmentsTableAdapter.Update(scheduleTestDataSet);
            scheduleTestDataSet.AcceptChanges();
        }
        #region #inplaceeditorshowing
        private void schedulerControl1_InplaceEditorShowing(object sender, InplaceEditorEventArgs e)
        {
            e.InplaceEditorEx = new MyInplaceEditorControl(e.SchedulerInplaceEditorEventArgs);
        }
        #endregion #inplaceeditorshowing
    }
}
