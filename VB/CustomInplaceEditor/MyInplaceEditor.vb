Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraScheduler

Namespace SchedulerDbExample
#Region "#myinplaceeditor"
    Partial Public Class MyInplaceEditor
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
            AddHandler appointmentLabelEdit1.KeyDown, AddressOf AppointmentLabelEdit_KeyDown
            AddHandler edtSubject.KeyDown, AddressOf Editor_KeyDown
            AddHandler edtDescription.KeyDown, AddressOf Editor_KeyDown
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
            If Not appointmentLabelEdit1.IsPopupOpen Then
                Editor_KeyDown(sender, e)
            End If
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
            Me.appointmentLabelEdit1.Storage = storage
            Me.appointmentLabelEdit1.Label = storage.Appointments.Labels.GetById(appointment.LabelKey)
            Me.edtSubject.Text = appointment.Subject
            Me.edtDescription.Text = appointment.Description
        End Sub
        ' Save changes to the appointment.
        Public Sub ApplyChanges()
            appointment.Subject = edtSubject.Text
            appointment.Description = edtDescription.Text
            appointment.LabelKey = control.Storage.Appointments.Labels.IndexOf(appointmentLabelEdit1.Label)
        End Sub
    End Class
#End Region
End Namespace