Public Class Empleados

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

    Private Sub GestionDeProveedoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GestionDeProveedoresToolStripMenuItem.Click
        Me.Hide()
        Proveedores.Show()
    End Sub

    Private Sub GestionDeEnviosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GestionDeEnviosToolStripMenuItem.Click
        Me.Hide()
        Envios.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

    Private Sub Empleados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Base_de_Datos_PedidosDataSet.Empleados' Puede moverla o quitarla según sea necesario.
        Me.EmpleadosTableAdapter.Fill(Me.Base_de_Datos_PedidosDataSet.Empleados)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.EmpleadosBindingSource.MoveFirst()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.EmpleadosBindingSource.MovePrevious()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.EmpleadosBindingSource.MoveNext()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.EmpleadosBindingSource.MoveLast()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        IdEmple.Text = ""
        NomEmple.Text = ""
        ApellEmple.Text = ""
        CiudEmple.Text = ""
        TelEmple.Text = ""
        CorreoEmple.Text = ""
        DPIEmple.Text = ""
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Me.EmpleadosTableAdapter.InsertarEmpleado(IdEmple.Text, NomEmple.Text, ApellEmple.Text, CiudEmple.Text, TelEmple.Text, CorreoEmple.Text, DPIEmple.Text)
        Me.EmpleadosTableAdapter.Fill(Me.Base_de_Datos_PedidosDataSet.Empleados)
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        MsgBox("No podrá recuperar la informacion. Esta seguro de modificar este registro?")
        Button8.Visible = True
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click

    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Me.EmpleadosTableAdapter.Delete(IdEmple.Text, NomEmple.Text, ApellEmple.Text, CiudEmple.Text, TelEmple.Text, Val(DPIEmple.Text))
        Me.EmpleadosTableAdapter.Fill(Me.Base_de_Datos_PedidosDataSet.Empleados)
    End Sub
End Class