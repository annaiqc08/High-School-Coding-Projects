Public Class Padron

    Private Sub PadronBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.PadronBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TSEDataSet)

    End Sub

    Private Sub Padron_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'TSEDataSet.Padron' Puede moverla o quitarla según sea necesario.
        Me.PadronTableAdapter.Fill(Me.TSEDataSet.Padron)

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

    Private Sub MunicipiosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MunicipiosToolStripMenuItem.Click
        Me.Hide()
        Municipios.Show()
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
        Me.PadronBindingSource.MoveFirst()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.PadronBindingSource.MovePrevious()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.PadronBindingSource.MoveNext()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.PadronBindingSource.MoveLast()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        CodpadronTextBox.Text = ""
        NombreTextBox.Text = ""
        ApellidoTextBox.Text = ""
        DPITextBox.Text = ""
        DireccionTextBox.Text = ""
        CodmunicipioTextBox.Text = ""
        CoddepartamTextBox.Text = ""
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        PadronTableAdapter.Inspad(Val(CodpadronTextBox.Text), NombreTextBox.Text, ApellidoTextBox.Text, DPITextBox.Text, DireccionTextBox.Text, Val(CodmunicipioTextBox.Text), Val(CoddepartamTextBox.Text))
        Me.PadronTableAdapter.Fill(Me.TSEDataSet.Padron)
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        PadronTableAdapter.Updpad(Val(CodpadronTextBox.Text), NombreTextBox.Text, ApellidoTextBox.Text, DPITextBox.Text, DireccionTextBox.Text, Val(CodmunicipioTextBox.Text), Val(CoddepartamTextBox.Text), Val(CodpadronTextBox.Text))
        Me.PadronTableAdapter.Fill(Me.TSEDataSet.Padron)
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Me.PadronTableAdapter.FillBypad(Me.TSEDataSet.Padron, Val(CodpadronTextBox.Text))
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        PadronTableAdapter.Delpad(Val(CodpadronTextBox.Text))
        Me.PadronTableAdapter.Fill(Me.TSEDataSet.Padron)
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Me.PadronTableAdapter.Fill(Me.TSEDataSet.Padron)
    End Sub
End Class