Public Class frmSheldule_Event

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

   
    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Hide()
    End Sub

    Private Sub btnPayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPayment.Click
        Dim frmPayment As New frmPayment
        frmPayment.Show()

    End Sub

    Private Sub frmSheldule_Event_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

      
    End Sub

    Private Sub btnAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddNew.Click
        clearfield(GroupBox2, GroupBox1)

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        Dim SqlEnter As String
        Try

            SqlEnter = "INSERT INTO tblShedule_Event(customer_code, eventType, service_Type, start_date, end_date, event_venue, event_time, feescharge, arrival_date, departure_date) VALUES('" & _
            cboCustomer_code.Text & "', '" & cboEventType.Text & "', '" & cboServiceType.Text & "', #" & dtpEventStart.Text & "#, #" & dtpEventEnd.Text & "#, '" & txtVenue.Text & "', #" & _
            dtpEventTime.Text & "#, '" & txtCostFees.Text & "', #" & dtpArrival.Text & "#, #" & dtpDeparturee.Text & "#)"
            sqlEnsertCommand(SqlEnter)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        

    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Dim SqlUpdater As String

        Try
            SqlUpdater = "UPDATE tblShedule_Event SET customer_code = '" & cboCustomer_code.Text & "', eventType = '" & cboEventType.Text & "', service_Type '" & cboServiceType.Text & "', start_date =#" & dtpEventStart.Text & "#, end_date =#" & dtpEventEnd.Text & "#, event_venue = '" & _
            txtVenue.Text & "', event_time = #" & dtpEventTime.Text & "#, feescharge ='" & txtCostFees.Text & "', arrival_date = #" & dtpArrival.Text & "#, departure_date =#" & dtpDeparturee.Text & "# WHERE sheduleID ='" & lblSheduledid.Text & "' AND customer_code ='" & cboCustomer_code.Text & "'"
            sqlUpdateCommand(SqlUpdater)

        Catch ex As Exception

        End Try



    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim SqlDeleter As String
        Try

            SqlDeleter = "DELETE * FROM tblShedule_Event WHERE sheduleID ='" & lblSheduledid.Text & "' AND customer_code ='" & cboCustomer_code.Text & "'"
          
            sqlDeleteCommand(SqlDeleter)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub NewCustomerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewCustomerToolStripMenuItem.Click

        Me.Hide()
        Dim frmRegister_Customer As New frmRegister_Customer
        frmRegister_Customer.Show()

    End Sub

    Private Sub AddNewEventToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddNewEventToolStripMenuItem.Click

        Dim frmNew_Event As New frmNew_Event
        frmNew_Event.ShowDialog()

    End Sub

    Private Sub AddNewServTypeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddNewServTypeToolStripMenuItem.Click

        Dim frmNewService As New frmNewService
        frmNewService.ShowDialog()

    End Sub

    Private Sub GenerateReceiptToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenerateReceiptToolStripMenuItem.Click

        Dim frmReciept As New frmReciept
        frmReciept.Show()

    End Sub

    Private Sub EventFeesPaymentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EventFeesPaymentToolStripMenuItem.Click
        Me.Hide()
        Dim frmPayment As New frmPayment
        frmPayment.Show()

    End Sub
End Class