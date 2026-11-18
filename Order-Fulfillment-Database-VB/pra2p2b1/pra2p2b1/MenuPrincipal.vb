Public Class MenuPrincipal

    Private Sub bsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsalir.Click
        End
    End Sub

    Private Sub bprod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bprod.Click
        Me.Hide()
        Producto.Show()
    End Sub

    Private Sub bcliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bcliente.Click
        Me.Hide()
        Clientes.Show()
    End Sub

    Private Sub bpedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bpedido.Click
        Me.Hide()
        Pedidos.Show()
    End Sub

    Private Sub bprovee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bprovee.Click
        Me.Hide()
        Proveedores.Show()
    End Sub

    Private Sub bempleado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bempleado.Click
        Me.Hide()
        Empleados.Show()
    End Sub

    Private Sub benvio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles benvio.Click
        Me.Hide()
        Envios.Show()
    End Sub

    Private Sub IngresoDeProductosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IngresoDeProductosToolStripMenuItem.Click
        Me.Hide()
        Producto.Show()
    End Sub

    Private Sub IngresarClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IngresarClientesToolStripMenuItem.Click
        Me.Hide()
        Clientes.Show()
    End Sub

    Private Sub IngresarPedidosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IngresarPedidosToolStripMenuItem.Click
        Me.Hide()
        Pedidos.Show()
    End Sub

    Private Sub GestionDeProveedoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GestionDeProveedoresToolStripMenuItem.Click
        Me.Hide()
        Proveedores.Show()
    End Sub

    Private Sub GestionDeEmpleadosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GestionDeEmpleadosToolStripMenuItem.Click
        Me.Hide()
        Empleados.Show()
    End Sub

    Private Sub GestionDeEnviosToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GestionDeEnviosToolStripMenuItem1.Click
        Me.Hide()
        Envios.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub
End Class
