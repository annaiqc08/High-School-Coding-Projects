<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Proveedores
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
        Me.IdProv = New System.Windows.Forms.TextBox()
        Me.ProveedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Base_de_Datos_PedidosDataSet = New pra2p2b1.Base_de_Datos_PedidosDataSet()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NomProv = New System.Windows.Forms.TextBox()
        Me.ProveedoresBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ConProv = New System.Windows.Forms.TextBox()
        Me.ProveedoresBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DirProv = New System.Windows.Forms.TextBox()
        Me.ProveedoresBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PobProv = New System.Windows.Forms.TextBox()
        Me.ProveedoresBindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CodpostProv = New System.Windows.Forms.TextBox()
        Me.ProveedoresBindingSource5 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TelProv = New System.Windows.Forms.TextBox()
        Me.ProveedoresBindingSource6 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label9 = New System.Windows.Forms.Label()
        Me.FaxProv = New System.Windows.Forms.TextBox()
        Me.ProveedoresBindingSource7 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CorreoProv = New System.Windows.Forms.TextBox()
        Me.ProveedoresBindingSource8 = New System.Windows.Forms.BindingSource(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuPrincipalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VolverAMenuPrincipalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionDeProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionDeClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PedidosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionDePedidosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionDeEmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnviosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionDeEnviosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedoresTableAdapter = New pra2p2b1.Base_de_Datos_PedidosDataSetTableAdapters.ProveedoresTableAdapter()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Base_de_Datos_PedidosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedoresBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedoresBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedoresBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedoresBindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedoresBindingSource5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedoresBindingSource6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedoresBindingSource7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedoresBindingSource8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.NavajoWhite
        Me.Button1.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(451, 292)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(81, 48)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Menu Principal"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Book", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 34)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Proveedores"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Id Proveedores:"
        '
        'IdProv
        '
        Me.IdProv.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "IdProveedor", True))
        Me.IdProv.Location = New System.Drawing.Point(99, 80)
        Me.IdProv.Name = "IdProv"
        Me.IdProv.Size = New System.Drawing.Size(100, 20)
        Me.IdProv.TabIndex = 3
        '
        'ProveedoresBindingSource
        '
        Me.ProveedoresBindingSource.DataMember = "Proveedores"
        Me.ProveedoresBindingSource.DataSource = Me.Base_de_Datos_PedidosDataSet
        '
        'Base_de_Datos_PedidosDataSet
        '
        Me.Base_de_Datos_PedidosDataSet.DataSetName = "Base_de_Datos_PedidosDataSet"
        Me.Base_de_Datos_PedidosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(46, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nombre:"
        '
        'NomProv
        '
        Me.NomProv.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource1, "NombreProveedor", True))
        Me.NomProv.Location = New System.Drawing.Point(99, 106)
        Me.NomProv.Name = "NomProv"
        Me.NomProv.Size = New System.Drawing.Size(100, 20)
        Me.NomProv.TabIndex = 5
        '
        'ProveedoresBindingSource1
        '
        Me.ProveedoresBindingSource1.DataMember = "Proveedores"
        Me.ProveedoresBindingSource1.DataSource = Me.Base_de_Datos_PedidosDataSet
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(40, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Contacto:"
        '
        'ConProv
        '
        Me.ConProv.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource2, "Contacto", True))
        Me.ConProv.Location = New System.Drawing.Point(99, 132)
        Me.ConProv.Name = "ConProv"
        Me.ConProv.Size = New System.Drawing.Size(100, 20)
        Me.ConProv.TabIndex = 7
        '
        'ProveedoresBindingSource2
        '
        Me.ProveedoresBindingSource2.DataMember = "Proveedores"
        Me.ProveedoresBindingSource2.DataSource = Me.Base_de_Datos_PedidosDataSet
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(38, 161)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Dirección:"
        '
        'DirProv
        '
        Me.DirProv.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource3, "Direccion", True))
        Me.DirProv.Location = New System.Drawing.Point(99, 158)
        Me.DirProv.Name = "DirProv"
        Me.DirProv.Size = New System.Drawing.Size(100, 20)
        Me.DirProv.TabIndex = 9
        '
        'ProveedoresBindingSource3
        '
        Me.ProveedoresBindingSource3.DataMember = "Proveedores"
        Me.ProveedoresBindingSource3.DataSource = Me.Base_de_Datos_PedidosDataSet
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(36, 187)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Población:"
        '
        'PobProv
        '
        Me.PobProv.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource4, "Poblacion", True))
        Me.PobProv.Location = New System.Drawing.Point(99, 184)
        Me.PobProv.Name = "PobProv"
        Me.PobProv.Size = New System.Drawing.Size(100, 20)
        Me.PobProv.TabIndex = 11
        '
        'ProveedoresBindingSource4
        '
        Me.ProveedoresBindingSource4.DataMember = "Proveedores"
        Me.ProveedoresBindingSource4.DataSource = Me.Base_de_Datos_PedidosDataSet
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 213)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Código Postal:"
        '
        'CodpostProv
        '
        Me.CodpostProv.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource5, "CodigoPostal", True))
        Me.CodpostProv.Location = New System.Drawing.Point(99, 210)
        Me.CodpostProv.Name = "CodpostProv"
        Me.CodpostProv.Size = New System.Drawing.Size(100, 20)
        Me.CodpostProv.TabIndex = 13
        '
        'ProveedoresBindingSource5
        '
        Me.ProveedoresBindingSource5.DataMember = "Proveedores"
        Me.ProveedoresBindingSource5.DataSource = Me.Base_de_Datos_PedidosDataSet
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(41, 239)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Teléfono:"
        '
        'TelProv
        '
        Me.TelProv.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource6, "Telefono", True))
        Me.TelProv.Location = New System.Drawing.Point(99, 236)
        Me.TelProv.Name = "TelProv"
        Me.TelProv.Size = New System.Drawing.Size(100, 20)
        Me.TelProv.TabIndex = 15
        '
        'ProveedoresBindingSource6
        '
        Me.ProveedoresBindingSource6.DataMember = "Proveedores"
        Me.ProveedoresBindingSource6.DataSource = Me.Base_de_Datos_PedidosDataSet
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(66, 265)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(27, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Fax:"
        '
        'FaxProv
        '
        Me.FaxProv.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource7, "Fax", True))
        Me.FaxProv.Location = New System.Drawing.Point(99, 262)
        Me.FaxProv.Name = "FaxProv"
        Me.FaxProv.Size = New System.Drawing.Size(100, 20)
        Me.FaxProv.TabIndex = 17
        '
        'ProveedoresBindingSource7
        '
        Me.ProveedoresBindingSource7.DataMember = "Proveedores"
        Me.ProveedoresBindingSource7.DataSource = Me.Base_de_Datos_PedidosDataSet
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(52, 291)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Correo:"
        '
        'CorreoProv
        '
        Me.CorreoProv.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource8, "CorreoElectronico", True))
        Me.CorreoProv.Location = New System.Drawing.Point(99, 288)
        Me.CorreoProv.Name = "CorreoProv"
        Me.CorreoProv.Size = New System.Drawing.Size(100, 20)
        Me.CorreoProv.TabIndex = 19
        '
        'ProveedoresBindingSource8
        '
        Me.ProveedoresBindingSource8.DataMember = "Proveedores"
        Me.ProveedoresBindingSource8.DataSource = Me.Base_de_Datos_PedidosDataSet
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuPrincipalToolStripMenuItem, Me.ProductosToolStripMenuItem, Me.ClientesToolStripMenuItem, Me.PedidosToolStripMenuItem, Me.EmpleadosToolStripMenuItem, Me.EnviosToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(544, 24)
        Me.MenuStrip1.TabIndex = 20
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
        'ProveedoresTableAdapter
        '
        Me.ProveedoresTableAdapter.ClearBeforeFill = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 317)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "Primero"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(93, 317)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 22
        Me.Button3.Text = "Anterior"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(174, 317)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 23
        Me.Button4.Text = "Siguiente"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(255, 317)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 24
        Me.Button5.Text = "Ultimo"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(457, 151)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 25
        Me.Button6.Text = "Nuevo"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(457, 180)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 23)
        Me.Button7.TabIndex = 26
        Me.Button7.Text = "Agregar"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(457, 209)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(75, 23)
        Me.Button9.TabIndex = 32
        Me.Button9.Text = "Modificar"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(457, 238)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(75, 23)
        Me.Button8.TabIndex = 31
        Me.Button8.Text = "Actualizar"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(457, 267)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(75, 23)
        Me.Button10.TabIndex = 34
        Me.Button10.Text = "Borrar"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Proveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(544, 352)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.CorreoProv)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.FaxProv)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TelProv)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.CodpostProv)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PobProv)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DirProv)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ConProv)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.NomProv)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.IdProv)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Proveedores"
        Me.Text = "Proveedores"
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Base_de_Datos_PedidosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedoresBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedoresBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedoresBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedoresBindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedoresBindingSource5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedoresBindingSource6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedoresBindingSource7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedoresBindingSource8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents IdProv As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents NomProv As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ConProv As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DirProv As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PobProv As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CodpostProv As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TelProv As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents FaxProv As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents CorreoProv As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuPrincipalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VolverAMenuPrincipalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestionDeProductosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestionDeClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PedidosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestionDePedidosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmpleadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestionDeEmpleadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnviosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestionDeEnviosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Base_de_Datos_PedidosDataSet As pra2p2b1.Base_de_Datos_PedidosDataSet
    Friend WithEvents ProveedoresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProveedoresTableAdapter As pra2p2b1.Base_de_Datos_PedidosDataSetTableAdapters.ProveedoresTableAdapter
    Friend WithEvents ProveedoresBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ProveedoresBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents ProveedoresBindingSource3 As System.Windows.Forms.BindingSource
    Friend WithEvents ProveedoresBindingSource4 As System.Windows.Forms.BindingSource
    Friend WithEvents ProveedoresBindingSource5 As System.Windows.Forms.BindingSource
    Friend WithEvents ProveedoresBindingSource6 As System.Windows.Forms.BindingSource
    Friend WithEvents ProveedoresBindingSource7 As System.Windows.Forms.BindingSource
    Friend WithEvents ProveedoresBindingSource8 As System.Windows.Forms.BindingSource
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
End Class
