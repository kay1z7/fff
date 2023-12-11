Public Class frmRecover_Pass

    Private Sub chkViewPass_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkViewPass.CheckedChanged

        If Me.chkViewPass.CheckState = CheckState.Checked Then
            txtRecovered_Pass.UseSystemPasswordChar = True
        Else
            txtRecovered_Pass.UseSystemPasswordChar = False
        End If


    End Sub

    Private Sub frmRecover_Pass_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.chkViewPass.CheckState = CheckState.Unchecked
        clearAllTxtbo(GroupBox1)
    End Sub

    Private Sub btnRecover_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecover.Click
        Dim SqlFetchRows As String

        Try

            SqlFetchRows = "SELECT accountID, surname, firstname, phonNo, email_Add, userName, ePassword FROM tblAccount_user WHERE userName='" & txtUsername.Text & "' OR phonNo= '" & txtPhoneNo.Text & "'"
            SQLFetchRowQuery(SqlFetchRows)

            If dbtable.Rows.Count > 0 Then
                txtUsername.Text = dbtable.Rows(0).Item("userName")
                txtRecovered_Pass.Text = dbtable.Rows(0).Item("ePassword")
                txtPhoneNo.Text = dbtable.Rows(0).Item("phonNo")
            End If
            rec_found = True
        Catch ex As Exception


        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub
End Class