Public Class frmControl_Panel

    Private Sub frmControl_Panel_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        If MsgBox("Are You Sure To Quit..?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Quit Application") = MsgBoxResult.Yes Then
            e.Cancel = False
        Else
            e.Cancel = True
            Exit Sub
        End If


    End Sub

    Private Sub frmControl_Panel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogOutToolStripMenuItem.Click

        Me.Close()
        Dim frmlogin As New frmlogin
        frmlogin.ShowDialog()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()

    End Sub

    Private Sub ChangePasswordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangePasswordToolStripMenuItem.Click
        Dim frmChange As New frmChange
        frmChange.Show()

    End Sub

    Private Sub RecoverPasswordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecoverPasswordToolStripMenuItem.Click

        Dim frmRecover_Pass As New frmRecover_Pass
        frmRecover_Pass.Show()
    End Sub

    Private Sub CustomerRecordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerRecordToolStripMenuItem.Click

        frmCustomers_Record.Show()

    End Sub

    Private Sub AddNewCustomerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddNewCustomerToolStripMenuItem.Click
        Dim frmRegister_Customer As New frmRegister_Customer
        frmRegister_Customer.Show()

    End Sub

    Private Sub ShelduledEventToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShelduledEventToolStripMenuItem.Click

        'Dim frmEvent_Record As New frmEvent_Record
        frmEvent_Record.Show()
        
    End Sub

    Private Sub UserRecordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserRecordToolStripMenuItem.Click

        'Dim frmUser_Record As New frmUser_Record
        frmUser_Record.Show()

    End Sub

    Private Sub AddNewUserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddNewUserToolStripMenuItem.Click

        Dim frmUser As New frmUser
        frmUser.Show()

    End Sub

    Private Sub btnNewCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewCustomer.Click
        Dim frmRegister_Customer As New frmRegister_Customer
        frmRegister_Customer.Show()

    End Sub

    Private Sub btnSheldule_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSheldule.Click

        Dim frmSheldule_Event As New frmSheldule_Event
        frmSheldule_Event.Show()

    End Sub

    Private Sub btnPayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPayment.Click

        Dim frmPayment As New frmPayment
        frmPayment.Show()

    End Sub

    Private Sub btnNewUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewUser.Click

        Dim frmUser As New frmUser
        frmUser.Show()

    End Sub

    Private Sub btnReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReport.Click

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click

        Me.Close()
        frmSplash.Show()

    End Sub

    Private Sub ShelduleEventToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShelduleEventToolStripMenuItem.Click

        Dim frmSheldule_Event As New frmSheldule_Event
        frmSheldule_Event.Show()

    End Sub

    Private Sub PaymentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PaymentToolStripMenuItem.Click

        Dim frmPayment As New frmPayment
        frmPayment.Show()

    End Sub

    Private Sub AddNewEventToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddNewEventToolStripMenuItem.Click

        Dim frmNew_Event As New frmNew_Event
        frmNew_Event.Show()

    End Sub

    Private Sub AddNewServiceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddNewServiceToolStripMenuItem.Click

        Dim frmNewService As New frmNewService
        frmNewService.Show()

    End Sub

    Private Sub btnViews_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViews.Click

    End Sub
End Class