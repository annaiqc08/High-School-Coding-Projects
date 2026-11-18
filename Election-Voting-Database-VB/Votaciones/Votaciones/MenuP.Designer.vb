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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PartidosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PartidosPoliticosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CandidatosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CargosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LugaresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DepartamentosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MunicipiosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OtrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PadronToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VotosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IngresarUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cambria", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(51, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(588, 60)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tribunal Supremo Electoral"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PartidosToolStripMenuItem, Me.LugaresToolStripMenuItem, Me.OtrosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(695, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PartidosToolStripMenuItem
        '
        Me.PartidosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PartidosPoliticosToolStripMenuItem, Me.CandidatosToolStripMenuItem, Me.CargosToolStripMenuItem})
        Me.PartidosToolStripMenuItem.Name = "PartidosToolStripMenuItem"
        Me.PartidosToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.PartidosToolStripMenuItem.Text = "Partidos"
        '
        'PartidosPoliticosToolStripMenuItem
        '
        Me.PartidosPoliticosToolStripMenuItem.Name = "PartidosPoliticosToolStripMenuItem"
        Me.PartidosPoliticosToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.PartidosPoliticosToolStripMenuItem.Text = "Partidos Politicos"
        '
        'CandidatosToolStripMenuItem
        '
        Me.CandidatosToolStripMenuItem.Name = "CandidatosToolStripMenuItem"
        Me.CandidatosToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.CandidatosToolStripMenuItem.Text = "Candidatos"
        '
        'CargosToolStripMenuItem
        '
        Me.CargosToolStripMenuItem.Name = "CargosToolStripMenuItem"
        Me.CargosToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.CargosToolStripMenuItem.Text = "Cargos"
        '
        'LugaresToolStripMenuItem
        '
        Me.LugaresToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DepartamentosToolStripMenuItem, Me.MunicipiosToolStripMenuItem})
        Me.LugaresToolStripMenuItem.Name = "LugaresToolStripMenuItem"
        Me.LugaresToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.LugaresToolStripMenuItem.Text = "Lugares"
        '
        'DepartamentosToolStripMenuItem
        '
        Me.DepartamentosToolStripMenuItem.Name = "DepartamentosToolStripMenuItem"
        Me.DepartamentosToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.DepartamentosToolStripMenuItem.Text = "Departamentos"
        '
        'MunicipiosToolStripMenuItem
        '
        Me.MunicipiosToolStripMenuItem.Name = "MunicipiosToolStripMenuItem"
        Me.MunicipiosToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.MunicipiosToolStripMenuItem.Text = "Municipios"
        '
        'OtrosToolStripMenuItem
        '
        Me.OtrosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PadronToolStripMenuItem, Me.VotosToolStripMenuItem, Me.UsuariosToolStripMenuItem, Me.IngresarUsuarioToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.OtrosToolStripMenuItem.Name = "OtrosToolStripMenuItem"
        Me.OtrosToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.OtrosToolStripMenuItem.Text = "Otros"
        '
        'PadronToolStripMenuItem
        '
        Me.PadronToolStripMenuItem.Name = "PadronToolStripMenuItem"
        Me.PadronToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.PadronToolStripMenuItem.Text = "Padron"
        '
        'VotosToolStripMenuItem
        '
        Me.VotosToolStripMenuItem.Name = "VotosToolStripMenuItem"
        Me.VotosToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.VotosToolStripMenuItem.Text = "Votos"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.UsuariosToolStripMenuItem.Text = "Usuarios"
        '
        'IngresarUsuarioToolStripMenuItem
        '
        Me.IngresarUsuarioToolStripMenuItem.Name = "IngresarUsuarioToolStripMenuItem"
        Me.IngresarUsuarioToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.IngresarUsuarioToolStripMenuItem.Text = "Ingresar Usuario"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'MenuP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(695, 281)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "MenuP"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents PartidosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LugaresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DepartamentosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MunicipiosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OtrosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PadronToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VotosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PartidosPoliticosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CandidatosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CargosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IngresarUsuarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
