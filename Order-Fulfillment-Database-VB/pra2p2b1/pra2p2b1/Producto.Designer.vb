<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Producto
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.IdProd = New System.Windows.Forms.TextBox()
        Me.ProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Base_de_Datos_PedidosDataSet = New pra2p2b1.Base_de_Datos_PedidosDataSet()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NomProd = New System.Windows.Forms.TextBox()
        Me.ProductosBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DescProd = New System.Windows.Forms.TextBox()
        Me.ProductosBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PreUnProd = New System.Windows.Forms.TextBox()
        Me.ProductosBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.IdProvProd = New System.Windows.Forms.TextBox()
        Me.ProductosBindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.RefProd = New System.Windows.Forms.TextBox()
        Me.ProductosBindingSource5 = New System.Windows.Forms.BindingSource(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuPrincipalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VolverAMenuPrincipalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionDeClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PedidosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionDePedidosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionDeProveerdoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionDeEmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnviosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionDeEnviosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosTableAdapter = New pra2p2b1.Base_de_Datos_PedidosDataSetTableAdapters.ProductosTableAdapter()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Base_de_Datos_PedidosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosBindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosBindingSource5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Book", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 34)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Producto"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.NavajoWhite
        Me.Button1.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(425, 230)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 49)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Menu Principal"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Id Producto:"
        '
        'IdProd
        '
        Me.IdProd.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "IdProducto", True))
        Me.IdProd.Location = New System.Drawing.Point(99, 92)
        Me.IdProd.Name = "IdProd"
        Me.IdProd.Size = New System.Drawing.Size(100, 20)
        Me.IdProd.TabIndex = 3
        '
        'ProductosBindingSource
        '
        Me.ProductosBindingSource.DataMember = "Productos"
        Me.ProductosBindingSource.DataSource = Me.Base_de_Datos_PedidosDataSet
        '
        'Base_de_Datos_PedidosDataSet
        '
        Me.Base_de_Datos_PedidosDataSet.DataSetName = "Base_de_Datos_PedidosDataSet"
        Me.Base_de_Datos_PedidosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(0, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nombre Producto:"
        '
        'NomProd
        '
        Me.NomProd.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource1, "NombreProducto", True))
        Me.NomProd.Location = New System.Drawing.Point(99, 118)
        Me.NomProd.Name = "NomProd"
        Me.NomProd.Size = New System.Drawing.Size(100, 20)
        Me.NomProd.TabIndex = 5
        '
        'ProductosBindingSource1
        '
        Me.ProductosBindingSource1.DataMember = "Productos"
        Me.ProductosBindingSource1.DataSource = Me.Base_de_Datos_PedidosDataSet
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 147)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Descripción:"
        '
        'DescProd
        '
        Me.DescProd.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource2, "Descripcion", True))
        Me.DescProd.Location = New System.Drawing.Point(99, 144)
        Me.DescProd.Name = "DescProd"
        Me.DescProd.Size = New System.Drawing.Size(100, 20)
        Me.DescProd.TabIndex = 7
        '
        'ProductosBindingSource2
        '
        Me.ProductosBindingSource2.DataMember = "Productos"
        Me.ProductosBindingSource2.DataSource = Me.Base_de_Datos_PedidosDataSet
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 173)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Precio Unidad:"
        '
        'PreUnProd
        '
        Me.PreUnProd.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource3, "PrecioUnidad", True))
        Me.PreUnProd.Location = New System.Drawing.Point(99, 170)
        Me.PreUnProd.Name = "PreUnProd"
        Me.PreUnProd.Size = New System.Drawing.Size(100, 20)
        Me.PreUnProd.TabIndex = 9
        '
        'ProductosBindingSource3
        '
        Me.ProductosBindingSource3.DataMember = "Productos"
        Me.ProductosBindingSource3.DataSource = Me.Base_de_Datos_PedidosDataSet
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 199)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Id Proveedor:"
        '
        'IdProvProd
        '
        Me.IdProvProd.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource4, "IdProveedor", True))
        Me.IdProvProd.Location = New System.Drawing.Point(99, 196)
        Me.IdProvProd.Name = "IdProvProd"
        Me.IdProvProd.Size = New System.Drawing.Size(100, 20)
        Me.IdProvProd.TabIndex = 11
        '
        'ProductosBindingSource4
        '
        Me.ProductosBindingSource4.DataMember = "Productos"
        Me.ProductosBindingSource4.DataSource = Me.Base_de_Datos_PedidosDataSet
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(31, 225)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Referencia:"
        '
        'RefProd
        '
        Me.RefProd.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource5, "Referencia", True))
        Me.RefProd.Location = New System.Drawing.Point(99, 222)
        Me.RefProd.Name = "RefProd"
        Me.RefProd.Size = New System.Drawing.Size(100, 20)
        Me.RefProd.TabIndex = 13
        '
        'ProductosBindingSource5
        '
        Me.ProductosBindingSource5.DataMember = "Productos"
        Me.ProductosBindingSource5.DataSource = Me.Base_de_Datos_PedidosDataSet
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuPrincipalToolStripMenuItem, Me.ClientesToolStripMenuItem, Me.PedidosToolStripMenuItem, Me.ProveedoresToolStripMenuItem, Me.EmpleadosToolStripMenuItem, Me.EnviosToolStripMenuItem, Me.SalirToolStripMenuItem})
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
        Me.ProveedoresToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestionDeProveerdoresToolStripMenuItem})
        Me.ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem"
        Me.ProveedoresToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
        Me.ProveedoresToolStripMenuItem.Text = "Proveedores"
        '
        'GestionDeProveerdoresToolStripMenuItem
        '
        Me.GestionDeProveerdoresToolStripMenuItem.Name = "GestionDeProveerdoresToolStripMenuItem"
        Me.GestionDeProveerdoresToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.GestionDeProveerdoresToolStripMenuItem.Text = "Gestion de Proveerdores"
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
        'ProductosTableAdapter
        '
        Me.ProductosTableAdapter.ClearBeforeFill = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 256)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Primero"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(93, 256)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 16
        Me.Button3.Text = "Anterior"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(174, 256)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 17
        Me.Button4.Text = "Siguiente"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(255, 256)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 18
        Me.Button5.Text = "Ultimo"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(430, 85)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 19
        Me.Button6.Text = "Nuevo"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(430, 114)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 23)
        Me.Button7.TabIndex = 20
        Me.Button7.Text = "Agregar"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(430, 172)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(75, 23)
        Me.Button9.TabIndex = 32
        Me.Button9.Text = "Modificar"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(430, 143)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(75, 23)
        Me.Button8.TabIndex = 31
        Me.Button8.Text = "Actualizar"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(430, 201)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(75, 23)
        Me.Button10.TabIndex = 34
        Me.Button10.Text = "Borrar"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Producto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(517, 291)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.RefProd)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.IdProvProd)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PreUnProd)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DescProd)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.NomProd)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.IdProd)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Producto"
        Me.Text = "Producto"
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Base_de_Datos_PedidosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosBindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosBindingSource5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents IdProd As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents NomProd As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DescProd As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PreUnProd As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents IdProvProd As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents RefProd As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuPrincipalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VolverAMenuPrincipalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestionDeClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PedidosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestionDePedidosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestionDeProveerdoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmpleadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestionDeEmpleadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnviosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestionDeEnviosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Base_de_Datos_PedidosDataSet As pra2p2b1.Base_de_Datos_PedidosDataSet
    Friend WithEvents ProductosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductosTableAdapter As pra2p2b1.Base_de_Datos_PedidosDataSetTableAdapters.ProductosTableAdapter
    Friend WithEvents ProductosBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ProductosBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents ProductosBindingSource3 As System.Windows.Forms.BindingSource
    Friend WithEvents ProductosBindingSource4 As System.Windows.Forms.BindingSource
    Friend WithEvents ProductosBindingSource5 As System.Windows.Forms.BindingSource
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
