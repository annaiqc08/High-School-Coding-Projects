Public Class Proveedores

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

    Private Sub GestionDePedidosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GestionDePedidosToolStripMenuItem.Click
        Me.Hide()
        Pedidos.Show()
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

    Private Sub Proveedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Base_de_Datos_PedidosDataSet.Proveedores' Puede moverla o quitarla según sea necesario.
        Me.ProveedoresTableAdapter.Fill(Me.Base_de_Datos_PedidosDataSet.Proveedores)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.ProveedoresBindingSource.MoveFirst()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.ProveedoresBindingSource.MovePrevious()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.ProveedoresBindingSource.MoveNext()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.ProveedoresBindingSource.MoveLast()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        IdProv.Text = ""
        NomProv.Text = ""
        ConProv.Text = ""
        DirProv.Text = ""
        PobProv.Text = ""
        CodpostProv.Text = ""
        TelProv.Text = ""
        FaxProv.Text = ""
        CorreoProv.Text = ""
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Me.ProveedoresTableAdapter.InsertarProveedor(IdProv.Text, NomProv.Text, ConProv.Text, DirProv.Text, PobProv.Text, CodpostProv.Text, TelProv.Text, FaxProv.Text, CorreoProv.Text)
        Me.ProveedoresTableAdapter.Fill(Me.Base_de_Datos_PedidosDataSet.Proveedores)
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click

    End Sub
End Class