Public Class Usuarios

    Private Sub UsuariosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.UsuariosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TSEDataSet)

    End Sub

    Private Sub Usuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'TSEDataSet.Usuarios' Puede moverla o quitarla según sea necesario.
        Me.UsuariosTableAdapter.Fill(Me.TSEDataSet.Usuarios)

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

    Private Sub PadronToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PadronToolStripMenuItem.Click
        Me.Hide()
        Padron.Show()
    End Sub

    Private Sub VotosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VotosToolStripMenuItem.Click
        Me.Hide()
        Votos.Show()
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
        Me.UsuariosBindingSource.MoveFirst()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.UsuariosBindingSource.MovePrevious()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.UsuariosBindingSource.MoveNext()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.UsuariosBindingSource.MoveLast()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        CodusuarioTextBox.Text = ""
        UsuarioTextBox.Text = ""
        PasswordTextBox.Text = ""
        TipousuarioTextBox.Text = ""
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        UsuariosTableAdapter.Insusuario(Val(CodusuarioTextBox.Text), UsuarioTextBox.Text, PasswordTextBox.Text, TipousuarioTextBox.Text)
        Me.UsuariosTableAdapter.Fill(Me.TSEDataSet.Usuarios)
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        UsuariosTableAdapter.Updusuario(Val(CodusuarioTextBox.Text), UsuarioTextBox.Text, PasswordTextBox.Text, TipousuarioTextBox.Text, Val(CodusuarioTextBox.Text))
        Me.UsuariosTableAdapter.Fill(Me.TSEDataSet.Usuarios)
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Me.UsuariosTableAdapter.FillByusuario(Me.TSEDataSet.Usuarios, Val(CodusuarioTextBox.Text))
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        UsuariosTableAdapter.Delusuario(Val(CodusuarioTextBox.Text))
        Me.UsuariosTableAdapter.Fill(Me.TSEDataSet.Usuarios)
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Me.UsuariosTableAdapter.Fill(Me.TSEDataSet.Usuarios)
    End Sub
End Class