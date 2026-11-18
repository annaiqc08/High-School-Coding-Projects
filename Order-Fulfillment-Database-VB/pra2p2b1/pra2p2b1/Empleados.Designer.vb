<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Empleados
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
        Me.IdEmple = New System.Windows.Forms.TextBox()
        Me.EmpleadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Base_de_Datos_PedidosDataSet = New pra2p2b1.Base_de_Datos_PedidosDataSet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NomEmple = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ApellEmple = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CiudEmple = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TelEmple = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CorreoEmple = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DPIEmple = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
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
        Me.EnviosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionDeEnviosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadosTableAdapter = New pra2p2b1.Base_de_Datos_PedidosDataSetTableAdapters.EmpleadosTableAdapter()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Base_de_Datos_PedidosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "IdEmpleado:"
        '
        'IdEmple
        '
        Me.IdEmple.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "IdEmpleado", True))
        Me.IdEmple.Location = New System.Drawing.Point(89, 96)
        Me.IdEmple.Name = "IdEmple"
        Me.IdEmple.Size = New System.Drawing.Size(100, 20)
        Me.IdEmple.TabIndex = 2
        '
        'EmpleadosBindingSource
        '
        Me.EmpleadosBindingSource.DataMember = "Empleados"
        Me.EmpleadosBindingSource.DataSource = Me.Base_de_Datos_PedidosDataSet
        '
        'Base_de_Datos_PedidosDataSet
        '
        Me.Base_de_Datos_PedidosDataSet.DataSetName = "Base_de_Datos_PedidosDataSet"
        Me.Base_de_Datos_PedidosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nombre:"
        '
        'NomEmple
        '
        Me.NomEmple.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "Nombre", True))
        Me.NomEmple.Location = New System.Drawing.Point(89, 122)
        Me.NomEmple.Name = "NomEmple"
        Me.NomEmple.Size = New System.Drawing.Size(100, 20)
        Me.NomEmple.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Apellido:"
        '
        'ApellEmple
        '
        Me.ApellEmple.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "Apellido", True))
        Me.ApellEmple.Location = New System.Drawing.Point(89, 148)
        Me.ApellEmple.Name = "ApellEmple"
        Me.ApellEmple.Size = New System.Drawing.Size(100, 20)
        Me.ApellEmple.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(40, 177)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Ciudad:"
        '
        'CiudEmple
        '
        Me.CiudEmple.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "Ciudad", True))
        Me.CiudEmple.Location = New System.Drawing.Point(89, 174)
        Me.CiudEmple.Name = "CiudEmple"
        Me.CiudEmple.Size = New System.Drawing.Size(100, 20)
        Me.CiudEmple.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(31, 203)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Telefono:"
        '
        'TelEmple
        '
        Me.TelEmple.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "Telefono", True))
        Me.TelEmple.Location = New System.Drawing.Point(89, 200)
        Me.TelEmple.Name = "TelEmple"
        Me.TelEmple.Size = New System.Drawing.Size(100, 20)
        Me.TelEmple.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(42, 229)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Correo:"
        '
        'CorreoEmple
        '
        Me.CorreoEmple.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "Correo", True))
        Me.CorreoEmple.Location = New System.Drawing.Point(89, 226)
        Me.CorreoEmple.Name = "CorreoEmple"
        Me.CorreoEmple.Size = New System.Drawing.Size(101, 20)
        Me.CorreoEmple.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(55, 255)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(28, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "DPI:"
        '
        'DPIEmple
        '
        Me.DPIEmple.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "DPI", True))
        Me.DPIEmple.Location = New System.Drawing.Point(89, 252)
        Me.DPIEmple.Name = "DPIEmple"
        Me.DPIEmple.Size = New System.Drawing.Size(100, 20)
        Me.DPIEmple.TabIndex = 14
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.NavajoWhite
        Me.Button1.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(409, 265)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(81, 51)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Menu Principal"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Franklin Gothic Book", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 34)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(142, 34)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Empleados"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuPrincipalToolStripMenuItem, Me.ProductosToolStripMenuItem, Me.ClientesToolStripMenuItem, Me.PedidosToolStripMenuItem, Me.ProveedoresToolStripMenuItem, Me.EnviosToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(502, 24)
        Me.MenuStrip1.TabIndex = 17
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
        'EmpleadosTableAdapter
        '
        Me.EmpleadosTableAdapter.ClearBeforeFill = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 293)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "Primero"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(93, 293)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 19
        Me.Button3.Text = "Anterior"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(174, 293)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 20
        Me.Button4.Text = "Siguiente"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(255, 293)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 21
        Me.Button5.Text = "Ultimo"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(415, 115)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 22
        Me.Button6.Text = "Nuevo"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(415, 144)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 23)
        Me.Button7.TabIndex = 23
        Me.Button7.Text = "Agregar"
        Me.Button7.UseVisualStyleBackColor = True
        Me.Button7.Visible = False
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(415, 173)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(75, 23)
        Me.Button9.TabIndex = 32
        Me.Button9.Text = "Modificar"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(415, 202)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(75, 23)
        Me.Button8.TabIndex = 31
        Me.Button8.Text = "Actualizar"
        Me.Button8.UseVisualStyleBackColor = True
        Me.Button8.Visible = False
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(415, 229)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(75, 23)
        Me.Button10.TabIndex = 33
        Me.Button10.Text = "Borrar"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Empleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(502, 328)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DPIEmple)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.CorreoEmple)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TelEmple)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CiudEmple)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ApellEmple)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.NomEmple)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.IdEmple)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Empleados"
        Me.Text = "Empleados"
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Base_de_Datos_PedidosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents IdEmple As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents NomEmple As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ApellEmple As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CiudEmple As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TelEmple As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CorreoEmple As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DPIEmple As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuPrincipalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VolverAMenuPrincipalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PedidosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestionDeProductosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestionDeClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestionDePedidosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestionDeProveedoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnviosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestionDeEnviosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Base_de_Datos_PedidosDataSet As pra2p2b1.Base_de_Datos_PedidosDataSet
    Friend WithEvents EmpleadosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmpleadosTableAdapter As pra2p2b1.Base_de_Datos_PedidosDataSetTableAdapters.EmpleadosTableAdapter
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
