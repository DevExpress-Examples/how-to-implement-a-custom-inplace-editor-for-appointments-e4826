﻿Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraScheduler

Namespace SchedulerInplaceEditorExample
    #Region "#MyInplaceEditorControl"
    Public Class MyInplaceEditorControl
        Implements ISchedulerInplaceEditorEx


        Private editor_Renamed As MyInplaceEditor

        Private appointment_Renamed As Appointment

        Private control_Renamed As SchedulerControl

        Public Sub New(ByVal inplaceEditorArgs As SchedulerInplaceEditorEventArgs)
            Me.appointment_Renamed = inplaceEditorArgs.ViewInfo.Appointment
            Me.control_Renamed = inplaceEditorArgs.Control
            CreateEditor(inplaceEditorArgs)
        End Sub

        Private ReadOnly Property Editor() As MyInplaceEditor
            Get
                Return editor_Renamed
            End Get
        End Property
        Private ReadOnly Property Appointment() As Appointment
            Get
                Return appointment_Renamed
            End Get
        End Property
        Private ReadOnly Property Control() As SchedulerControl
            Get
                Return control_Renamed
            End Get
        End Property

        Public Event CommitChanges As EventHandler Implements ISchedulerInplaceEditorEx.CommitChanges
        Public Event RollbackChanges As EventHandler Implements ISchedulerInplaceEditorEx.RollbackChanges

        Private Sub CreateEditor(ByVal inplaceEditorArgs As SchedulerInplaceEditorEventArgs)
            Me.editor_Renamed = New MyInplaceEditor(inplaceEditorArgs)
        End Sub

        ' Interface implementation 
        Public Sub Dispose() Implements ISchedulerInplaceEditorEx.Dispose
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
                    Me.editor_Renamed = Nothing
                End If
                Me.appointment_Renamed = Nothing
            End If
        End Sub
        Public Overridable Sub Activate() Implements ISchedulerInplaceEditorEx.Activate
            Editor.FillForm(control_Renamed, appointment_Renamed)
            SubscribeEditorEvents()
            Editor.Show(Me.Control.FindForm())
        End Sub
        Public Overridable Sub Deactivate() Implements ISchedulerInplaceEditorEx.Deactivate
            UnsibscribeEditorEvents()
            Editor.Close()
        End Sub
        Public Overridable Sub ApplyChanges() Implements ISchedulerInplaceEditorEx.ApplyChanges
            Editor.ApplyChanges()
        End Sub
        Protected Friend Overridable Sub SubscribeEditorEvents()
            AddHandler Editor.FormClosed, AddressOf Editor_FormClosed
            AddHandler Editor.Deactivate, AddressOf Editor_Deactivate
            AddHandler Editor.CommitChanges, AddressOf Editor_CommitChanges
            AddHandler Editor.RollbackChanges, AddressOf Editor_RollbackChanges
        End Sub

        Protected Friend Overridable Sub UnsibscribeEditorEvents()
            RemoveHandler Editor.FormClosed, AddressOf Editor_FormClosed
            RemoveHandler Editor.Deactivate, AddressOf Editor_Deactivate
            RemoveHandler Editor.CommitChanges, AddressOf Editor_CommitChanges
            RemoveHandler Editor.RollbackChanges, AddressOf Editor_RollbackChanges
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
    #End Region ' #MyInplaceEditorControl
End Namespace
