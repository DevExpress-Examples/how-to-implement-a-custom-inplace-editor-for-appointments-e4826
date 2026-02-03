Imports System
'#Region "#myinplaceeditorcontrol"
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraScheduler

Namespace SchedulerCustomInplaceEditor

    Public Class MyInplaceEditorControl
        Implements ISchedulerInplaceEditorEx

        Private editorField As MyInplaceEditor

        Private appointmentField As Appointment

        Private controlField As SchedulerControl

        Public Sub New(ByVal inplaceEditorArgs As SchedulerInplaceEditorEventArgs)
            appointmentField = inplaceEditorArgs.ViewInfo.Appointment
            controlField = inplaceEditorArgs.Control
            CreateEditor(inplaceEditorArgs)
        End Sub

        Private ReadOnly Property Editor As MyInplaceEditor
            Get
                Return editorField
            End Get
        End Property

        Private ReadOnly Property Appointment As Appointment
            Get
                Return appointmentField
            End Get
        End Property

        Private ReadOnly Property Control As SchedulerControl
            Get
                Return controlField
            End Get
        End Property

        Public Event CommitChanges As EventHandler Implements ISchedulerInplaceEditorEx.CommitChanges

        Public Event RollbackChanges As EventHandler Implements ISchedulerInplaceEditorEx.RollbackChanges

        Private Sub CreateEditor(ByVal inplaceEditorArgs As SchedulerInplaceEditorEventArgs)
            editorField = New MyInplaceEditor()
            Editor.Bounds = AdjustEditorBounds(inplaceEditorArgs.Control, inplaceEditorArgs.Bounds)
        End Sub

        ' Set the size of inplace editor depending on the appointment size 
        Private Function AdjustEditorBounds(ByVal control As SchedulerControl, ByVal editorBounds As Rectangle) As Rectangle
            Dim screenControlBounds As Rectangle = control.Parent.RectangleToScreen(control.Bounds)
            editorBounds.Offset(0, -3)
            Dim screenEditorBounds As Rectangle = control.RectangleToScreen(editorBounds)
            Dim preferredSize As Size = editorField.GetPreferredSize(editorBounds.Size)
            Dim height As Integer = Math.Max(preferredSize.Height, editorBounds.Height)
            Dim width As Integer = preferredSize.Width
            Dim rect As Rectangle = screenEditorBounds
            rect.Offset(editorBounds.Width + 6, 0)
            Dim maxBottom As Integer = Math.Min(screenControlBounds.Bottom, rect.Top + height)
            Dim top As Integer = maxBottom - height
            Dim result As Rectangle = New Rectangle(rect.Left, top, width, height)
            If screenControlBounds.Right < rect.Right Then
                Dim horzOffset As Integer = If(TypeOf control.ActiveView Is DayView, 12, 8)
                result = New Rectangle(screenEditorBounds.Left - width - horzOffset, top, width, height)
            End If

            Return result
        End Function

        ' Interface implementation 
        Public Sub Dispose() Implements IDisposable.Dispose
            Dispose(True)
            GC.SuppressFinalize(Me)
        End Sub

        Protected Overrides Sub Finalize()
            Dispose(False)
        End Sub

        Protected Overridable Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If Editor IsNot Nothing Then
                    Editor.Dispose()
                    editorField = Nothing
                End If

                appointmentField = Nothing
            End If
        End Sub

        Public Overridable Sub Activate() Implements ISchedulerInplaceEditorEx.Activate
            Editor.FillForm(controlField, appointmentField)
            SubscribeEditorEvents()
            Editor.Show(Control.FindForm())
        End Sub

        Public Overridable Sub Deactivate() Implements ISchedulerInplaceEditorEx.Deactivate
            UnsibscribeEditorEvents()
            Editor.Close()
        End Sub

        Public Overridable Sub ApplyChanges() Implements ISchedulerInplaceEditorEx.ApplyChanges
            Editor.ApplyChanges()
        End Sub

        Protected Friend Overridable Sub SubscribeEditorEvents()
            AddHandler Editor.FormClosed, New FormClosedEventHandler(AddressOf Editor_FormClosed)
            AddHandler Editor.Deactivate, New EventHandler(AddressOf Editor_Deactivate)
            AddHandler Editor.CommitChanges, New EventHandler(AddressOf Editor_CommitChanges)
            AddHandler Editor.RollbackChanges, New EventHandler(AddressOf Editor_RollbackChanges)
        End Sub

        Protected Friend Overridable Sub UnsibscribeEditorEvents()
            RemoveHandler Editor.FormClosed, New FormClosedEventHandler(AddressOf Editor_FormClosed)
            RemoveHandler Editor.Deactivate, New EventHandler(AddressOf Editor_Deactivate)
            RemoveHandler Editor.CommitChanges, New EventHandler(AddressOf Editor_CommitChanges)
            RemoveHandler Editor.RollbackChanges, New EventHandler(AddressOf Editor_RollbackChanges)
        End Sub

        Private Sub Editor_FormClosed(ByVal sender As Object, ByVal e As FormClosedEventArgs)
            OnCommitChanges()
        End Sub

        Private Sub Editor_Deactivate(ByVal sender As Object, ByVal e As EventArgs)
            OnCommitChanges()
        End Sub

        Private Sub Editor_RollbackChanges(ByVal sender As Object, ByVal e As EventArgs)
            OnRollbackChanges()
        End Sub

        Private Sub Editor_CommitChanges(ByVal sender As Object, ByVal e As EventArgs)
            OnCommitChanges()
        End Sub

        Protected Friend Overridable Sub TextBox_LostFocus(ByVal sender As Object, ByVal e As EventArgs)
            Editor.Close()
            OnCommitChanges()
        End Sub

        Protected Friend Overridable Sub OnRollbackChanges()
            RaiseEvent RollbackChanges(Me, EventArgs.Empty)
        End Sub

        Protected Friend Overridable Sub OnCommitChanges()
            RaiseCommitChanges()
        End Sub

        Protected Friend Overridable Sub RaiseCommitChanges()
            RaiseEvent CommitChanges(Me, EventArgs.Empty)
        End Sub
    End Class
End Namespace
'#End Region  ' #myinplaceeditorcontrol
