Public Class Medicos

    Private Sub MedicosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.MedicosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ClinicDataSet)

    End Sub

    Private Sub Medicos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ClinicDataSet.pacientes' Puede moverla o quitarla según sea necesario.
        Me.PacientesTableAdapter.Fill(Me.ClinicDataSet.pacientes)
        'TODO: esta línea de código carga datos en la tabla 'ClinicDataSet.Citas' Puede moverla o quitarla según sea necesario.
        Me.CitasTableAdapter.Fill(Me.ClinicDataSet.Citas)
        'TODO: esta línea de código carga datos en la tabla 'ClinicDataSet.medicos' Puede moverla o quitarla según sea necesario.
        Me.MedicosTableAdapter.Fill(Me.ClinicDataSet.medicos)

    End Sub
End Class