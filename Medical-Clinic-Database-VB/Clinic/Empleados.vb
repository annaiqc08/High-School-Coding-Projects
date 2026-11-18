Public Class Empleados

    Private Sub EmpleadosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.EmpleadosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ClinicDataSet)

    End Sub

    Private Sub Empleados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ClinicDataSet.ventas' Puede moverla o quitarla según sea necesario.
        Me.VentasTableAdapter.Fill(Me.ClinicDataSet.ventas)
        'TODO: esta línea de código carga datos en la tabla 'ClinicDataSet.Citas' Puede moverla o quitarla según sea necesario.
        Me.CitasTableAdapter.Fill(Me.ClinicDataSet.Citas)
        'TODO: esta línea de código carga datos en la tabla 'ClinicDataSet.empleados' Puede moverla o quitarla según sea necesario.
        Me.EmpleadosTableAdapter.Fill(Me.ClinicDataSet.empleados)

    End Sub
End Class