Imports Microsoft.VisualBasic
Imports System
Namespace SchedulerCustomInplaceEditor_VB

    Partial Class Form1
        Inherits System.Windows.Forms.Form

        'Form overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Try
                If disposing AndAlso components IsNot Nothing Then
                    components.Dispose()
                End If
            Finally
                MyBase.Dispose(disposing)
            End Try
        End Sub

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim TimeRuler1 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
            Dim TimeRuler2 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
            Me.SchedulerControl1 = New DevExpress.XtraScheduler.SchedulerControl()
            Me.SchedulerStorage1 = New DevExpress.XtraScheduler.SchedulerStorage(Me.components)
            CType(Me.SchedulerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.SchedulerStorage1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'SchedulerControl1
            '
            Me.SchedulerControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.SchedulerControl1.GroupType = DevExpress.XtraScheduler.SchedulerGroupType.Resource
            Me.SchedulerControl1.Location = New System.Drawing.Point(0, 0)
            Me.SchedulerControl1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
            Me.SchedulerControl1.Name = "SchedulerControl1"
            Me.SchedulerControl1.Size = New System.Drawing.Size(554, 399)
            Me.SchedulerControl1.Start = New Date(2013, 8, 2, 0, 0, 0, 0)
            Me.SchedulerControl1.Storage = Me.SchedulerStorage1
            Me.SchedulerControl1.TabIndex = 0
            Me.SchedulerControl1.Text = "SchedulerControl1"
            Me.SchedulerControl1.Views.DayView.AllDayAreaScrollBarVisible = False
            Me.SchedulerControl1.Views.DayView.TimeRulers.Add(TimeRuler1)
            Me.SchedulerControl1.Views.FullWeekView.AllDayAreaScrollBarVisible = False
            Me.SchedulerControl1.Views.GanttView.Enabled = False
            Me.SchedulerControl1.Views.TimelineView.TimelineScrollBarVisible = False
            Me.SchedulerControl1.Views.WorkWeekView.AllDayAreaScrollBarVisible = False
            Me.SchedulerControl1.Views.WorkWeekView.TimeRulers.Add(TimeRuler2)
            '
            'SchedulerStorage1
            '
            Me.SchedulerStorage1.Appointments.Mappings.AllDay = "AllDay"
            Me.SchedulerStorage1.Appointments.Mappings.Description = "Description"
            Me.SchedulerStorage1.Appointments.Mappings.End = "EndDate"
            Me.SchedulerStorage1.Appointments.Mappings.Label = "Label"
            Me.SchedulerStorage1.Appointments.Mappings.Location = "Location"
            Me.SchedulerStorage1.Appointments.Mappings.RecurrenceInfo = "RecurrenceInfo"
            Me.SchedulerStorage1.Appointments.Mappings.ReminderInfo = "ReminderInfo"
            Me.SchedulerStorage1.Appointments.Mappings.ResourceId = "ResourceID"
            Me.SchedulerStorage1.Appointments.Mappings.Start = "StartDate"
            Me.SchedulerStorage1.Appointments.Mappings.Status = "Status"
            Me.SchedulerStorage1.Appointments.Mappings.Subject = "Subject"
            Me.SchedulerStorage1.Appointments.Mappings.Type = "Type"
            Me.SchedulerStorage1.Resources.Mappings.Caption = "ResourceName"
            Me.SchedulerStorage1.Resources.Mappings.Color = "Color"
            Me.SchedulerStorage1.Resources.Mappings.Id = "ResourceID"
            Me.SchedulerStorage1.Resources.Mappings.Image = "Image"
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(554, 399)
            Me.Controls.Add(Me.SchedulerControl1)
            Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType(Me.SchedulerControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.SchedulerStorage1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents SchedulerControl1 As DevExpress.XtraScheduler.SchedulerControl
        Friend WithEvents SchedulerStorage1 As DevExpress.XtraScheduler.SchedulerStorage

    End Class
End Namespace