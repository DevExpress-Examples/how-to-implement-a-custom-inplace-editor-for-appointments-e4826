Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraScheduler

Namespace SchedulerCustomInplaceEditor_VB
    Public Class Form1
        Public Sub New()
            InitializeComponent()

            AddHandler Me.SchedulerStorage1.AppointmentsChanged, AddressOf OnAppointmentChangedInsertedDeleted
            AddHandler Me.SchedulerStorage1.AppointmentsInserted, AddressOf OnAppointmentChangedInsertedDeleted
            AddHandler Me.SchedulerStorage1.AppointmentsDeleted, AddressOf OnAppointmentChangedInsertedDeleted
        End Sub
        Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            'TODO: This line of code loads data into the 'ScheduleTestDataSet.Resources' table. You can move, or remove it, as needed.
            Me.ResourcesTableAdapter.Fill(Me.ScheduleTestDataSet.Resources)
            'TODO: This line of code loads data into the 'ScheduleTestDataSet.Appointments' table. You can move, or remove it, as needed.
            Me.AppointmentsTableAdapter.Fill(Me.ScheduleTestDataSet.Appointments)

        End Sub
        Private Sub OnAppointmentChangedInsertedDeleted(ByVal sender As Object, ByVal e As PersistentObjectsEventArgs)
            appointmentsTableAdapter.Update(scheduleTestDataSet)
            scheduleTestDataSet.AcceptChanges()
        End Sub
#Region "#inplaceeditorshowing"
        Private Sub schedulerControl1_InplaceEditorShowing(ByVal sender As Object, ByVal e As InplaceEditorEventArgs) Handles SchedulerControl1.InplaceEditorShowing
            e.InplaceEditorEx = New MyInplaceEditorControl(e.SchedulerInplaceEditorEventArgs)
        End Sub
#End Region ' #inplaceeditorshowing
    End Class
End Namespace
