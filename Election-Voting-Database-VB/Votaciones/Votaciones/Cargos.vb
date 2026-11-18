Public Class Cargos

    Private Sub CargosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.CargosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TSEDataSet)

    End Sub

    Private Sub Cargos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'TSEDataSet.Cargos' Puede moverla o quitarla según sea necesario.
        Me.CargosTableAdapter.Fill(Me.TSEDataSet.Cargos)

    End Sub

    Private Sub PartidosPolititcosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PartidosPolititcosToolStripMenuItem.Click
        Me.Hide()
        Partidos.Show()
    End Sub

    Private Sub CandidatosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CandidatosToolStripMenuItem.Click
        Me.Hide()
        Candidatos.Show()
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
        Me.CargosBindingSource.MoveFirst()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.CargosBindingSource.MovePrevious()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.CargosBindingSource.MoveNext()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.CargosBindingSource.MoveLast()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        CodcargoTextBox.Text = ""
        CargoTextBox.Text = ""
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        CargosTableAdapter.Insert(Val(CodcargoTextBox.Text), CargoTextBox.Text)
        Me.CargosTableAdapter.Fill(Me.TSEDataSet.Cargos)
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        CargosTableAdapter.Updcargo(Val(CodcargoTextBox.Text), CargoTextBox.Text, Val(CodcargoTextBox.Text))
        Me.CargosTableAdapter.Fill(Me.TSEDataSet.Cargos)
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Me.CargosTableAdapter.FillBycargo(Me.TSEDataSet.Cargos, Val(CodcargoTextBox.Text))
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        CargosTableAdapter.Delcargo(Val(CodcargoTextBox.Text))
        Me.CargosTableAdapter.Fill(Me.TSEDataSet.Cargos)
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Me.CargosTableAdapter.Fill(Me.TSEDataSet.Cargos)
    End Sub
End Class