Public Class Pedidos

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        MenuPrincipal.Show()
    End Sub

    Private Sub VolverAMenuPrincipalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VolverAMenuPrincipalToolStripMenuItem.Click
        Me.Hide()
        MenuPrincipal.Show()
    End Sub

    Private Sub GestionDeProductosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GestionDeProductosToolStripMenuItem.Click
        Me.Hide()
        Producto.Show()
    End Sub

    Private Sub GestionDeClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GestionDeClientesToolStripMenuItem.Click
        Me.Hide()
        Clientes.Show()
    End Sub

    Private Sub GestionDeProveedoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GestionDeProveedoresToolStripMenuItem.Click
        Me.Hide()
        Proveedores.Show()
    End Sub

    Private Sub GestionDeEmpleadosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GestionDeEmpleadosToolStripMenuItem.Click
        Me.Hide()
        Empleados.Show()
    End Sub

    Private Sub GestionDeEnviosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GestionDeEnviosToolStripMenuItem.Click
        Me.Hide()
        Envios.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

    Private Sub Pedidos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Base_de_Datos_PedidosDataSet.Pedidos' Puede moverla o quitarla según sea necesario.
        Me.PedidosTableAdapter.Fill(Me.Base_de_Datos_PedidosDataSet.Pedidos)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.PedidosBindingSource.MoveFirst()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.PedidosBindingSource.MovePrevious()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.PedidosBindingSource.MoveNext()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.PedidosBindingSource.MoveLast()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        IdPed.Text = ""
        IdCliePed.Text = ""
        FechaPed.Value = ""
        FechaEnvio.Value = ""
        ModEnvio.Text = ""
        IdEmplePed.Text = ""
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Me.PedidosTableAdapter.InsertarPed(IdPed.Text, IdCliePed.Text, FechaPed.Text, FechaEnvio.Text, ModEnvio.Text, IdEmplePed.Text)
        Me.PedidosTableAdapter.Fill(Me.Base_de_Datos_PedidosDataSet.Pedidos)
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        MsgBox("No podrá recuperar la informacion. Esta seguro de modificar este registro?")
        Button8.Visible = True
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click

    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Me.PedidosTableAdapter.Delete(IdPed.Text, IdCliePed.Text, FechaPed.Text, FechaEnvio.Text, ModEnvio.Text, IdEmplePed.Text)
        Me.PedidosTableAdapter.Fill(Me.Base_de_Datos_PedidosDataSet.Pedidos)
    End Sub
End Class