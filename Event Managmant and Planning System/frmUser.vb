Public Class frmUser

    Private Sub frmUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        txtPassword.UseSystemPasswordChar = True
        chkpassShow.CheckState = CheckState.Unchecked

        Dim SqlFilledGrid As String
        Try
            SqlFilledGrid = "SELECT * FROM tblAccount_user"
            sqlFillQueryCommand(SqlFilledGrid)
            dgvUser.DataSource = dbdt
            dgvUser.RowHeadersVisible = False
        Catch ex As Exception

            'Exit Sub
        End Try

        clearAllCombo(GroupBox1)
        clearAllTxtbo(GroupBox1)
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        txtEmailAdd.Text = ""
        txtlastName.Text = ""
        txtPhoneNo.Text = ""
        txtPassword.Text = ""
        txtUsername.Text = ""
        txtfirstname.Text = ""
        txtlastName.Focus()

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim SqlEnter As String
        Try

            SqlEnter = "INSERT INTO tblAccount_user(surname, firstname, phoneNo, email_Add, userName, ePassword, accountDate, createdby)VALUES ('" & _
            txtlastName.Text & "', '" & txtfirstname.Text & "', '" & txtPhoneNo.Text & "', '" & txtEmailAdd.Text & "', '" & txtUsername.Text & "', '" & txtPassword.Text & "', #" & dtpCreatedDate.Text & "#, '" & cboCreatedBy.Text & "')"
            sqlEnsertCommand(SqlEnter)
            dgvUser.DataSource = dbtable
            dgvUser.RowHeadersVisible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Call frmUser_Load(sender, e)

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

   
    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click

        Call frmUser_Load(sender, e)

    End Sub

   

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click

        Dim SqlDeleter As String
        Try

            SqlDeleter = "DELETE * FROM tblAccount_user WHERE userName='" & txtUsername.Text & "'AND phoneNo='" & txtPhoneNo.Text & "'"
            sqlDeleteCommand(SqlDeleter)
            dgvUser.DataSource = dbtable
            dgvUser.RowHeadersVisible = False
        Catch ex As Exception

            MsgBox(ex.Message)
        End Try
        Call frmUser_Load(sender, e)

    End Sub

    Private Sub chkpassShow_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkpassShow.CheckedChanged

        If Me.chkpassShow.CheckState = CheckState.Checked Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True

        End If

    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click

        Dim SqlUpdater As String
        Try
            SqlUpdater = "UPDATE tblAccount_user SET(surname= '" & txtlastName.Text & "', firstname='" & txtfirstname.Text & "', phoneNo='" & _
            txtPhoneNo.Text & "', email_Add ='" & txtEmailAdd.Text & "', userName='" & txtUsername.Text & "', ePassword='" & _
            txtPassword.Text & "', accountDate= #" & dtpCreatedDate.Text & "#,createdby='" & cboCreatedBy.Text & "')"
            sqlUpdateCommand(SqlUpdater)
            dgvUser.DataSource = dbtable
            dgvUser.RowHeadersVisible = False
        Catch ex As Exception

            MsgBox(ex.Message)
        End Try

        Call frmUser_Load(sender, e)
    End Sub

End Class