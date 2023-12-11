Imports System.Data.OleDb
Public Class frmPayment

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Dim frmReciept As New frmReciept
        frmReciept.Show()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        Me.Hide()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        clearAllTxtbo(GroupBox1)
        clearAllTxtbo(GroupBox2)

    End Sub

    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click

        clearAllTxtbo(GroupBox1)
        clearAllTxtbo(GroupBox2)

    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click

        Me.Close()
    End Sub

    Private Sub SheduleNewEventToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SheduleNewEventToolStripMenuItem.Click

        Me.Hide()
        Dim frmSheldule_Event As New frmSheldule_Event
        frmSheldule_Event.Show()

    End Sub

    Private Sub GenerateRecieptToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenerateRecieptToolStripMenuItem.Click

        Dim frmReciept As New frmReciept
        frmReciept.Show()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        Dim SqlEnter As String

        GetConnection()
        dbcommand = New OleDbCommand
        With dbcommand
            .CommandType = CommandType.Text
            .CommandText = "SELECT paymentID, customer_code, eventType, service_Type, service_charge, other_service, other_charges, total_charge WHERE customer_code = '" & txtCustomer_Code.Text & "'"
            .Connection = dbconnect
        End With
        dbReader = dbcommand.ExecuteReader(CommandBehavior.CloseConnection)
        If dbReader.Read = False Then

            Try
                SqlEnter = "INSERT INTO tblPayment(customer_code, eventType, service_Type, service_charge, other_service, other_charges, total_charge, initial_payment, paybalance, payment_date, recievedby) VALUES('" & _
                txtCustomer_Code.Text & "', '" & txtEventTy.Text & "', '" & txtServiceTy.Text & "', '" & txtServiceChrg.Text & "','" & txtOther_Service.Text & "', '" & txtOther_Charge.Text & "', '" & _
                txtTotalCharge.Text & "', '" & txtInitialPay.Text & "', '" & txtBalance.Text & "', #" & dtpPaid.Text & "#, '" & txtRecieverName.Text & "')"
                sqlEnsertCommand(SqlEnter)

            Catch ex As Exception

                MsgBox(ex.Message)
            End Try

        Else

            MsgBox("Record Already Exist...!!!", MsgBoxStyle.Critical + MsgBoxStyle.Exclamation, "Record Duplication Aborted")
            txtCustomer_Code.Focus()
            Exit Sub
        End If

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click

        Dim SqlDeleter As String


        GetConnection()
        dbcommand = New OleDbCommand
        With dbcommand
            .CommandType = CommandType.Text
            .CommandText = "SELECT paymentID, customer_code, eventType, service_Type, service_charge, other_service, other_charges, total_charge WHERE customer_code = '" & txtCustomer_Code.Text & "'"
            .Connection = dbconnect
        End With
        dbReader = dbcommand.ExecuteReader(CommandBehavior.CloseConnection)
        If dbReader.Read = True Then
            Try

                SqlDeleter = "DELETE * FROM tblPayment WHERE paymentID='" & tsslPayid.Text & "' AND customer_code='" & txtCustomer_Code.Text & "'"
                sqlDeleteCommand(SqlDeleter)

            Catch ex As Exception

            End Try
        Else
            MsgBox("Record does not Exist...!!!", MsgBoxStyle.Critical + MsgBoxStyle.Exclamation, "Record Not Found")
            txtCustomer_Code.Focus()
            Exit Sub
        End If

    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Dim SqlUpdater As String


        GetConnection()
        dbcommand = New OleDbCommand
        With dbcommand
            .CommandType = CommandType.Text
            .CommandText = "SELECT paymentID, customer_code, eventType, service_Type, service_charge, other_service, other_charges, total_charge WHERE customer_code = '" & txtCustomer_Code.Text & "'"
            .Connection = dbconnect
        End With
        dbReader = dbcommand.ExecuteReader(CommandBehavior.CloseConnection)
        If dbReader.Read = True Then

            Try

                SqlUpdater = "UPDATE tblPayment SET (customer_code = '" & txtCustomer_Code.Text & "', eventType = '" & txtEventTy.Text & "', service_Type = '" & txtServiceTy.Text & "', service_charge= '" & _
                txtServiceChrg.Text & "', other_service = '" & txtOther_Service.Text & "', other_charges = '" & txtOther_Charge.Text & "', total_charge = '" & _
                txtTotalCharge.Text & "', initial_payment= '" & txtInitialPay.Text & "', paybalance = '" & txtBalance.Text & "', payment_date = #" & dtpPaid.Text & "#, recievedby = '" & txtRecieverName.Text & "' WHERE paymentID='" & tsslPayid.Text & "' AND customer_code='" & txtCustomer_Code.Text & "'"

                sqlUpdateCommand(SqlUpdater)

            Catch ex As Exception

            End Try
        Else

            MsgBox("Record does not Exist...!!!", MsgBoxStyle.Critical + MsgBoxStyle.Exclamation, "No Record Found")
            txtCustomer_Code.Focus()
            Exit Sub
        End If

    End Sub

    Private Sub txtCustomer_Code_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCustomer_Code.TextChanged

        Try
            GetConnection()
            dbcommand = New OleDbCommand
            With dbcommand
                .Connection = dbconnect
                .CommandText = "SELECT * FROM tblPayment WHERE customer_code LIKE '%" & txtCustomer_Code.Text & "%'"
                .CommandType = CommandType.Text
            End With
            dbAdapter = New OleDbDataAdapter
            dbAdapter.SelectCommand = dbcommand
            dbdt = New DataTable
            dbAdapter.Fill(dbdt)

            If dbdt.Rows.Count > 0 Then
                txtCustomer_Code.Text = dbdt.Rows(0).Item("customer_code")
                txtEventTy.Text = dbdt.Rows(0).Item("eventType")
                txtServiceTy.Text = dbdt.Rows(0).Item("service_Type")
                txtServiceChrg.Text = dbdt.Rows(0).Item("service_charge")
                txtTotalCharge.Text = dbdt.Rows(0).Item("total_charge")
                txtInitialPay.Text = dbdt.Rows(0).Item("initial_payment")
                txtOther_Charge.Text = dbdt.Rows(0).Item("other_charges")
                txtOther_Service.Text = dbdt.Rows(0).Item("other_service")
                tsslPayid.Text = dbdt.Rows(0).Item("paymentID")
                txtBalance.Text = dbdt.Rows(0).Item("paybalance")
                txtRecieverName.Text = dbdt.Rows(0).Item("recievedby")
           
            End If

            TerminateConn()
        Catch ex As Exception

        End Try

    End Sub
End Class