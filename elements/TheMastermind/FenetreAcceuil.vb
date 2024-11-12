Public Class FenetreAcceuil
    Private Sub FenetreAcceuil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'My.Computer.Audio.Play("C:\Users\GHOST Fizer-48P4372\Documents\TheMastermind\.music\Naruto.WAV", AudioPlayMode.BackgroundLoop)
        Form1.Activate()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Computer.Audio.Stop()
        Form1.Show()
        Me.Hide()
    End Sub
End Class