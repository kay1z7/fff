Public Class frmEvent_Record

    Private Sub FileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FileToolStripMenuItem.Click

    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub frmEvent_Record_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim SqlfetcdGrid As String

        Try
            SqlfetcdGrid = "SELECT * FROM tblShedule_Event"
            sqlgetQueryCommand(SqlfetcdGrid)
            dgvEvent_Record.DataSource = dbdt
            dgvEvent_Record.RowHeadersVisible = False
        Catch ex As Exception

            MsgBox(ex.Message)

        End Try


    End Sub

    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click

        Dim SqlFilledGrid As String
        Try

            SqlFilledGrid = "SELECT * FROM tblShedule_Event WHERE start_date BETWEEN '" & dtpFrom.Text & "' AND '" & dtpTo.Text & "'"
            sqlFillQueryCommand(SqlFilledGrid)

        Catch ex As Exception

        End Try



    End Sub

    Private Sub txtEvent_Code_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEvent_Code.TextChanged

        Dim SqlFilledGrid As String
        Try

            SqlFilledGrid = "SELECT * FROM tblShedule_Event WHERE customer_code LIKE '%" & txtEvent_Code.Text & "%'"
            sqlFillQueryCommand(SqlFilledGrid)

        Catch ex As Exception

            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub cboEventType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboEventType.SelectedIndexChanged
        Dim SqlFilledGrid As String
        Try

            SqlFilledGrid = "SELECT * FROM tblShedule_Event WHERE eventType = '" & txtEvent_Code.Text & "'"
            sqlFillQueryCommand(SqlFilledGrid)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub dtpFrom_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFrom.ValueChanged




    End Sub
End Class