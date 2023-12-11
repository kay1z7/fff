Public Class frmChange

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub chkPass_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPass.CheckedChanged

        If Me.chkPass.CheckState = CheckState.Checked Then
            txtNewPass.UseSystemPasswordChar = True
        Else
            txtNewPass.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub frmChange_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.chkPass.CheckState = CheckState.Unchecked
    End Sub
End Class