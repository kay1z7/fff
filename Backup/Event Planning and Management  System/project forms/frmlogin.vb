Imports System.Data.OleDb

Public Class frmlogin

    Private Sub lblChangepass_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblChangepass.LinkClicked

        Dim frmChange As New frmChange
        frmChange.ShowDialog()
    End Sub

    Private Sub lblRecover_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblRecover.LinkClicked

        Dim frmRecover_Pass As New frmRecover_Pass
        frmRecover_Pass.ShowDialog()

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

        Me.Hide()
    End Sub

    Private Sub btnIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIn.Click
        'Timer1.Start()
        Dim SqlLoginString As String
        errormgs = New ErrorProvider
        If txtUsername.Text = "" Then
            errormgs.SetError(txtUsername, "Invalid Username Input")
            txtUsername.Focus()
            Exit Sub
        Else
            errormgs.SetError(txtUsername, "")
        End If

        If txtPassword.Text = "" Then
            errormgs.SetError(txtPassword, "Invalid Password Input")
            txtPassword.Focus()
            Exit Sub
        Else

            errormgs.SetError(txtPassword, "")
        End If


        Try
            SqlLoginString = "SELECT userName, ePassword FROM tblAccount_user WHERE userName='" & txtUsername.Text & "' AND ePassword = '" & txtPassword.Text & "'"
            sqlIogin_Con(SqlLoginString)
            'display a successfull message if record was saved successfull
            If Me.txtUsername.Text = dbdt.Rows(0).Item("userName") And Me.txtPassword.Text = dbdt.Rows(0).Item("ePassword") Then
                MsgBox("Welcome " & " " & dbdt.Rows(0).Item("userName"), MsgBoxStyle.Information, "Access Granted")
                frmSplash.Hide()
                Me.Hide()
            End If
            Timer1.Start()
        Catch ex As Exception
            'MsgBox("Wrong Username and Password, Please Try Again ...!!!", MsgBoxStyle.Information, "Access Denied !!!")
            'Exit Sub
        End Try

        'accountID
    End Sub

    Private Sub frmlogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        txtPassword.UseSystemPasswordChar = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Timer1.Interval = Timer1.Interval Then

            Dim frmControl_Panel As New frmControl_Panel
            frmControl_Panel.Show()
            Timer1.Stop()
        End If

    End Sub
End Class