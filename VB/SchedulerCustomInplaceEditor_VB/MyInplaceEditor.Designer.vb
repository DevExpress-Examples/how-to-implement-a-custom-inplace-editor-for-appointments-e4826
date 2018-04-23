Imports Microsoft.VisualBasic
Imports System
Namespace SchedulerCustomInplaceEditor_VB

    Partial Class MyInplaceEditor
        Inherits DevExpress.XtraEditors.XtraForm

        'Form overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.edtDescription = New DevExpress.XtraEditors.MemoEdit()
            Me.AppointmentLabelEdit1 = New DevExpress.XtraScheduler.UI.AppointmentLabelEdit()
            Me.edtSubject = New DevExpress.XtraEditors.TextEdit()
            Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.LayoutControl1.SuspendLayout()
            CType(Me.edtDescription.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.AppointmentLabelEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.edtSubject.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'LayoutControl1
            '
            Me.LayoutControl1.Controls.Add(Me.edtDescription)
            Me.LayoutControl1.Controls.Add(Me.AppointmentLabelEdit1)
            Me.LayoutControl1.Controls.Add(Me.edtSubject)
            Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.LayoutControl1.Name = "LayoutControl1"
            Me.LayoutControl1.Root = Me.LayoutControlGroup1
            Me.LayoutControl1.Size = New System.Drawing.Size(191, 261)
            Me.LayoutControl1.TabIndex = 0
            Me.LayoutControl1.Text = "LayoutControl1"
            '
            'edtDescription
            '
            Me.edtDescription.Location = New System.Drawing.Point(12, 121)
            Me.edtDescription.Name = "edtDescription"
            Me.edtDescription.Size = New System.Drawing.Size(167, 128)
            Me.edtDescription.StyleController = Me.LayoutControl1
            Me.edtDescription.TabIndex = 6
            '
            'AppointmentLabelEdit1
            '
            Me.AppointmentLabelEdit1.Location = New System.Drawing.Point(12, 76)
            Me.AppointmentLabelEdit1.Name = "AppointmentLabelEdit1"
            Me.AppointmentLabelEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.AppointmentLabelEdit1.Size = New System.Drawing.Size(167, 22)
            Me.AppointmentLabelEdit1.StyleController = Me.LayoutControl1
            Me.AppointmentLabelEdit1.TabIndex = 5
            '
            'edtSubject
            '
            Me.edtSubject.Location = New System.Drawing.Point(12, 31)
            Me.edtSubject.Name = "edtSubject"
            Me.edtSubject.Size = New System.Drawing.Size(167, 22)
            Me.edtSubject.StyleController = Me.LayoutControl1
            Me.edtSubject.TabIndex = 4
            '
            'LayoutControlGroup1
            '
            Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
            Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.LayoutControlGroup1.GroupBordersVisible = False
            Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3})
            Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
            Me.LayoutControlGroup1.Size = New System.Drawing.Size(191, 261)
            Me.LayoutControlGroup1.Text = "LayoutControlGroup1"
            Me.LayoutControlGroup1.TextVisible = False
            '
            'LayoutControlItem1
            '
            Me.LayoutControlItem1.Control = Me.edtSubject
            Me.LayoutControlItem1.CustomizationFormText = "Subject:"
            Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.LayoutControlItem1.Name = "LayoutControlItem1"
            Me.LayoutControlItem1.Size = New System.Drawing.Size(171, 45)
            Me.LayoutControlItem1.Text = "Subject:"
            Me.LayoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top
            Me.LayoutControlItem1.TextSize = New System.Drawing.Size(68, 16)
            '
            'LayoutControlItem2
            '
            Me.LayoutControlItem2.Control = Me.AppointmentLabelEdit1
            Me.LayoutControlItem2.CustomizationFormText = "Label:"
            Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 45)
            Me.LayoutControlItem2.Name = "LayoutControlItem2"
            Me.LayoutControlItem2.Size = New System.Drawing.Size(171, 45)
            Me.LayoutControlItem2.Text = "Label:"
            Me.LayoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top
            Me.LayoutControlItem2.TextSize = New System.Drawing.Size(68, 16)
            '
            'LayoutControlItem3
            '
            Me.LayoutControlItem3.Control = Me.edtDescription
            Me.LayoutControlItem3.CustomizationFormText = "Description:"
            Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 90)
            Me.LayoutControlItem3.Name = "LayoutControlItem3"
            Me.LayoutControlItem3.Size = New System.Drawing.Size(171, 151)
            Me.LayoutControlItem3.Text = "Description:"
            Me.LayoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top
            Me.LayoutControlItem3.TextSize = New System.Drawing.Size(68, 16)
            '
            'MyInplaceEditor
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(191, 261)
            Me.ControlBox = False
            Me.Controls.Add(Me.LayoutControl1)
            Me.MinimumSize = New System.Drawing.Size(132, 192)
            Me.Name = "MyInplaceEditor"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
            CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.LayoutControl1.ResumeLayout(False)
            CType(Me.edtDescription.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.AppointmentLabelEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.edtSubject.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
        Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
        Friend WithEvents edtDescription As DevExpress.XtraEditors.MemoEdit
        Friend WithEvents AppointmentLabelEdit1 As DevExpress.XtraScheduler.UI.AppointmentLabelEdit
        Friend WithEvents edtSubject As DevExpress.XtraEditors.TextEdit
        Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace