Public Class frmCustomers_Record

    Private Sub frmCustomers_Record_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim SqlfetcdGrid As String
        Try
            SqlfetcdGrid = "SELECT * FROM tblCustomer"
            sqlgetQueryCommand(SqlfetcdGrid)
            dgvCustomer.DataSource = dbdt
            dgvCustomer.RowHeadersVisible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

   
    Private Sub txtCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCode.TextChanged

        Dim SqlfetcdGrid As String
        Try

            SqlfetcdGrid = "SELECT * FROM tblCustomer WHERE cust_Code LIKE '" & txtCode.Text & "'"
            sqlgetQueryCommand(SqlfetcdGrid)
            dgvCustomer.DataSource = dbdt
            dgvCustomer.RowHeadersVisible = False
        Catch ex As Exception

        End Try

    End Sub

    Private Sub txtFullName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFullName.TextChanged
        Dim SqlfetcdGrid As String

        Try

            SqlfetcdGrid = "SELECT * FROM tblCustomer WHERE lastname LIKE '%" & txtFullName.Text & "%' OR firstName '%" & txtFullName.Text & "%'"
            sqlgetQueryCommand(SqlfetcdGrid)
            dgvCustomer.DataSource = dbdt
        Catch ex As Exception

        End Try


    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click

        Dim SqlfetcdGrid As String

        Try

            SqlfetcdGrid = "SELECT * FROM tblCustomer WHERE accountDate BETWEEN #" & dtpFrom.Text & "# AND accountDate #" & dtpTo.Text & "#"
            sqlgetQueryCommand(SqlfetcdGrid)
            dgvCustomer.DataSource = dbdt
        Catch ex As Exception

        End Try


    End Sub

    Private Sub dgvCustomer_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCustomer.CellContentClick
        Call frmCustomers_Record_Load(sender, e)
    End Sub
End Class