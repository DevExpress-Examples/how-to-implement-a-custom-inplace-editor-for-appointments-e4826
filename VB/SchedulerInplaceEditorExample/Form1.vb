Imports DevExpress.XtraScheduler
Imports System
Imports System.Drawing
Imports System.Windows.Forms

Namespace SchedulerInplaceEditorExample
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            ' TODO: This line of code loads data into the 'schedulerTestDataSet.Resources' table. You can move, or remove it, as needed.
            Me.resourcesTableAdapter.Fill(Me.schedulerTestDataSet.Resources)
            ' TODO: This line of code loads data into the 'schedulerTestDataSet.Appointments' table. You can move, or remove it, as needed.
            Me.appointmentsTableAdapter.Fill(Me.schedulerTestDataSet.Appointments)

            schedulerControl1.Start = Date.Today
            schedulerControl1.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.Day
            schedulerControl1.DayView.TopRowTime = New TimeSpan(10, 0, 0)
            schedulerControl1.GroupType = DevExpress.XtraScheduler.SchedulerGroupType.Resource
            schedulerControl1.DayView.ResourcesPerPage = 2
            schedulerControl1.DayView.TimeIndicatorDisplayOptions.ShowOverAppointment = True


            AddHandler Me.schedulerStorage1.AppointmentsChanged, AddressOf OnAppointmentChangedInsertedDeleted
            AddHandler Me.schedulerStorage1.AppointmentsInserted, AddressOf OnAppointmentChangedInsertedDeleted
            AddHandler Me.schedulerStorage1.AppointmentsDeleted, AddressOf OnAppointmentChangedInsertedDeleted

            AddHandler Me.schedulerControl1.InplaceEditorShowing, AddressOf SchedulerControl1_InplaceEditorShowing
        End Sub
        #Region "#inplaceeditorshowing"
        Private Sub SchedulerControl1_InplaceEditorShowing(ByVal sender As Object, ByVal e As InplaceEditorEventArgs)
            e.InplaceEditorEx = New MyInplaceEditorControl(e.SchedulerInplaceEditorEventArgs)
        End Sub
        #End Region ' #inplaceeditorshowing

        Private Sub OnAppointmentChangedInsertedDeleted(ByVal sender As Object, ByVal e As PersistentObjectsEventArgs)
            appointmentsTableAdapter.Update(schedulerTestDataSet)
            schedulerTestDataSet.AcceptChanges()
        End Sub
    End Class
End Namespace
