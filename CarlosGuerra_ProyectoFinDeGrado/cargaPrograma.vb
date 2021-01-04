Public Class cargaPrograma
    Private Sub cargaPrograma_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles timerProgressBar.Tick
        If progressBar.Value < 100 Then
            progressBar.Value = progressBar.Value + 1
            lblProgressBar.Text = "Cargando el programa al " & progressBar.Value & " %"
        Else
            timerProgressBar.Enabled = False
            Me.Hide()
            loginForm.Show()
        End If
    End Sub
End Class