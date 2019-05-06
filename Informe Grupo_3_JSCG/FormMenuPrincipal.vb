Public Class _formMenuPrincipal
    Private Sub _estudiantesRegistrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles _estudiantesRegistrarToolStripMenuItem.Click
        Dim formulario = New _formRegistrarEstudiante()
        formulario.ShowDialog()
    End Sub

    Private Sub _estudiantesActualizarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles _estudiantesActualizarToolStripMenuItem.Click
        Dim formulario = New _formActualizarEstudiante()
        formulario.ShowDialog()
    End Sub

    Private Sub _estudiantesEliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles _estudiantesEliminarToolStripMenuItem.Click
        Dim formulario = New _formEliminarEstudiante()
        formulario.ShowDialog()
    End Sub

    Private Sub _estudiantesConsultarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles _estudiantesConsultarToolStripMenuItem.Click
        Dim formulario = New _formConsultarEstudiante()
        formulario.ShowDialog()
    End Sub
End Class
