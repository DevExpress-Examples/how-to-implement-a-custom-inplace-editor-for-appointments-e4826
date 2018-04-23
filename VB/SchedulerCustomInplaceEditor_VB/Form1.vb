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
        End Sub

#Region "#inplaceeditorshowing"
        Private Sub schedulerControl1_InplaceEditorShowing(ByVal sender As Object, ByVal e As InplaceEditorEventArgs) Handles SchedulerControl1.InplaceEditorShowing
            e.InplaceEditorEx = New MyInplaceEditorControl(e.SchedulerInplaceEditorEventArgs)
        End Sub
#End Region ' #inplaceeditorshowing
    End Class
End Namespace
