<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pedidos
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
        Me.IdPed = New System.Windows.Forms.TextBox()
        Me.PedidosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Base_de_Datos_PedidosDataSet = New pra2p2b1.Base_de_Datos_PedidosDataSet()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.IdCliePed = New System.Windows.Forms.TextBox()
        Me.PedidosBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PedidosBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PedidosBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ModEnvio = New System.Windows.Forms.TextBox()
        Me.PedidosBindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.IdEmplePed = New System.Windows.Forms.TextBox()
        Me.PedidosBindingSource5 = New System.Windows.Forms.BindingSource(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuPrincipalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VolverAMenuPrincipalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionDeProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionDeClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionDeProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionDeEmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnviosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionDeEnviosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PedidosTableAdapter = New pra2p2b1.Base_de_Datos_PedidosDataSetTableAdapters.PedidosTableAdapter()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.FechaPed = New System.Windows.Forms.DateTimePicker()
        Me.FechaEnvio = New System.Windows.Forms.DateTimePicker()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        CType(Me.PedidosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Base_de_Datos_PedidosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PedidosBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PedidosBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PedidosBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PedidosBindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PedidosBindingSource5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.NavajoWhite
        Me.Button1.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(422, 229)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(83, 49)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Menu Principal"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Book", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 34)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Pedidos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Id Pedido:"
        '
        'IdPed
        '
        Me.IdPed.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PedidosBindingSource, "IdPedido", True))
        Me.IdPed.Location = New System.Drawing.Point(102, 88)
        Me.IdPed.Name = "IdPed"
        Me.IdPed.Size = New System.Drawing.Size(100, 20)
        Me.IdPed.TabIndex = 3
        '
        'PedidosBindingSource
        '
        Me.PedidosBindingSource.DataMember = "Pedidos"
        Me.PedidosBindingSource.DataSource = Me.Base_de_Datos_PedidosDataSet
        '
        'Base_de_Datos_PedidosDataSet
        '
        Me.Base_de_Datos_PedidosDataSet.DataSetName = "Base_de_Datos_PedidosDataSet"
        Me.Base_de_Datos_PedidosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(42, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Id Cliente:"
        '
        'IdCliePed
        '
        Me.IdCliePed.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PedidosBindingSource, "IdCliente", True))
        Me.IdCliePed.Location = New System.Drawing.Point(102, 114)
        Me.IdCliePed.Name = "IdCliePed"
        Me.IdCliePed.Size = New System.Drawing.Size(100, 20)
        Me.IdCliePed.TabIndex = 5
        '
        'PedidosBindingSource1
        '
        Me.PedidosBindingSource1.DataMember = "Pedidos"
        Me.PedidosBindingSource1.DataSource = Me.Base_de_Datos_PedidosDataSet
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 143)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Fecha Pedido:"
        '
        'PedidosBindingSource2
        '
        Me.PedidosBindingSource2.DataMember = "Pedidos"
        Me.PedidosBindingSource2.DataSource = Me.Base_de_Datos_PedidosDataSet
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 169)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Fecha Envío:"
        '
        'PedidosBindingSource3
        '
        Me.PedidosBindingSource3.DataMember = "Pedidos"
        Me.PedidosBindingSource3.DataSource = Me.Base_de_Datos_PedidosDataSet
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 195)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Modos de Envío:"
        '
        'ModEnvio
        '
        Me.ModEnvio.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PedidosBindingSource, "ModosEnvios", True))
        Me.ModEnvio.Location = New System.Drawing.Point(102, 192)
        Me.ModEnvio.Name = "ModEnvio"
        Me.ModEnvio.Size = New System.Drawing.Size(100, 20)
        Me.ModEnvio.TabIndex = 11
        '
        'PedidosBindingSource4
        '
        Me.PedidosBindingSource4.DataMember = "Pedidos"
        Me.PedidosBindingSource4.DataSource = Me.Base_de_Datos_PedidosDataSet
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(27, 221)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Id Empleado:"
        '
        'IdEmplePed
        '
        Me.IdEmplePed.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PedidosBindingSource, "IdEmpleado", True))
        Me.IdEmplePed.Location = New System.Drawing.Point(102, 218)
        Me.IdEmplePed.Name = "IdEmplePed"
        Me.IdEmplePed.Size = New System.Drawing.Size(100, 20)
        Me.IdEmplePed.TabIndex = 13
        '
        'PedidosBindingSource5
        '
        Me.PedidosBindingSource5.DataMember = "Pedidos"
        Me.PedidosBindingSource5.DataSource = Me.Base_de_Datos_PedidosDataSet
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuPrincipalToolStripMenuItem, Me.ProductosToolStripMenuItem, Me.ClientesToolStripMenuItem, Me.ProveedoresToolStripMenuItem, Me.EmpleadosToolStripMenuItem, Me.EnviosToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(517, 24)
        Me.MenuStrip1.TabIndex = 14
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
        'EnviosToolStripMenuItem
        '
        Me.EnviosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestionDeEnviosToolStripMenuItem})
        Me.EnviosToolStripMenuItem.Name = "EnviosToolStripMenuItem"
        Me.EnviosToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.EnviosToolStripMenuItem.Text = "Envios"
        '
        'GestionDeEnviosToolStripMenuItem
        '
        Me.GestionDeEnviosToolStripMenuItem.Name = "GestionDeEnviosToolStripMenuItem"
        Me.GestionDeEnviosToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.GestionDeEnviosToolStripMenuItem.Text = "Gestion de Envios"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'PedidosTableAdapter
        '
        Me.PedidosTableAdapter.ClearBeforeFill = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 255)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Primero"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(93, 255)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 16
        Me.Button3.Text = "Anterior"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(174, 255)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 17
        Me.Button4.Text = "Siguiente"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(255, 255)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 18
        Me.Button5.Text = "Ultimo"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'FechaPed
        '
        Me.FechaPed.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PedidosBindingSource, "FechaPedido", True))
        Me.FechaPed.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaPed.Location = New System.Drawing.Point(102, 140)
        Me.FechaPed.Name = "FechaPed"
        Me.FechaPed.Size = New System.Drawing.Size(100, 20)
        Me.FechaPed.TabIndex = 19
        '
        'FechaEnvio
        '
        Me.FechaEnvio.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PedidosBindingSource, "FechaEnvio", True))
        Me.FechaEnvio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaEnvio.Location = New System.Drawing.Point(102, 166)
        Me.FechaEnvio.Name = "FechaEnvio"
        Me.FechaEnvio.Size = New System.Drawing.Size(100, 20)
        Me.FechaEnvio.TabIndex = 20
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(430, 81)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 21
        Me.Button6.Text = "Nuevo"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(430, 110)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 23)
        Me.Button7.TabIndex = 22
        Me.Button7.Text = "Agregar"
        Me.Button7.UseVisualStyleBackColor = True
        Me.Button7.Visible = False
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(430, 139)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(75, 23)
        Me.Button9.TabIndex = 32
        Me.Button9.Text = "Modificar"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(430, 168)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(75, 23)
        Me.Button8.TabIndex = 31
        Me.Button8.Text = "Actualizar"
        Me.Button8.UseVisualStyleBackColor = True
        Me.Button8.Visible = False
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(430, 197)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(75, 23)
        Me.Button10.TabIndex = 33
        Me.Button10.Text = "Borrar"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Pedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(517, 290)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.FechaEnvio)
        Me.Controls.Add(Me.FechaPed)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.IdEmplePed)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ModEnvio)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.IdCliePed)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.IdPed)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Pedidos"
        Me.Text = "Pedidos"
        CType(Me.PedidosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Base_de_Datos_PedidosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PedidosBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PedidosBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PedidosBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PedidosBindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PedidosBindingSource5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents IdPed As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents IdCliePed As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ModEnvio As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents IdEmplePed As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuPrincipalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VolverAMenuPrincipalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestionDeProductosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestionDeClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestionDeProveedoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmpleadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestionDeEmpleadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnviosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestionDeEnviosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Base_de_Datos_PedidosDataSet As pra2p2b1.Base_de_Datos_PedidosDataSet
    Friend WithEvents PedidosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PedidosTableAdapter As pra2p2b1.Base_de_Datos_PedidosDataSetTableAdapters.PedidosTableAdapter
    Friend WithEvents PedidosBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents PedidosBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents PedidosBindingSource3 As System.Windows.Forms.BindingSource
    Friend WithEvents PedidosBindingSource4 As System.Windows.Forms.BindingSource
    Friend WithEvents PedidosBindingSource5 As System.Windows.Forms.BindingSource
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents FechaPed As System.Windows.Forms.DateTimePicker
    Friend WithEvents FechaEnvio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
End Class
