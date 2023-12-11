Imports System.Data.OleDb
Public Class frmNewService


    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click

        Me.Hide()

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        txtSer_Name.Text = ""
        txtServ_Code.Text = ""
        txtServ_Cost.Text = ""
        txtServ_Code.Focus()

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim sqlEnter As String

        If txtServ_Code.Text = "" Or txtSer_Name.Text = "" Or txtServ_Cost.Text = "" Then
            MsgBox("All fields are Required...!!!", MsgBoxStyle.Critical, "Input Error")
            txtServ_Code.Focus()
            Exit Sub
        End If


        GetConnection()
        dbcommand = New OleDbCommand
        With dbcommand
            .CommandType = CommandType.Text
            .CommandText = "SELECT ID, serv_Code, serv_name, serv_cost FROM tblServices WHERE serv_Code = '" & txtServ_Code.Text & "'"
            .Connection = dbconnect
        End With
        dbReader = dbcommand.ExecuteReader(CommandBehavior.CloseConnection)
        If dbReader.Read = False Then

            Try

                sqlEnter = "INSERT INTO tblServices(serv_Code, serv_name, serv_cost)VALUES ('" & txtServ_Code.Text & "', '" & txtSer_Name.Text & "','" & txtServ_Cost.Text & "')"
                sqlEnsertCommand(sqlEnter)
            Catch ex As Exception

                MsgBox(ex.Message)
            End Try

        Else
            MsgBox("Record Already Exist...!!!", MsgBoxStyle.Exclamation + MsgBoxStyle.Critical, "Record Duplication Aborted")
            txtServ_Code.Focus()
            Exit Sub
        End If
        clearAllTxtbo(GroupBox1)

    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Dim SqlUpdater As String
        If txtServ_Code.Text = "" Then
            MsgBox("Service Code can not be empty...!!!", MsgBoxStyle.Critical, "Empty Field Detected")
            txtServ_Code.Focus()
            Exit Sub
        End If

        GetConnection()
        dbcommand = New OleDbCommand
        With dbcommand
            .CommandType = CommandType.Text
            .CommandText = "SELECT ID, serv_Code, serv_name, serv_cost FROM tblServices WHERE serv_Code = '" & txtServ_Code.Text & "'"
            .Connection = dbconnect
        End With
        dbReader = dbcommand.ExecuteReader(CommandBehavior.CloseConnection)
        If dbReader.Read = False Then
            MsgBox("Record does not Exist...!!!", MsgBoxStyle.Exclamation)
        Else
            Try

                SqlUpdater = "UPDATE tblServices SET serv_Code = '" & txtServ_Code.Text & "', serv_name = '" & txtSer_Name.Text & "', serv_cost= '" & txtServ_Cost.Text & "'"
                sqlUpdateCommand(SqlUpdater)

            Catch ex As Exception
                MsgBox(ex.Message)

            End Try

        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim SqlDeleter As String
        If txtServ_Code.Text = "" Then
            MsgBox("Please enter a service Code..!!!", MsgBoxStyle.Critical + MsgBoxStyle.Exclamation, "Service code is Empty")
            txtServ_Code.Focus()
            Exit Sub
        End If
        GetConnection()
        dbcommand = New OleDbCommand
        With dbcommand
            .CommandType = CommandType.Text
            .CommandText = "SELECT ID, serv_Code, serv_name, serv_cost FROM tblServices WHERE serv_Code = '" & txtServ_Code.Text & "'"
            .Connection = dbconnect
        End With
        dbReader = dbcommand.ExecuteReader(CommandBehavior.CloseConnection)
        If dbReader.Read = True Then
            Try
                SqlDeleter = "DELETE * FROM tblServices WHERE serv_Code='" & txtServ_Code.Text & "'"
                sqlDeleteCommand(SqlDeleter)

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("Record Not Found...!!!", MsgBoxStyle.Exclamation)
            txtServ_Code.Focus()
            Exit Sub
        End If

    End Sub

    Private Sub frmNewService_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class