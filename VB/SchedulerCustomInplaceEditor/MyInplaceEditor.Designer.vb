Namespace SchedulerCustomInplaceEditor

    Partial Class MyInplaceEditor

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
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.edtSubject = New DevExpress.XtraEditors.TextEdit()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.appointmentLabelEdit1 = New DevExpress.XtraScheduler.UI.AppointmentLabelEdit()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.edtDescription = New DevExpress.XtraEditors.MemoEdit()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.edtSubject.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.appointmentLabelEdit1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.edtDescription.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.Controls.Add(Me.edtDescription)
            Me.layoutControl1.Controls.Add(Me.appointmentLabelEdit1)
            Me.layoutControl1.Controls.Add(Me.edtSubject)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(768, 44, 250, 350)
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(116, 150)
            Me.layoutControl1.TabIndex = 0
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1"
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1, Me.layoutControlItem2, Me.layoutControlItem3})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "layoutControlGroup1"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(116, 150)
            Me.layoutControlGroup1.Text = "layoutControlGroup1"
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' edtSubject
            ' 
            Me.edtSubject.Location = New System.Drawing.Point(12, 29)
            Me.edtSubject.Name = "edtSubject"
            Me.edtSubject.Size = New System.Drawing.Size(92, 20)
            Me.edtSubject.StyleController = Me.layoutControl1
            Me.edtSubject.TabIndex = 4
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.edtSubject
            Me.layoutControlItem1.CustomizationFormText = "Subject:"
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(96, 41)
            Me.layoutControlItem1.Text = "Subject:"
            Me.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(57, 13)
            ' 
            ' appointmentLabelEdit1
            ' 
            Me.appointmentLabelEdit1.Location = New System.Drawing.Point(12, 70)
            Me.appointmentLabelEdit1.Name = "appointmentLabelEdit1"
            Me.appointmentLabelEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.appointmentLabelEdit1.Size = New System.Drawing.Size(92, 20)
            Me.appointmentLabelEdit1.StyleController = Me.layoutControl1
            Me.appointmentLabelEdit1.TabIndex = 5
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.appointmentLabelEdit1
            Me.layoutControlItem2.CustomizationFormText = "Label:"
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 41)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(96, 41)
            Me.layoutControlItem2.Text = "Label:"
            Me.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(57, 13)
            ' 
            ' edtDescription
            ' 
            Me.edtDescription.Location = New System.Drawing.Point(12, 111)
            Me.edtDescription.Name = "edtDescription"
            Me.edtDescription.Size = New System.Drawing.Size(92, 27)
            Me.edtDescription.StyleController = Me.layoutControl1
            Me.edtDescription.TabIndex = 6
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.edtDescription
            Me.layoutControlItem3.CustomizationFormText = "Description:"
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 82)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(96, 48)
            Me.layoutControlItem3.Text = "Description:"
            Me.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(57, 13)
            ' 
            ' MyInplaceEditor
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(116, 150)
            Me.ControlBox = False
            Me.Controls.Add(Me.layoutControl1)
            Me.MinimumSize = New System.Drawing.Size(132, 192)
            Me.Name = "MyInplaceEditor"
            Me.ShowIcon = False
            Me.ShowInTaskbar = False
            Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
            Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
            Me.TopMost = True
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.edtSubject.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.appointmentLabelEdit1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.edtDescription.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

'#End Region
        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private edtDescription As DevExpress.XtraEditors.MemoEdit

        Private appointmentLabelEdit1 As DevExpress.XtraScheduler.UI.AppointmentLabelEdit

        Private edtSubject As DevExpress.XtraEditors.TextEdit

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace
