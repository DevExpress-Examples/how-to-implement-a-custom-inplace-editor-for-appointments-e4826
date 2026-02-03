'#Region "#myinplaceeditor"
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraScheduler

Namespace SchedulerCustomInplaceEditor

    Public Partial Class MyInplaceEditor
        Inherits DevExpress.XtraEditors.XtraForm

        Private appointment As Appointment

        Private control As SchedulerControl

        Public Sub New()
            InitializeComponent()
            SubscribeKeyDownEvents()
        End Sub

        Public Event CommitChanges As EventHandler

        Public Event RollbackChanges As EventHandler

        Private Sub SubscribeKeyDownEvents()
            AddHandler appointmentLabelEdit1.KeyDown, New KeyEventHandler(AddressOf AppointmentLabelEdit_KeyDown)
            AddHandler edtSubject.KeyDown, New KeyEventHandler(AddressOf Editor_KeyDown)
            AddHandler edtDescription.KeyDown, New KeyEventHandler(AddressOf Editor_KeyDown)
        End Sub

        ' Create a KeyDown event handler.
        ' If the Enter key is pressed, save changes. If the ESC key is pressed, cancel changes.
        Private Sub Editor_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
            Select Case e.KeyCode
                Case Keys.Enter
                    e.Handled = True
                    OnCommitChanges()
                Case Keys.Escape
                    e.Handled = True
                    OnRollbackChanges()
            End Select
        End Sub

        Public Sub AppointmentLabelEdit_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
            If Not appointmentLabelEdit1.IsPopupOpen Then Editor_KeyDown(sender, e)
        End Sub

        Private Sub OnCommitChanges()
            RaiseEvent CommitChanges(Me, EventArgs.Empty)
        End Sub

        Private Sub OnRollbackChanges()
            RaiseEvent RollbackChanges(Me, EventArgs.Empty)
        End Sub

        Protected Overrides Sub OnShown(ByVal e As EventArgs)
            ' Correct the text editor selection, which may result in overwriting the first typed character.
            Dim storage As SchedulerStorage = control.Storage
            If storage.Appointments.IsNewAppointment(appointment) Then
                edtSubject.SelectionLength = 0
                edtSubject.SelectionStart = edtSubject.Text.Length
            End If

            MyBase.OnShown(e)
        End Sub

        ' Fill the controls with appointment data. 
        Public Sub FillForm(ByVal control As SchedulerControl, ByVal appointment As Appointment)
            Me.appointment = appointment
            Me.control = control
            Dim storage As SchedulerStorage = control.Storage
            appointmentLabelEdit1.Storage = storage
            appointmentLabelEdit1.Label = storage.Appointments.Labels(appointment.LabelId)
            edtSubject.Text = appointment.Subject
            edtDescription.Text = appointment.Description
        End Sub

        ' Save changes to the appointment.
        Public Sub ApplyChanges()
            appointment.Subject = edtSubject.Text
            appointment.Description = edtDescription.Text
            appointment.LabelId = control.Storage.Appointments.Labels.IndexOf(appointmentLabelEdit1.Label)
        End Sub
    End Class
End Namespace
'#End Region  ' #myinplaceeditor
