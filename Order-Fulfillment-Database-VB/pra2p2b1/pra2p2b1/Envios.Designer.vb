<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Envios
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Modenvio = New System.Windows.Forms.TextBox()
        Me.ModosEnvioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Base_de_Datos_PedidosDataSet = New pra2p2b1.Base_de_Datos_PedidosDataSet()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuPrincipalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VolverAMenuPrincipalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionDeProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionDeClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PedidosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionDePedidosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionDeProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionDeEmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Modos_EnvioTableAdapter = New pra2p2b1.Base_de_Datos_PedidosDataSetTableAdapters.Modos_EnvioTableAdapter()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        CType(Me.ModosEnvioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Base_de_Datos_PedidosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.NavajoWhite
        Me.Button1.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(407, 123)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 48)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Menu Principal"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Book", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 34)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Envios"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Modos de Envio:"
        '
        'Modenvio
        '
        Me.Modenvio.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ModosEnvioBindingSource, "Modos Envios", True))
        Me.Modenvio.Location = New System.Drawing.Point(113, 70)
        Me.Modenvio.Name = "Modenvio"
        Me.Modenvio.Size = New System.Drawing.Size(200, 20)
        Me.Modenvio.TabIndex = 3
        '
        'ModosEnvioBindingSource
        '
        Me.ModosEnvioBindingSource.DataMember = "Modos Envio"
        Me.ModosEnvioBindingSource.DataSource = Me.Base_de_Datos_PedidosDataSet
        '
        'Base_de_Datos_PedidosDataSet
        '
        Me.Base_de_Datos_PedidosDataSet.DataSetName = "Base_de_Datos_PedidosDataSet"
        Me.Base_de_Datos_PedidosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuPrincipalToolStripMenuItem, Me.ProductosToolStripMenuItem, Me.ClientesToolStripMenuItem, Me.PedidosToolStripMenuItem, Me.ProveedoresToolStripMenuItem, Me.EmpleadosToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(509, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuPrincipalToolStripMenuItem
        '
        Me.MenuPrincipalToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VolverAMenuPrincipalToolStripMenuItem})
        Me.MenuPrincipalToolStripMenuItem.Name = "MenuPrincipalToolStripMenuItem"
        Me.MenuPrincipalToolStripMenuItem.Size = New System.Drawing.Size(99, 20)
        Me.MenuPrincipalToolStripMenuItem.Text = "Menu Principal"
        '
        'VolverAMenuPrincipalToolStripMenuItem
        '
        Me.VolverAMenuPrincipalToolStripMenuItem.Name = "VolverAMenuPrincipalToolStripMenuItem"
        Me.VolverAMenuPrincipalToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.VolverAMenuPrincipalToolStripMenuItem.Text = "Volver a Menu Principal"
        '
        'ProductosToolStripMenuItem
        '
        Me.ProductosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestionDeProductosToolStripMenuItem})
        Me.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        Me.ProductosToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.ProductosToolStripMenuItem.Text = "Productos"
        '
        'GestionDeProductosToolStripMenuItem
        '
        Me.GestionDeProductosToolStripMenuItem.Name = "GestionDeProductosToolStripMenuItem"
        Me.GestionDeProductosToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.GestionDeProductosToolStripMenuItem.Text = "Gestion de Productos"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestionDeClientesToolStripMenuItem})
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'GestionDeClientesToolStripMenuItem
        '
        Me.GestionDeClientesToolStripMenuItem.Name = "GestionDeClientesToolStripMenuItem"
        Me.GestionDeClientesToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.GestionDeClientesToolStripMenuItem.Text = "Gestion de Clientes"
        '
        'PedidosToolStripMenuItem
        '
        Me.PedidosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestionDePedidosToolStripMenuItem})
        Me.PedidosToolStripMenuItem.Name = "PedidosToolStripMenuItem"
        Me.PedidosToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.PedidosToolStripMenuItem.Text = "Pedidos"
        '
        'GestionDePedidosToolStripMenuItem
        '
        Me.GestionDePedidosToolStripMenuItem.Name = "GestionDePedidosToolStripMenuItem"
        Me.GestionDePedidosToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.GestionDePedidosToolStripMenuItem.Text = "Gestion de Pedidos"
        '
        'ProveedoresToolStripMenuItem
        '
        Me.ProveedoresToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestionDeProveedoresToolStripMenuItem})
        Me.ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem"
        Me.ProveedoresToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
        Me.ProveedoresToolStripMenuItem.Text = "Proveedores"
        '
        'GestionDeProveedoresToolStripMenuItem
        '
        Me.GestionDeProveedoresToolStripMenuItem.Name = "GestionDeProveedoresToolStripMenuItem"
        Me.GestionDeProveedoresToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.GestionDeProveedoresToolStripMenuItem.Text = "Gestion de Proveedores"
        '
        'EmpleadosToolStripMenuItem
        '
        Me.EmpleadosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestionDeEmpleadosToolStripMenuItem})
        Me.EmpleadosToolStripMenuItem.Name = "EmpleadosToolStripMenuItem"
        Me.EmpleadosToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.EmpleadosToolStripMenuItem.Text = "Empleados"
        '
        'GestionDeEmpleadosToolStripMenuItem
        '
        Me.GestionDeEmpleadosToolStripMenuItem.Name = "GestionDeEmpleadosToolStripMenuItem"
        Me.GestionDeEmpleadosToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.GestionDeEmpleadosToolStripMenuItem.Text = "Gestion de Empleados"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'Modos_EnvioTableAdapter
        '
        Me.Modos_EnvioTableAdapter.ClearBeforeFill = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 148)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Primero"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(93, 148)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Anterior"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(174, 148)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = "Siguiente"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(255, 148)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 8
        Me.Button5.Text = "Ultimo"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(422, 63)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 9
        Me.Button6.Text = "Nuevo"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(422, 94)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 23)
        Me.Button7.TabIndex = 10
        Me.Button7.Text = "Agregar"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(328, 48)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(75, 23)
        Me.Button9.TabIndex = 32
        Me.Button9.Text = "Modificar"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(328, 105)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(75, 23)
        Me.Button8.TabIndex = 31
        Me.Button8.Text = "Actualizar"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Envios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(509, 183)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Modenvio)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Envios"
        Me.Text = "Envios"
        CType(Me.ModosEnvioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Base_de_Datos_PedidosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Modenvio As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuPrincipalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VolverAMenuPrincipalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestionDeProductosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestionDeClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PedidosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestionDePedidosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestionDeProveedoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmpleadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestionDeEmpleadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Base_de_Datos_PedidosDataSet As pra2p2b1.Base_de_Datos_PedidosDataSet
    Friend WithEvents ModosEnvioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Modos_EnvioTableAdapter As pra2p2b1.Base_de_Datos_PedidosDataSetTableAdapters.Modos_EnvioTableAdapter
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
End Class
