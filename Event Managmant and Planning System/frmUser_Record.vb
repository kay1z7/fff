Public Class frmUser_Record

    Private Sub frmUser_Record_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim SqlFilledGrid As String

        Try

            SqlFilledGrid = "SELECT * FROM tblAccount_user"
            sqlFillQueryCommand(SqlFilledGrid)
            dgvEvent_Record.DataSource = dbtable

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click

        Dim SqlFilledGrid As String
        Try

            SqlFilledGrid = "SELECT * FROM tblAccount_user WHERE accountDate BETWEEN #" & dtpFrom.Text & "# AND #" & dtpTo.Text & "#"
            sqlFillQueryCommand(SqlFilledGrid)
            dgvEvent_Record.DataSource = dbtable

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub txtUsername_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUsername.TextChanged

        Dim SqlFilledGrid As String
        Try

            SqlFilledGrid = "SELECT * FROM tblAccount_user WHERE userName LIKE '%" & txtUsername.Text & "%'"
            sqlFillQueryCommand(SqlFilledGrid)
            dgvEvent_Record.DataSource = dbtable

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub cboUserType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboUserType.SelectedIndexChanged
        Dim SqlFilledGrid As String

        Try

            SqlFilledGrid = "SELECT * FROM tblAccount_user WHERE userLevel = '" & cboUserType.Text & "'"
            sqlFillQueryCommand(SqlFilledGrid)
            dgvEvent_Record.DataSource = dbtable

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Hide()

    End Sub
End Class