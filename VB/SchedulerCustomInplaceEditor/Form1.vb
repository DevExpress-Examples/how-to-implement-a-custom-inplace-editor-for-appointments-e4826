Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraScheduler

Namespace SchedulerCustomInplaceEditor

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
            AddHandler schedulerStorage1.AppointmentsChanged, AddressOf OnAppointmentChangedInsertedDeleted
            AddHandler schedulerStorage1.AppointmentsInserted, AddressOf OnAppointmentChangedInsertedDeleted
            AddHandler schedulerStorage1.AppointmentsDeleted, AddressOf OnAppointmentChangedInsertedDeleted
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            ' TODO: This line of code loads data into the 'scheduleTestDataSet.Resources' table. You can move, or remove it, as needed.
            resourcesTableAdapter.Fill(scheduleTestDataSet.Resources)
            ' TODO: This line of code loads data into the 'scheduleTestDataSet.Appointments' table. You can move, or remove it, as needed.
            appointmentsTableAdapter.Fill(scheduleTestDataSet.Appointments)
        End Sub

        Private Sub OnAppointmentChangedInsertedDeleted(ByVal sender As Object, ByVal e As PersistentObjectsEventArgs)
            appointmentsTableAdapter.Update(scheduleTestDataSet)
            scheduleTestDataSet.AcceptChanges()
        End Sub

'#Region "#inplaceeditorshowing"
        Private Sub schedulerControl1_InplaceEditorShowing(ByVal sender As Object, ByVal e As InplaceEditorEventArgs)
            e.InplaceEditorEx = New MyInplaceEditorControl(e.SchedulerInplaceEditorEventArgs)
        End Sub
'#End Region  ' #inplaceeditorshowing
    End Class
End Namespace
