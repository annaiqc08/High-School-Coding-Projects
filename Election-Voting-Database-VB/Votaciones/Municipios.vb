Public Class Municipios

    Private Sub MunicipiosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.MunicipiosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TSEDataSet)

    End Sub

    Private Sub Municipios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'TSEDataSet.Municipios' Puede moverla o quitarla según sea necesario.
        Me.MunicipiosTableAdapter.Fill(Me.TSEDataSet.Municipios)

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

    Private Sub DepartamentosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DepartamentosToolStripMenuItem.Click
        Me.Hide()
        Departamentos.Show()
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
        Me.MunicipiosBindingSource.MoveFirst()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.MunicipiosBindingSource.MovePrevious()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.MunicipiosBindingSource.MoveNext()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.MunicipiosBindingSource.MoveLast()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        CodmunicipioTextBox.Text = ""
        MunicipioTextBox.Text = ""
        CoddepartamTextBox.Text = ""
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        MunicipiosTableAdapter.Insmuni(Val(CodmunicipioTextBox.Text), MunicipioTextBox.Text, Val(CoddepartamTextBox.Text))
        Me.MunicipiosTableAdapter.Fill(Me.TSEDataSet.Municipios)
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        MunicipiosTableAdapter.Updmuni(Val(CodmunicipioTextBox.Text), MunicipioTextBox.Text, Val(CoddepartamTextBox.Text), Val(CodmunicipioTextBox.Text))
        Me.MunicipiosTableAdapter.Fill(Me.TSEDataSet.Municipios)
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Me.MunicipiosTableAdapter.FillBymuni(Me.TSEDataSet.Municipios, Val(CodmunicipioTextBox.Text))
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        MunicipiosTableAdapter.Delmuni(Val(CodmunicipioTextBox.Text))
        Me.MunicipiosTableAdapter.Fill(Me.TSEDataSet.Municipios)
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Me.MunicipiosTableAdapter.Fill(Me.TSEDataSet.Municipios)
    End Sub
End Class