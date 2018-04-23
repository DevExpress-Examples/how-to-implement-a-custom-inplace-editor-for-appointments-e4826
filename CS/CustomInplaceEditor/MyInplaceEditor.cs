using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraScheduler;

namespace SchedulerDbExample {
    #region #myinplaceeditor
    public partial class MyInplaceEditor : DevExpress.XtraEditors.XtraForm {
        Appointment appointment;
        SchedulerControl control;

        public MyInplaceEditor() {
            InitializeComponent();
            SubscribeKeyDownEvents();
        }
        public event EventHandler CommitChanges;
        public event EventHandler RollbackChanges;

        private void SubscribeKeyDownEvents() {
            appointmentLabelEdit1.KeyDown += new KeyEventHandler(AppointmentLabelEdit_KeyDown);
            edtSubject.KeyDown += new KeyEventHandler(Editor_KeyDown);
            edtDescription.KeyDown += new KeyEventHandler(Editor_KeyDown);
        }

        // Create a KeyDown event handler.
        // If the Enter key is pressed, save changes. If the ESC key is pressed, cancel changes.
        void Editor_KeyDown(object sender, KeyEventArgs e) {
            switch (e.KeyCode) {
                case Keys.Enter:
                    e.Handled = true;
                    OnCommitChanges();
                    break;
                case Keys.Escape:
                    e.Handled = true;
                    OnRollbackChanges();
                    break;
            }
        }

        public void AppointmentLabelEdit_KeyDown(object sender, KeyEventArgs e) {
            if (!appointmentLabelEdit1.IsPopupOpen)
                Editor_KeyDown(sender, e);
        }

        void OnCommitChanges() {
            if (CommitChanges != null)
                CommitChanges(this, EventArgs.Empty);
        }

        void OnRollbackChanges() {
            if (RollbackChanges != null)
                RollbackChanges(this, EventArgs.Empty);
        }
        protected override void OnShown(EventArgs e) {
            // Correct the text editor selection, which may result in overwriting the first typed character.
            SchedulerStorage storage = control.Storage;
            if (storage.Appointments.IsNewAppointment(appointment)) {
                edtSubject.SelectionLength = 0;
                edtSubject.SelectionStart = edtSubject.Text.Length;
            }
            base.OnShown(e);
        }

        // Fill the controls with appointment data. 
        public void FillForm(SchedulerControl control, Appointment appointment) {
            this.appointment = appointment;
            this.control = control;
            SchedulerStorage storage = control.Storage;
            this.appointmentLabelEdit1.Storage = storage;
            this.appointmentLabelEdit1.AppointmentLabel = storage.Appointments.Labels.GetById(appointment.LabelKey);
            this.edtSubject.Text = appointment.Subject;
            this.edtDescription.Text = appointment.Description;
        }
        // Save changes to the appointment.
        public void ApplyChanges() {
            appointment.Subject = edtSubject.Text;
            appointment.Description = edtDescription.Text;
            appointment.LabelKey = control.Storage.Appointments.Labels.IndexOf(appointmentLabelEdit1.AppointmentLabel);
        }
    }

    #endregion #myinplaceeditor
}