<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuPrincipal
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
        Me.bprod = New System.Windows.Forms.Button()
        Me.bcliente = New System.Windows.Forms.Button()
        Me.bpedido = New System.Windows.Forms.Button()
        Me.bprovee = New System.Windows.Forms.Button()
        Me.bempleado = New System.Windows.Forms.Button()
        Me.benvio = New System.Windows.Forms.Button()
        Me.bsalir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.IngresoDeProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IngresarClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PedidosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IngresarPedidosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionDeProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionDeEmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionDeEnviosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionDeEnviosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'bprod
        '
        Me.bprod.BackColor = System.Drawing.Color.NavajoWhite
        Me.bprod.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bprod.Location = New System.Drawing.Point(40, 118)
        Me.bprod.Name = "bprod"
        Me.bprod.Size = New System.Drawing.Size(110, 45)
        Me.bprod.TabIndex = 0
        Me.bprod.Text = "Productos"
        Me.bprod.UseVisualStyleBackColor = False
        '
        'bcliente
        '
        Me.bcliente.BackColor = System.Drawing.Color.NavajoWhite
        Me.bcliente.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bcliente.Location = New System.Drawing.Point(156, 118)
        Me.bcliente.Name = "bcliente"
        Me.bcliente.Size = New System.Drawing.Size(110, 45)
        Me.bcliente.TabIndex = 1
        Me.bcliente.Text = "Clientes"
        Me.bcliente.UseVisualStyleBackColor = False
        '
        'bpedido
        '
        Me.bpedido.BackColor = System.Drawing.Color.NavajoWhite
        Me.bpedido.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bpedido.Location = New System.Drawing.Point(272, 118)
        Me.bpedido.Name = "bpedido"
        Me.bpedido.Size = New System.Drawing.Size(110, 45)
        Me.bpedido.TabIndex = 2
        Me.bpedido.Text = "Pedidos"
        Me.bpedido.UseVisualStyleBackColor = False
        '
        'bprovee
        '
        Me.bprovee.BackColor = System.Drawing.Color.NavajoWhite
        Me.bprovee.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bprovee.Location = New System.Drawing.Point(96, 181)
        Me.bprovee.Name = "bprovee"
        Me.bprovee.Size = New System.Drawing.Size(110, 45)
        Me.bprovee.TabIndex = 3
        Me.bprovee.Text = "Proveedores"
        Me.bprovee.UseVisualStyleBackColor = False
        '
        'bempleado
        '
        Me.bempleado.BackColor = System.Drawing.Color.NavajoWhite
        Me.bempleado.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bempleado.Location = New System.Drawing.Point(212, 181)
        Me.bempleado.Name = "bempleado"
        Me.bempleado.Size = New System.Drawing.Size(110, 45)
        Me.bempleado.TabIndex = 4
        Me.bempleado.Text = "Empleados"
        Me.bempleado.UseVisualStyleBackColor = False
        '
        'benvio
        '
        Me.benvio.BackColor = System.Drawing.Color.NavajoWhite
        Me.benvio.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.benvio.Location = New System.Drawing.Point(156, 243)
        Me.benvio.Name = "benvio"
        Me.benvio.Size = New System.Drawing.Size(110, 45)
        Me.benvio.TabIndex = 5
        Me.benvio.Text = "Envios"
        Me.benvio.UseVisualStyleBackColor = False
        '
        'bsalir
        '
        Me.bsalir.BackColor = System.Drawing.Color.NavajoWhite
        Me.bsalir.Font = New System.Drawing.Font("Eras Medium ITC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bsalir.Location = New System.Drawing.Point(416, 349)
        Me.bsalir.Name = "bsalir"
        Me.bsalir.Size = New System.Drawing.Size(46, 34)
        Me.bsalir.TabIndex = 6
        Me.bsalir.Text = "Salir"
        Me.bsalir.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Book", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(155, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 34)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "N-BIOS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Book", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(110, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(186, 34)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Menu Principal"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductosToolStripMenuItem, Me.ClientesToolStripMenuItem, Me.PedidosToolStripMenuItem, Me.ProveedoresToolStripMenuItem, Me.EmpleadosToolStripMenuItem, Me.GestionDeEnviosToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(474, 24)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ProductosToolStripMenuItem
        '
        Me.ProductosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.IngresoDeProductosToolStripMenuItem})
        Me.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        Me.ProductosToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.ProductosToolStripMenuItem.Text = "Productos"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(184, 6)
        '
        'IngresoDeProductosToolStripMenuItem
        '
        Me.IngresoDeProductosToolStripMenuItem.Name = "IngresoDeProductosToolStripMenuItem"
        Me.IngresoDeProductosToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.IngresoDeProductosToolStripMenuItem.Text = "Gestion de Productos"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IngresarClientesToolStripMenuItem})
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'IngresarClientesToolStripMenuItem
        '
        Me.IngresarClientesToolStripMenuItem.Name = "IngresarClientesToolStripMenuItem"
        Me.IngresarClientesToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.IngresarClientesToolStripMenuItem.Text = "Gestion de Clientes"
        '
        'PedidosToolStripMenuItem
        '
        Me.PedidosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IngresarPedidosToolStripMenuItem})
        Me.PedidosToolStripMenuItem.Name = "PedidosToolStripMenuItem"
        Me.PedidosToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.PedidosToolStripMenuItem.Text = "Pedidos"
        '
        'IngresarPedidosToolStripMenuItem
        '
        Me.IngresarPedidosToolStripMenuItem.Name = "IngresarPedidosToolStripMenuItem"
        Me.IngresarPedidosToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.IngresarPedidosToolStripMenuItem.Text = "Gestion de Pedidos"
        '
        'ProveedoresToolStripMenuItem
        '
        Me.ProveedoresToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestionDeProveedoresToolStripMenuItem})
        Me.ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem"
        Me.ProveedoresToolStripMenuItem.Size = New System.Drawing.Size(87, 20)
        Me.ProveedoresToolStripMenuItem.Text = "Proveedores "
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
        'GestionDeEnviosToolStripMenuItem
        '
        Me.GestionDeEnviosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestionDeEnviosToolStripMenuItem1})
        Me.GestionDeEnviosToolStripMenuItem.Name = "GestionDeEnviosToolStripMenuItem"
        Me.GestionDeEnviosToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.GestionDeEnviosToolStripMenuItem.Text = "Envios"
        '
        'GestionDeEnviosToolStripMenuItem1
        '
        Me.GestionDeEnviosToolStripMenuItem1.Name = "GestionDeEnviosToolStripMenuItem1"
        Me.GestionDeEnviosToolStripMenuItem1.Size = New System.Drawing.Size(167, 22)
        Me.GestionDeEnviosToolStripMenuItem1.Text = "Gestion de Envios"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'MenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(474, 395)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bsalir)
        Me.Controls.Add(Me.benvio)
        Me.Controls.Add(Me.bempleado)
        Me.Controls.Add(Me.bprovee)
        Me.Controls.Add(Me.bpedido)
        Me.Controls.Add(Me.bcliente)
        Me.Controls.Add(Me.bprod)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MenuPrincipal"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bprod As System.Windows.Forms.Button
    Friend WithEvents bcliente As System.Windows.Forms.Button
    Friend WithEvents bpedido As System.Windows.Forms.Button
    Friend WithEvents bprovee As System.Windows.Forms.Button
    Friend WithEvents bempleado As System.Windows.Forms.Button
    Friend WithEvents benvio As System.Windows.Forms.Button
    Friend WithEvents bsalir As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ProductosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents IngresoDeProductosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IngresarClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PedidosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IngresarPedidosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmpleadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestionDeEmpleadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestionDeEnviosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestionDeProveedoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestionDeEnviosToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
