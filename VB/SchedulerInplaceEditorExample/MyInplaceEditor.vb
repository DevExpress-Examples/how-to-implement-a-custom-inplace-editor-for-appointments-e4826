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

Namespace SchedulerInplaceEditorExample
    #Region "#MyInplaceEditor"
    Partial Public Class MyInplaceEditor
        Inherits DevExpress.XtraEditors.XtraForm

        Private appointment As Appointment
        Private control As SchedulerControl

        Public Sub New(ByVal inplaceEditorArgs As SchedulerInplaceEditorEventArgs)
            InitializeComponent()
            Me.Text = String.Empty
            Me.ControlBox = False
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None
            SubscribeKeyDownEvents()
            Me.control = inplaceEditorArgs.Control
            If inplaceEditorArgs.UseFullCellEditor Then
                Me.Bounds = control.RectangleToScreen(inplaceEditorArgs.Bounds)
                Dim currentSkin As DevExpress.Skins.Skin = DevExpress.Skins.SchedulerSkins.GetSkin(control.LookAndFeel)
                Dim element As DevExpress.Skins.SkinElement = currentSkin(DevExpress.Skins.SchedulerSkins.SkinAllDayAreaSelected)
                Me.BackColor = element.Color.BackColor
                Me.ForeColor = Color.White
            Else
                Me.Bounds = AdjustEditorBounds(inplaceEditorArgs.Bounds)
                Me.BackColor = inplaceEditorArgs.BackColor
            End If
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
            Dim storage As SchedulerStorage = control.Storage
            Me.appointmentLabelEdit1.Storage = control.Storage
            Me.appointmentLabelEdit1.AppointmentLabel = storage.Appointments.Labels.GetById(appointment.LabelKey)
            Me.edtSubject.Text = appointment.Subject
            Me.edtDescription.Text = appointment.Description
        End Sub
        ' Save changes to the appointment.
        Public Sub ApplyChanges()
            appointment.Subject = edtSubject.Text
            appointment.Description = edtDescription.Text
            appointment.LabelKey = control.Storage.Appointments.Labels.IndexOf(appointmentLabelEdit1.AppointmentLabel)
        End Sub


        ' Set the size of inplace editor 
        Private Function AdjustEditorBounds(ByVal editorBounds As Rectangle) As Rectangle
            Dim screenControlBounds As Rectangle = control.Parent.RectangleToScreen(control.Bounds)
            editorBounds.Offset(0, -3)
            Dim screenEditorBounds As Rectangle = control.RectangleToScreen(editorBounds)

            Dim preferredSize As Size = GetPreferredSize(editorBounds.Size)
            Dim height As Integer = Math.Max(preferredSize.Height, editorBounds.Height)
            Dim width As Integer = preferredSize.Width

            Dim rect As Rectangle = screenEditorBounds
            rect.Offset(6, 0)

            Dim maxBottom As Integer = Math.Min(screenControlBounds.Bottom, rect.Top + height)
            Dim top As Integer = maxBottom - height

            Dim result As New Rectangle(rect.Left, top, width, height)
            If screenControlBounds.Right < rect.Right Then
                Dim horzOffset As Integer = If(TypeOf control.ActiveView Is DayView, 12, 8)
                result = New Rectangle(screenEditorBounds.Left - width - horzOffset, top, width, height)
            End If
            Return result
        End Function
    End Class
    #End Region ' #MyInplaceEditor
End Namespace