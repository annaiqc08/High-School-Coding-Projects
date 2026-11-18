Public Class Ingreso

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Me.UsuariosTableAdapter.FillByingresar(Me.TSEDataSet.Usuarios, TextBox1.Text, TextBox2.Text) Then
            MsgBox("encontrado")
            Me.Hide()
            MenuP.Show()
            If TipousuarioTextBox.Text = "Verificador" Then
                Candidatos.Button5.Visible = False
                Candidatos.Button7.Visible = False
                Candidatos.Button9.Visible = False
                Cargos.Button5.Visible = False
                Cargos.Button7.Visible = False
                Cargos.Button9.Visible = False
                Departamentos.Button5.Visible = False
                Departamentos.Button7.Visible = False
                Departamentos.Button9.Visible = False
            End If
        Else
            MsgBox("no encontrado")
        End If
    End Sub

    Private Sub UsuariosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.UsuariosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TSEDataSet)

    End Sub

    Private Sub Ingreso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'TSEDataSet.Usuarios' Puede moverla o quitarla según sea necesario.
        Me.UsuariosTableAdapter.Fill(Me.TSEDataSet.Usuarios)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        MenuP.Show()
    End Sub
End Class