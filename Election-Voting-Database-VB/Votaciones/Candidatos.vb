Public Class Candidatos
    Dim buscar As Integer
    Private Sub CandidatosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.CandidatosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TSEDataSet)

    End Sub

    Private Sub Candidatos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'TSEDataSet.Candidatos' Puede moverla o quitarla según sea necesario.
        Me.CandidatosTableAdapter.Fill(Me.TSEDataSet.Candidatos)

    End Sub

    Private Sub PartidosPoliticosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PartidosPoliticosToolStripMenuItem.Click
        Me.Hide()
        Partidos.Show()
    End Sub

    Private Sub CargosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CargosToolStripMenuItem.Click
        Me.Hide()
        Cargos.Show()
    End Sub

    Private Sub DepartamentosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DepartamentosToolStripMenuItem.Click
        Me.Hide()
        Departamentos.Show()
    End Sub

    Private Sub MunicipioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MunicipioToolStripMenuItem.Click
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
        Me.CandidatosBindingSource.MoveFirst()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.CandidatosBindingSource.MovePrevious()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.CandidatosBindingSource.MoveNext()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.CandidatosBindingSource.MoveLast()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        CodcandidatoTextBox.Text = ""
        NombreTextBox.Text = ""
        CodpartidoTextBox.Text = ""
        CodcargoTextBox.Text = ""
        CodmunicipioTextBox.Text = ""
        CoddepartamTextBox.Text = ""
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        CandidatosTableAdapter.InsertarCand(Val(CodcandidatoTextBox.Text), NombreTextBox.Text, Val(CodpartidoTextBox.Text), Val(CodcargoTextBox.Text), Val(CodmunicipioTextBox.Text), Val(CoddepartamTextBox.Text))
        Me.CandidatosTableAdapter.Fill(Me.TSEDataSet.Candidatos)
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        CandidatosTableAdapter.UpdCand(Val(CodcandidatoTextBox.Text), NombreTextBox.Text, Val(CodpartidoTextBox.Text), Val(CodcargoTextBox.Text), Val(CodmunicipioTextBox.Text), Val(CoddepartamTextBox.Text), Val(CodcandidatoTextBox.Text))
        Me.CandidatosTableAdapter.Fill(Me.TSEDataSet.Candidatos)
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Me.CandidatosTableAdapter.FillByCand(Me.TSEDataSet.Candidatos, Val(CodcandidatoTextBox.Text))
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        CandidatosTableAdapter.DelCand(Val(CodcandidatoTextBox.Text))
        Me.CandidatosTableAdapter.Fill(Me.TSEDataSet.Candidatos)
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Me.CandidatosTableAdapter.Fill(Me.TSEDataSet.Candidatos)
    End Sub
End Class