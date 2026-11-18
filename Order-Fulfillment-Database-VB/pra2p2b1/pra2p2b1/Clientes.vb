Public Class Clientes

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

    Private Sub GestionDePedidosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GestionDePedidosToolStripMenuItem.Click
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

    Private Sub GestionDeEnviosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GestionDeEnviosToolStripMenuItem.Click
        Me.Hide()
        Envios.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

    Private Sub Clientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Base_de_Datos_PedidosDataSet.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.Base_de_Datos_PedidosDataSet.Clientes)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.ClientesBindingSource.MoveFirst()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.ClientesBindingSource.MovePrevious()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.ClientesBindingSource.MoveNext()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.ClientesBindingSource.MoveLast()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Button7.Visible = True
        IdClienteBx.Text = ""
        NomCliebx.Text = ""
        ApellClieBx.Text = ""
        DirClie.Text = ""
        CiudClie.Text = ""
        CodPosClie.Text = ""
        TelClie.Text = ""
        FaxClie.Text = ""
        CorreoClie.Text = ""
        DPIClie.Text = ""
        IdClienteBx.Enabled = True
        NomCliebx.Enabled = True
        ApellClieBx.Enabled = True
        DirClie.Enabled = True
        CiudClie.Enabled = True
        CodPosClie.Enabled = True
        TelClie.Enabled = True
        FaxClie.Enabled = True
        CorreoClie.Enabled = True
        DPIClie.Enabled = True
       
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        
        Me.ClientesTableAdapter.InsertarCliente(IdClienteBx.Text, NomCliebx.Text, ApellClieBx.Text, DirClie.Text, CiudClie.Text, CodPosClie.Text, TelClie.Text, FaxClie.Text, CorreoClie.Text, DPIClie.Text)
        Me.ClientesTableAdapter.Fill(Me.Base_de_Datos_PedidosDataSet.Clientes)
        Me.Visible = False
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        MsgBox("No podrá recuperar la informacion. Esta seguro de modificar este registro?")
        Button8.Visible = True

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        IdClienteBx.Enabled = True
        NomCliebx.Enabled = True
        ApellClieBx.Enabled = True
        DirClie.Enabled = True
        CiudClie.Enabled = True
        CodPosClie.Enabled = True
        TelClie.Enabled = True
        FaxClie.Enabled = True
        CorreoClie.Enabled = True
        DPIClie.Enabled = True
        Me.ClientesTableAdapter.UpdateQuery(NomCliebx.Text, ApellClieBx.Text, DirClie.Text, CiudClie.Text, CodPosClie.Text, Val(TelClie.Text), Val(FaxClie.Text), CorreoClie.Text, Val(DPIClie.Text), IdClienteBx.Text)
        Me.ClientesTableAdapter.Fill(Me.Base_de_Datos_PedidosDataSet.Clientes)
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Me.ClientesTableAdapter.Delete(IdClienteBx.Text, NomCliebx.Text, ApellClieBx.Text, DirClie.Text, CiudClie.Text, CodPosClie.Text, Val(TelClie.Text), Val(FaxClie.Text), DPIClie.Text)
        Me.ClientesTableAdapter.Fill(Me.Base_de_Datos_PedidosDataSet.Clientes)
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Me.ClientesTableAdapter.cliente(TextBox1.Text)
        IdClienteBx.Text = Me.Base_de_Datos_PedidosDataSet.Clientes.IdClienteColumn
        Me.ClientesTableAdapter.Fill(Me.Base_de_Datos_PedidosDataSet.Clientes)
    End Sub
End Class