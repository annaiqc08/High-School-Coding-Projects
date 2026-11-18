<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuP
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CitasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CitasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ControlDeCitasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MedicosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaDeMedicosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaDeEmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ControlDeVentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ControlDelInventarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ControlDeClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 72.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-6, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(515, 117)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "¡Bienvenidos!"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(134, 255)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(226, 33)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Es un gusto atenderle."
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CitasToolStripMenuItem, Me.CitasToolStripMenuItem1, Me.MedicosToolStripMenuItem, Me.EmpleadosToolStripMenuItem, Me.VentasToolStripMenuItem, Me.InventarioToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(509, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CitasToolStripMenuItem
        '
        Me.CitasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ControlDeClientesToolStripMenuItem})
        Me.CitasToolStripMenuItem.Name = "CitasToolStripMenuItem"
        Me.CitasToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.CitasToolStripMenuItem.Text = "Clientes"
        '
        'CitasToolStripMenuItem1
        '
        Me.CitasToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ControlDeCitasToolStripMenuItem1})
        Me.CitasToolStripMenuItem1.Name = "CitasToolStripMenuItem1"
        Me.CitasToolStripMenuItem1.Size = New System.Drawing.Size(45, 20)
        Me.CitasToolStripMenuItem1.Text = "Citas"
        '
        'ControlDeCitasToolStripMenuItem1
        '
        Me.ControlDeCitasToolStripMenuItem1.Name = "ControlDeCitasToolStripMenuItem1"
        Me.ControlDeCitasToolStripMenuItem1.Size = New System.Drawing.Size(157, 22)
        Me.ControlDeCitasToolStripMenuItem1.Text = "Control de citas"
        '
        'MedicosToolStripMenuItem
        '
        Me.MedicosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListaDeMedicosToolStripMenuItem})
        Me.MedicosToolStripMenuItem.Name = "MedicosToolStripMenuItem"
        Me.MedicosToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.MedicosToolStripMenuItem.Text = "Medicos"
        '
        'ListaDeMedicosToolStripMenuItem
        '
        Me.ListaDeMedicosToolStripMenuItem.Name = "ListaDeMedicosToolStripMenuItem"
        Me.ListaDeMedicosToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.ListaDeMedicosToolStripMenuItem.Text = "Lista de Medicos"
        '
        'EmpleadosToolStripMenuItem
        '
        Me.EmpleadosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListaDeEmpleadosToolStripMenuItem})
        Me.EmpleadosToolStripMenuItem.Name = "EmpleadosToolStripMenuItem"
        Me.EmpleadosToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.EmpleadosToolStripMenuItem.Text = "Empleados"
        '
        'ListaDeEmpleadosToolStripMenuItem
        '
        Me.ListaDeEmpleadosToolStripMenuItem.Name = "ListaDeEmpleadosToolStripMenuItem"
        Me.ListaDeEmpleadosToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.ListaDeEmpleadosToolStripMenuItem.Text = "Lista de Empleados"
        '
        'VentasToolStripMenuItem
        '
        Me.VentasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ControlDeVentasToolStripMenuItem})
        Me.VentasToolStripMenuItem.Name = "VentasToolStripMenuItem"
        Me.VentasToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.VentasToolStripMenuItem.Text = "Ventas"
        '
        'ControlDeVentasToolStripMenuItem
        '
        Me.ControlDeVentasToolStripMenuItem.Name = "ControlDeVentasToolStripMenuItem"
        Me.ControlDeVentasToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.ControlDeVentasToolStripMenuItem.Text = "Control de ventas"
        '
        'InventarioToolStripMenuItem
        '
        Me.InventarioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ControlDelInventarioToolStripMenuItem})
        Me.InventarioToolStripMenuItem.Name = "InventarioToolStripMenuItem"
        Me.InventarioToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.InventarioToolStripMenuItem.Text = "Inventario"
        '
        'ControlDelInventarioToolStripMenuItem
        '
        Me.ControlDelInventarioToolStripMenuItem.Name = "ControlDelInventarioToolStripMenuItem"
        Me.ControlDelInventarioToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.ControlDelInventarioToolStripMenuItem.Text = "Control del Inventario"
        '
        'ControlDeClientesToolStripMenuItem
        '
        Me.ControlDeClientesToolStripMenuItem.Name = "ControlDeClientesToolStripMenuItem"
        Me.ControlDeClientesToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.ControlDeClientesToolStripMenuItem.Text = "Control de Clientes"
        '
        'MenuP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(509, 363)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MenuP"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents CitasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CitasToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MedicosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmpleadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VentasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InventarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ControlDeCitasToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListaDeMedicosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListaDeEmpleadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ControlDeVentasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ControlDelInventarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ControlDeClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
