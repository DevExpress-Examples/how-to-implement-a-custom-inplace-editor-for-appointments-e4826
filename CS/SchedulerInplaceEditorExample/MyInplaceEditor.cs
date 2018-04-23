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

namespace SchedulerInplaceEditorExample {
    #region #MyInplaceEditor
    public partial class MyInplaceEditor : DevExpress.XtraEditors.XtraForm {
        Appointment appointment;
        SchedulerControl control;

        public MyInplaceEditor(SchedulerInplaceEditorEventArgs inplaceEditorArgs) {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            SubscribeKeyDownEvents();
            this.control = inplaceEditorArgs.Control;
            if (inplaceEditorArgs.UseFullCellEditor) {
                this.Bounds = control.RectangleToScreen(inplaceEditorArgs.Bounds);
                DevExpress.Skins.Skin currentSkin = DevExpress.Skins.SchedulerSkins.GetSkin(control.LookAndFeel);
                DevExpress.Skins.SkinElement element = currentSkin[DevExpress.Skins.SchedulerSkins.SkinAllDayAreaSelected];
                this.BackColor = element.Color.BackColor;
                this.ForeColor = Color.White;
            }
            else {
                this.Bounds = AdjustEditorBounds(inplaceEditorArgs.Bounds);
                this.BackColor = inplaceEditorArgs.BackColor;
            }            
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
            SchedulerStorage storage = control.Storage;
            this.appointmentLabelEdit1.Storage = control.Storage; 
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


        // Set the size of inplace editor 
        private Rectangle AdjustEditorBounds(Rectangle editorBounds) {
            Rectangle screenControlBounds = control.Parent.RectangleToScreen(control.Bounds);
            editorBounds.Offset(0, -3);
            Rectangle screenEditorBounds = control.RectangleToScreen(editorBounds);

            Size preferredSize = GetPreferredSize(editorBounds.Size);
            int height = Math.Max(preferredSize.Height, editorBounds.Height);
            int width = preferredSize.Width;

            Rectangle rect = screenEditorBounds;
            rect.Offset(6, 0);

            int maxBottom = Math.Min(screenControlBounds.Bottom, rect.Top + height);
            int top = maxBottom - height;

            Rectangle result = new Rectangle(rect.Left, top, width, height);
            if (screenControlBounds.Right < rect.Right) {
                int horzOffset = control.ActiveView is DayView ? 12 : 8;
                result = new Rectangle(screenEditorBounds.Left - width - horzOffset, top, width, height);
            }
            return result;
        }
    }
    #endregion #MyInplaceEditor
}