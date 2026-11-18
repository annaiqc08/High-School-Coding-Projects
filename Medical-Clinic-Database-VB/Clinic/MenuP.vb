Public Class MenuP

    
    Private Sub ControlDeClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ControlDeClientesToolStripMenuItem.Click
        Me.Hide()
        Clientes.Show()
    End Sub

    Private Sub ControlDeCitasToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ControlDeCitasToolStripMenuItem1.Click
        Me.Hide()
        Citas.Show()
    End Sub

    Private Sub ListaDeMedicosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListaDeMedicosToolStripMenuItem.Click
        Me.Hide()
        Medicos.Show()
    End Sub

    Private Sub ListaDeEmpleadosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListaDeEmpleadosToolStripMenuItem.Click
        Me.Hide()
        Empleados.Show()
    End Sub

    Private Sub ControlDeVentasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ControlDeVentasToolStripMenuItem.Click
        Me.Hide()
        Ventas.Show()
    End Sub

    Private Sub ControlDelInventarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ControlDelInventarioToolStripMenuItem.Click
        Me.Hide()
        Inventario.Show()
    End Sub
End Class
