Public Class Partidos

    Private Sub PartidosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.PartidosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TSEDataSet)

    End Sub

    Private Sub Partidos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'TSEDataSet.Partidos' Puede moverla o quitarla según sea necesario.
        Me.PartidosTableAdapter.Fill(Me.TSEDataSet.Partidos)

    End Sub

    Private Sub CandidatosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CandidatosToolStripMenuItem.Click
        Me.Hide()
        Candidatos.Show()
    End Sub

    Private Sub CargosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CargosToolStripMenuItem.Click
        Me.Hide()
        Cargos.Show()
    End Sub

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

    Private Sub MenuPrincipalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuPrincipalToolStripMenuItem.Click
        Me.Hide()
        MenuP.Show()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Me.Hide()
        MenuP.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.PartidosBindingSource.MoveFirst()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.PartidosBindingSource.MovePrevious()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.PartidosBindingSource.MoveNext()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.PartidosBindingSource.MoveLast()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        CodpartidoTextBox.Text = ""
        PartidoTextBox.Text = ""
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        PartidosTableAdapter.Inspart(Val(CodpartidoTextBox.Text), PartidoTextBox.Text)
        Me.PartidosTableAdapter.Fill(Me.TSEDataSet.Partidos)
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        PartidosTableAdapter.Updpart(Val(CodpartidoTextBox.Text), PartidoTextBox.Text, Val(CodpartidoTextBox.Text))
        Me.PartidosTableAdapter.Fill(Me.TSEDataSet.Partidos)
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Me.PartidosTableAdapter.FillBypart(Me.TSEDataSet.Partidos, Val(CodpartidoTextBox.Text))
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        PartidosTableAdapter.Delpart(Val(CodpartidoTextBox.Text))
        Me.PartidosTableAdapter.Fill(Me.TSEDataSet.Partidos)
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Me.PartidosTableAdapter.Fill(Me.TSEDataSet.Partidos)
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Me.PartidosTableAdapter.Fill(Me.TSEDataSet.Partidos)
    End Sub
End Class