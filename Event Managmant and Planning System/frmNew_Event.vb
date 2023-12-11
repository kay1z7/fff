Imports System.Data.OleDb
Public Class frmNew_Event

    Private Sub btnAddnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddnew.Click

        txtEven_Name.Text = ""
        txtEvent_code.Text = ""
        txtEvent_code.Focus()

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        Me.Hide()

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        Dim SqlEnter As String

        GetConnection()
        dbcommand = New OleDbCommand
        With dbcommand
            .CommandType = CommandType.Text
            .CommandText = "SELECT ID,event_code, eventname FROM tblevents WHERE event_code = '" & txtEvent_code.Text & "'"
            .Connection = dbconnect
        End With
        dbReader = dbcommand.ExecuteReader(CommandBehavior.CloseConnection)
        If dbReader.Read = False Then

            Try

                SqlEnter = "INSERT INTO tblevent(event_code, event_name)VALUES('" & txtEvent_code.Text & "', '" & txtEven_Name.Text & "')"
                sqlEnsertCommand(SqlEnter)

            Catch ex As Exception

            End Try
        Else
            MsgBox("Record Already Exist...!!!", MsgBoxStyle.Exclamation + MsgBoxStyle.Critical, "Record Duplication Aborted")
            txtEvent_code.Focus()
            Exit Sub
        End If

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim SqlDeleter As String


        GetConnection()
        dbcommand = New OleDbCommand
        With dbcommand
            .CommandType = CommandType.Text
            .CommandText = "SELECT ID,event_code, eventname FROM tblevents WHERE event_code = '" & txtEvent_code.Text & "'"
            .Connection = dbconnect
        End With
        dbReader = dbcommand.ExecuteReader(CommandBehavior.CloseConnection)
        If dbReader.Read = True Then

            Try
                SqlDeleter = "DELETE * FROM tblevents WHERE event_code='" & txtEvent_code.Text & "'"
                sqlDeleteCommand(SqlDeleter)

            Catch ex As Exception

            End Try
        Else
            MsgBox("Record does not Exist..!!!", MsgBoxStyle.Critical + MsgBoxStyle.Exclamation, "Record not Found")
            txtEvent_code.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Dim SqlUpdater As String

        GetConnection()
        dbcommand = New OleDbCommand
        With dbcommand
            .CommandType = CommandType.Text
            .CommandText = "SELECT ID,event_code, eventname FROM tblevents WHERE event_code = '" & txtEvent_code.Text & "'"
            .Connection = dbconnect
        End With
        dbReader = dbcommand.ExecuteReader(CommandBehavior.CloseConnection)
        If dbReader.Read = True Then

            Try

                SqlUpdater = "UPDATE tblevents SET event_code='" & txtEvent_code.Text & "', eventname='" & txtEven_Name.Text & "' WHERE event_code='" & txtEvent_code.Text & "'"
                sqlUpdateCommand(SqlUpdater)

            Catch ex As Exception

            End Try
        Else
            MsgBox("Record Not Found", MsgBoxStyle.Exclamation + MsgBoxStyle.Critical, "Record does not Exist")
            txtEvent_code.Focus()
            Exit Sub

        End If

    End Sub
End Class