Public Class Inventario

    Private Sub InventarioBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.InventarioBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ClinicDataSet)

    End Sub

    Private Sub Inventario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ClinicDataSet.ventas' Puede moverla o quitarla según sea necesario.
        Me.VentasTableAdapter.Fill(Me.ClinicDataSet.ventas)
        'TODO: esta línea de código carga datos en la tabla 'ClinicDataSet.inventario' Puede moverla o quitarla según sea necesario.
        Me.InventarioTableAdapter.Fill(Me.ClinicDataSet.inventario)

    End Sub
End Class