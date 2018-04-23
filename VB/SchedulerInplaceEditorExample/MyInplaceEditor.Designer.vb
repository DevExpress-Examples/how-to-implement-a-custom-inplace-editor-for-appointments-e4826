Namespace SchedulerInplaceEditorExample
    Partial Public Class MyInplaceEditor
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.edtDescription = New DevExpress.XtraEditors.MemoEdit()
            Me.appointmentLabelEdit1 = New DevExpress.XtraScheduler.UI.AppointmentLabelEdit()
            Me.edtSubject = New DevExpress.XtraEditors.TextEdit()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            DirectCast(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            DirectCast(Me.edtDescription.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.appointmentLabelEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.edtSubject.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
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
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(284, 261)
            Me.layoutControl1.TabIndex = 0
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' edtDescription
            ' 
            Me.edtDescription.Location = New System.Drawing.Point(12, 108)
            Me.edtDescription.Name = "edtDescription"
            Me.edtDescription.Size = New System.Drawing.Size(260, 141)
            Me.edtDescription.StyleController = Me.layoutControl1
            Me.edtDescription.TabIndex = 6
            ' 
            ' appointmentLabelEdit1
            ' 
            Me.appointmentLabelEdit1.Location = New System.Drawing.Point(12, 68)
            Me.appointmentLabelEdit1.Name = "appointmentLabelEdit1"
            Me.appointmentLabelEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.appointmentLabelEdit1.Size = New System.Drawing.Size(260, 20)
            Me.appointmentLabelEdit1.StyleController = Me.layoutControl1
            Me.appointmentLabelEdit1.TabIndex = 5
            ' 
            ' edtSubject
            ' 
            Me.edtSubject.EditValue = ""
            Me.edtSubject.Location = New System.Drawing.Point(12, 28)
            Me.edtSubject.Name = "edtSubject"
            Me.edtSubject.Size = New System.Drawing.Size(260, 20)
            Me.edtSubject.StyleController = Me.layoutControl1
            Me.edtSubject.TabIndex = 4
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem1, Me.layoutControlItem2, Me.layoutControlItem3})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "layoutControlGroup1"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(284, 261)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.edtSubject
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(264, 40)
            Me.layoutControlItem1.Text = "Subject:"
            Me.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(57, 13)
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.appointmentLabelEdit1
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 40)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(264, 40)
            Me.layoutControlItem2.Text = "Label:"
            Me.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(57, 13)
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.edtDescription
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 80)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(264, 161)
            Me.layoutControlItem3.Text = "Description:"
            Me.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(57, 13)
            ' 
            ' MyInplaceEditor
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(284, 261)
            Me.ControlBox = False
            Me.Controls.Add(Me.layoutControl1)
            Me.MinimumSize = New System.Drawing.Size(132, 192)
            Me.Name = "MyInplaceEditor"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
            DirectCast(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            DirectCast(Me.edtDescription.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.appointmentLabelEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.edtSubject.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private edtDescription As DevExpress.XtraEditors.MemoEdit
        Private appointmentLabelEdit1 As DevExpress.XtraScheduler.UI.AppointmentLabelEdit
        Private edtSubject As DevExpress.XtraEditors.TextEdit
        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl
    End Class
End Namespace