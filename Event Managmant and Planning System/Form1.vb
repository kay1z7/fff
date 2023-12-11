Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        If Timer1.Interval = Timer1.Interval Then
            Me.Hide()
            frmSplash.Show()
            Timer1.Stop()
            'Tmin = 0
        End If



    End Sub
End Class
