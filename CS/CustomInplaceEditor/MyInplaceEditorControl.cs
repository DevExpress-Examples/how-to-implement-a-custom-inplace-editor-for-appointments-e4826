using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraScheduler;

namespace SchedulerDbExample {
    #region #myinplaceeditorcontrol
    public class MyInplaceEditorControl : ISchedulerInplaceEditorEx {
        MyInplaceEditor editor;
        Appointment appointment;
        SchedulerControl control;

        public MyInplaceEditorControl(SchedulerInplaceEditorEventArgs inplaceEditorArgs) {
            this.appointment = inplaceEditorArgs.ViewInfo.Appointment;
            this.control = inplaceEditorArgs.Control;
            CreateEditor(inplaceEditorArgs);
        }

        MyInplaceEditor Editor { get { return editor; } }
        Appointment Appointment { get { return appointment; } }
        SchedulerControl Control { get { return control; } }

        public event EventHandler CommitChanges;
        public event EventHandler RollbackChanges;

        void CreateEditor(SchedulerInplaceEditorEventArgs inplaceEditorArgs) {
            this.editor = new MyInplaceEditor();
            Editor.Bounds = AdjustEditorBounds(inplaceEditorArgs.Control, inplaceEditorArgs.Bounds);
        }

        // Set the size of inplace editor 
        private Rectangle AdjustEditorBounds(SchedulerControl control, Rectangle editorBounds) {
            Rectangle screenControlBounds = control.Parent.RectangleToScreen(control.Bounds);
            editorBounds.Offset(0, -3);
            Rectangle screenEditorBounds = control.RectangleToScreen(editorBounds);

            Size preferredSize = editor.GetPreferredSize(editorBounds.Size);
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
        // Interface implementation 
        public void Dispose() {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        ~MyInplaceEditorControl() {
            Dispose(false);
        }
        protected virtual void Dispose(bool disposing) {
            if (disposing) {
                if (Editor != null) {
                    Editor.Dispose();
                    this.editor = null;
                }
                this.appointment = null;
            }
        }
        public virtual void Activate() {
            Editor.FillForm(control, appointment);
            SubscribeEditorEvents();
            Editor.Show(Control.FindForm());
        }
        public virtual void Deactivate() {
            UnsibscribeEditorEvents();
            Editor.Close();
        }
        public virtual void ApplyChanges() {
            Editor.ApplyChanges();
        }
        protected internal virtual void SubscribeEditorEvents() {
            Editor.FormClosed += new FormClosedEventHandler(Editor_FormClosed);
            Editor.Deactivate += new EventHandler(Editor_Deactivate);
            Editor.CommitChanges += new EventHandler(Editor_CommitChanges);
            Editor.RollbackChanges += new EventHandler(Editor_RollbackChanges);
        }

        protected internal virtual void UnsibscribeEditorEvents() {
            Editor.FormClosed -= new FormClosedEventHandler(Editor_FormClosed);
            Editor.Deactivate -= new EventHandler(Editor_Deactivate);
            Editor.CommitChanges -= new EventHandler(Editor_CommitChanges);
            Editor.RollbackChanges -= new EventHandler(Editor_RollbackChanges);
        }
        void Editor_FormClosed(object sender, FormClosedEventArgs e) {
            OnCommitChanges();
        }

        void Editor_Deactivate(object sender, EventArgs e) {
            OnCommitChanges();
        }


        void Editor_RollbackChanges(object sender, EventArgs e) {
            OnRollbackChanges();
        }

        void Editor_CommitChanges(object sender, EventArgs e) {
            OnCommitChanges();
        }
        protected internal virtual void TextBox_LostFocus(object sender, EventArgs e) {
            Editor.Close();
            OnCommitChanges();
        }

        protected internal virtual void OnRollbackChanges() {
            if (RollbackChanges != null)
                RollbackChanges(this, EventArgs.Empty);
        }
        protected internal virtual void OnCommitChanges() {
            RaiseCommitChanges();
        }
        protected internal virtual void RaiseCommitChanges() {
            if (CommitChanges != null)
                CommitChanges(this, EventArgs.Empty);
        }
    }
    #endregion #myinplaceeditorcontrol
}
