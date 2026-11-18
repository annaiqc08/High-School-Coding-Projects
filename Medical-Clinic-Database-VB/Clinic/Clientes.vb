Public Class Clientes

    Private Sub PacientesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.PacientesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ClinicDataSet)

    End Sub

    Private Sub Clientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ClinicDataSet.pacientes' Puede moverla o quitarla según sea necesario.
        Me.PacientesTableAdapter.Fill(Me.ClinicDataSet.pacientes)

    End Sub
End Class