Public Class frmSplash

    Private Sub frmSplash_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MsgBox("Are You Sure To Quit..?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Quit Application") = MsgBoxResult.Yes Then
            e.Cancel = False
        Else
            e.Cancel = True
            Exit Sub
        End If

    End Sub

    Private Sub frmSplash_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized

    End Sub

    Private Sub LoginToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginToolStripMenuItem.Click

        Dim frmlogin As New frmlogin
        frmlogin.ShowDialog()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click

        Application.Exit()
    End Sub
End Class