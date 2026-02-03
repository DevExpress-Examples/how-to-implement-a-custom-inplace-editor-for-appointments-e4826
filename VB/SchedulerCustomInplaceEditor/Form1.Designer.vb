Namespace SchedulerCustomInplaceEditor

    Partial Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

'#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim timeRuler1 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
            Dim timeRuler2 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
            Me.schedulerControl1 = New DevExpress.XtraScheduler.SchedulerControl()
            Me.schedulerStorage1 = New DevExpress.XtraScheduler.SchedulerStorage(Me.components)
            Me.appointmentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.scheduleTestDataSet = New SchedulerCustomInplaceEditor.ScheduleTestDataSet()
            Me.resourcesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.appointmentsTableAdapter = New SchedulerCustomInplaceEditor.ScheduleTestDataSetTableAdapters.AppointmentsTableAdapter()
            Me.resourcesTableAdapter = New SchedulerCustomInplaceEditor.ScheduleTestDataSetTableAdapters.ResourcesTableAdapter()
            CType((Me.schedulerControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.schedulerStorage1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.appointmentsBindingSource), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.scheduleTestDataSet), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.resourcesBindingSource), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' schedulerControl1
            ' 
            Me.schedulerControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.schedulerControl1.GroupType = DevExpress.XtraScheduler.SchedulerGroupType.Resource
            Me.schedulerControl1.Location = New System.Drawing.Point(0, 0)
            Me.schedulerControl1.Name = "schedulerControl1"
            Me.schedulerControl1.Size = New System.Drawing.Size(698, 477)
            Me.schedulerControl1.Start = New System.DateTime(2013, 7, 30, 0, 0, 0, 0)
            Me.schedulerControl1.Storage = Me.schedulerStorage1
            Me.schedulerControl1.TabIndex = 0
            Me.schedulerControl1.Text = "schedulerControl1"
            Me.schedulerControl1.Views.DayView.TimeRulers.Add(timeRuler1)
            Me.schedulerControl1.Views.WorkWeekView.TimeRulers.Add(timeRuler2)
            AddHandler Me.schedulerControl1.InplaceEditorShowing, New DevExpress.XtraScheduler.InplaceEditorEventHandler(AddressOf Me.schedulerControl1_InplaceEditorShowing)
            ' 
            ' schedulerStorage1
            ' 
            Me.schedulerStorage1.Appointments.DataSource = Me.appointmentsBindingSource
            Me.schedulerStorage1.Appointments.Mappings.AllDay = "AllDay"
            Me.schedulerStorage1.Appointments.Mappings.Description = "Description"
            Me.schedulerStorage1.Appointments.Mappings.[End] = "EndDate"
            Me.schedulerStorage1.Appointments.Mappings.Label = "Label"
            Me.schedulerStorage1.Appointments.Mappings.Location = "Location"
            Me.schedulerStorage1.Appointments.Mappings.RecurrenceInfo = "RecurrenceInfo"
            Me.schedulerStorage1.Appointments.Mappings.ReminderInfo = "ReminderInfo"
            Me.schedulerStorage1.Appointments.Mappings.ResourceId = "ResourceID"
            Me.schedulerStorage1.Appointments.Mappings.Start = "StartDate"
            Me.schedulerStorage1.Appointments.Mappings.Status = "Status"
            Me.schedulerStorage1.Appointments.Mappings.Subject = "Subject"
            Me.schedulerStorage1.Appointments.Mappings.Type = "Type"
            Me.schedulerStorage1.Resources.DataSource = Me.resourcesBindingSource
            Me.schedulerStorage1.Resources.Mappings.Caption = "ResourceName"
            Me.schedulerStorage1.Resources.Mappings.Color = "Color"
            Me.schedulerStorage1.Resources.Mappings.Id = "ResourceID"
            Me.schedulerStorage1.Resources.Mappings.Image = "Image"
            ' 
            ' appointmentsBindingSource
            ' 
            Me.appointmentsBindingSource.DataMember = "Appointments"
            Me.appointmentsBindingSource.DataSource = Me.scheduleTestDataSet
            ' 
            ' scheduleTestDataSet
            ' 
            Me.scheduleTestDataSet.DataSetName = "ScheduleTestDataSet"
            Me.scheduleTestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            ' 
            ' resourcesBindingSource
            ' 
            Me.resourcesBindingSource.DataMember = "Resources"
            Me.resourcesBindingSource.DataSource = Me.scheduleTestDataSet
            ' 
            ' appointmentsTableAdapter
            ' 
            Me.appointmentsTableAdapter.ClearBeforeFill = True
            ' 
            ' resourcesTableAdapter
            ' 
            Me.resourcesTableAdapter.ClearBeforeFill = True
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(698, 477)
            Me.Controls.Add(Me.schedulerControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.Form1_Load)
            CType((Me.schedulerControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.schedulerStorage1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.appointmentsBindingSource), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.scheduleTestDataSet), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.resourcesBindingSource), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

'#End Region
        Private schedulerControl1 As DevExpress.XtraScheduler.SchedulerControl

        Private schedulerStorage1 As DevExpress.XtraScheduler.SchedulerStorage

        Private scheduleTestDataSet As SchedulerCustomInplaceEditor.ScheduleTestDataSet

        Private appointmentsBindingSource As System.Windows.Forms.BindingSource

        Private appointmentsTableAdapter As SchedulerCustomInplaceEditor.ScheduleTestDataSetTableAdapters.AppointmentsTableAdapter

        Private resourcesBindingSource As System.Windows.Forms.BindingSource

        Private resourcesTableAdapter As SchedulerCustomInplaceEditor.ScheduleTestDataSetTableAdapters.ResourcesTableAdapter
    End Class
End Namespace
