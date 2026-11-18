Public Class Citas

    Private Sub CitasBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.CitasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ClinicDataSet)

    End Sub

    Private Sub Citas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ClinicDataSet.Citas' Puede moverla o quitarla según sea necesario.
        Me.CitasTableAdapter.Fill(Me.ClinicDataSet.Citas)

    End Sub
End Class