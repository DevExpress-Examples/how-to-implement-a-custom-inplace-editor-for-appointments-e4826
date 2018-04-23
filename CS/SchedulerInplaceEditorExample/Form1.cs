using DevExpress.XtraScheduler;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SchedulerInplaceEditorExample {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'schedulerTestDataSet.Resources' table. You can move, or remove it, as needed.
            this.resourcesTableAdapter.Fill(this.schedulerTestDataSet.Resources);
            // TODO: This line of code loads data into the 'schedulerTestDataSet.Appointments' table. You can move, or remove it, as needed.
            this.appointmentsTableAdapter.Fill(this.schedulerTestDataSet.Appointments);

            schedulerControl1.Start = DateTime.Today;
            schedulerControl1.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.Day;
            schedulerControl1.DayView.TopRowTime = new TimeSpan(10, 0, 0);
            schedulerControl1.GroupType = DevExpress.XtraScheduler.SchedulerGroupType.Resource;
            schedulerControl1.DayView.ResourcesPerPage = 2;
            schedulerControl1.DayView.TimeIndicatorDisplayOptions.ShowOverAppointment = true;


            this.schedulerStorage1.AppointmentsChanged += OnAppointmentChangedInsertedDeleted;
            this.schedulerStorage1.AppointmentsInserted += OnAppointmentChangedInsertedDeleted;
            this.schedulerStorage1.AppointmentsDeleted += OnAppointmentChangedInsertedDeleted;

            this.schedulerControl1.InplaceEditorShowing += SchedulerControl1_InplaceEditorShowing;
        }
        #region #inplaceeditorshowing
        private void SchedulerControl1_InplaceEditorShowing(object sender, InplaceEditorEventArgs e) {
            e.InplaceEditorEx = new MyInplaceEditorControl(e.SchedulerInplaceEditorEventArgs);
        }
        #endregion #inplaceeditorshowing

        private void OnAppointmentChangedInsertedDeleted(object sender, PersistentObjectsEventArgs e) {
            appointmentsTableAdapter.Update(schedulerTestDataSet);
            schedulerTestDataSet.AcceptChanges();
        }
    }
}
