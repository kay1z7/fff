Public Class frmRegister_Customer

    Dim getmy_values As String

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        Dim sqlEnter As String
        Try
            sqlEnter = "INSERT INTO tblCustomer(customerID,lastname, firstName, gender, stateOrigin, resident_Add, phone1, mobileNo, email_Add, nationality)VALUES ('" & _
            txtCustomer_Code.Text & "', '" & txtLastName.Text & "', '" & txtOtherName.Text & "','" & cboGender.Text & "', '" & cboStateOrigin.Text & "', '" & _
            txtResident_Address.Text & "', '" & txtPhone1.Text & "', '" & txtPhone2.Text & "', '" & txtEmail.Text & "', '" & txtNationslity.Text & "')"
            sqlEnsertCommand(sqlEnter)

            'calling the auto_increment sub function for customer code
            Call frmRegister_Customer_Load(sender, e)

            'calling the auto_increment sub function for customer id
            Call frmRegister_Customer_Load(sender, e)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnAddnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddnew.Click

        clearAllCombo(GroupBox1)
        clearAllTxtbo(GroupBox1)

    End Sub

    Private Sub frmRegister_Customer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim mystate As String
        clearAllCombo(GroupBox1)
        clearAllTxtbo(GroupBox1)

        Try


            mystate = "SELECT stateName FROM tblState"
            getstateRow(mystate)
            With cboStateOrigin
                .DataSource = dbds.Tables(0)
                .ValueMember = "stateName"
                .DisplayMember = "stateName"

            End With

        Catch ex As Exception

        End Try
        ' ReadmyRow("SELECT cust_Code FROM tblCustomer", txtCustomer_Code)

        Readmy_id_Row("SELECT customerID FROM tblCustomer", txtCustomer_Code)
    End Sub

    Private Sub btnAddevent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddevent.Click
        Me.Hide()

        Dim frmSheldule_Event As New frmSheldule_Event
        frmSheldule_Event.Show()

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        Me.Hide()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim SqlDeleter As String
        Try

            SqlDeleter = "DELETE * FROM tblCustomer WHERE cust_Code ='" & txtCustomer_Code.Text & "'"
            sqlDeleteCommand(SqlDeleter)
        Catch ex As Exception

            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Dim SqlUpdater As String

        Try
            SqlUpdater = "UPDATE tblCustomer SET cust_Code = '" & txtCustomer_Code.Text & "', lastname = '" & txtLastName.Text & "', firstName = '" & txtOtherName.Text & "', gender = '" & cboGender.Text & "', stateOrigin = '" & _
            cboStateOrigin.Text & "', resident_Add = '" & txtResident_Address.Text & "', phone1 = '" & txtPhone1.Text & "', mobileNo = '" & txtPhone2.Text & "', email_Add = '" & _
            txtEmail.Text & "', nationality = '" & txtNationslity.Text & "' WHERE cust_Code = '" & txtCustomer_Code.Text & "'"
            sqlUpdateCommand(SqlUpdater)

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try


    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click

        Me.Hide()

    End Sub

    Private Sub SheduleNewEventToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SheduleNewEventToolStripMenuItem.Click

        Me.Hide()
        Dim frmSheldule_Event As New frmSheldule_Event
        frmSheldule_Event.Show()

    End Sub

    Private Sub EventFToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EventFToolStripMenuItem.Click

        Dim frmNew_Event As New frmNew_Event
        frmNew_Event.ShowDialog()
    End Sub

    Private Sub AddNewServTypeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddNewServTypeToolStripMenuItem.Click

        Dim frmNewService As New frmNewService
        frmNewService.ShowDialog()

    End Sub
End Class