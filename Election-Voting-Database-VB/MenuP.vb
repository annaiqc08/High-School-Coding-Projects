Public Class MenuP

    Private Sub DepartamentosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DepartamentosToolStripMenuItem.Click
        Me.Hide()
        Departamentos.Show()
    End Sub

    Private Sub MunicipiosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MunicipiosToolStripMenuItem.Click
        Me.Hide()
        Municipios.Show()
    End Sub

    Private Sub PadronToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PadronToolStripMenuItem.Click
        Me.Hide()
        Padron.Show()
    End Sub

    Private Sub VotosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VotosToolStripMenuItem.Click
        Me.Hide()
        Votos.Show()
    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsuariosToolStripMenuItem.Click
        Me.Hide()
        Usuarios.Show()
    End Sub

    Private Sub PartidosPoliticosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PartidosPoliticosToolStripMenuItem.Click
        Me.Hide()
        Partidos.Show()
    End Sub

    Private Sub CandidatosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CandidatosToolStripMenuItem.Click
        Me.Hide()
        Candidatos.Show()
    End Sub

    Private Sub CargosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CargosToolStripMenuItem.Click
        Me.Hide()
        Cargos.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

    Private Sub IngresarUsuarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IngresarUsuarioToolStripMenuItem.Click
        Me.Hide()
        Ingreso.Show()
    End Sub
End Class
