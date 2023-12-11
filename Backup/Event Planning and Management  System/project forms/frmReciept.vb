Public Class frmReciept

    
   
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        Me.Close()

    End Sub

    Private Sub btnSheldule_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSheldule.Click

        Dim frmSheldule_Event As New frmSheldule_Event
        frmSheldule_Event.Show()
    End Sub

    Private Sub btnPayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPayment.Click

        Dim frmPayment As New frmPayment
        frmPayment.Show()

    End Sub

    Private Sub txtCustomer_code_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCustomer_code.TextChanged

        Dim SqlFetchRows As String
        Try

            SqlFetchRows = "SELECT recieptID, customer_code, eventType, service_type, total_charge, initial_payment, payment_balance, event_date,payment_date, eventid, discount, paymentid, event_days, printed_date"
            SQLFetchRowQuery(SqlFetchRows)

        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnGenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerate.Click
        Dim SqlFetchRows As String

        Try

            SqlFetchRows = "SELECT recieptID, customer_code, eventType, service_type, total_charge, initial_payment, payment_balance, event_date,payment_date, eventid, discount, paymentid, event_days, printed_date WHERE customer_code='" & txtCustomer_code.Text & "' AND event_date= #" & dtpEvent.Text & "#"
            SQLFetchRowQuery(SqlFetchRows)

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try


    End Sub
End Class