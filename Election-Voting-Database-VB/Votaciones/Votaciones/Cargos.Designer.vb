<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cargos
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
        Dim CodcargoLabel As System.Windows.Forms.Label
        Dim CargoLabel As System.Windows.Forms.Label
        Me.TSEDataSet = New Votaciones.TSEDataSet()
        Me.CargosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CargosTableAdapter = New Votaciones.TSEDataSetTableAdapters.CargosTableAdapter()
        Me.TableAdapterManager = New Votaciones.TSEDataSetTableAdapters.TableAdapterManager()
        Me.CargosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PartidosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PartidosPolititcosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CandidatosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LugaresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DepartamentosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MunicipiosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OtrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PadronToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VotosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuPrincipalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CodcargoTextBox = New System.Windows.Forms.TextBox()
        Me.CargoTextBox = New System.Windows.Forms.TextBox()
        Me.Button11 = New System.Windows.Forms.Button()
        CodcargoLabel = New System.Windows.Forms.Label()
        CargoLabel = New System.Windows.Forms.Label()
        CType(Me.TSEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CargosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CargosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CodcargoLabel
        '
        CodcargoLabel.AutoSize = True
        CodcargoLabel.Location = New System.Drawing.Point(47, 166)
        CodcargoLabel.Name = "CodcargoLabel"
        CodcargoLabel.Size = New System.Drawing.Size(55, 13)
        CodcargoLabel.TabIndex = 23
        CodcargoLabel.Text = "codcargo:"
        '
        'CargoLabel
        '
        CargoLabel.AutoSize = True
        CargoLabel.Location = New System.Drawing.Point(64, 192)
        CargoLabel.Name = "CargoLabel"
        CargoLabel.Size = New System.Drawing.Size(38, 13)
        CargoLabel.TabIndex = 24
        CargoLabel.Text = "Cargo:"
        '
        'TSEDataSet
        '
        Me.TSEDataSet.DataSetName = "TSEDataSet"
        Me.TSEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CargosBindingSource
        '
        Me.CargosBindingSource.DataMember = "Cargos"
        Me.CargosBindingSource.DataSource = Me.TSEDataSet
        '
        'CargosTableAdapter
        '
        Me.CargosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CandidatosTableAdapter = Nothing
        Me.TableAdapterManager.CargosTableAdapter = Me.CargosTableAdapter
        Me.TableAdapterManager.DepartamentosTableAdapter = Nothing
        Me.TableAdapterManager.MunicipiosTableAdapter = Nothing
        Me.TableAdapterManager.PadronTableAdapter = Nothing
        Me.TableAdapterManager.PartidosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Votaciones.TSEDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuariosTableAdapter = Nothing
        Me.TableAdapterManager.VotosTableAdapter = Nothing
        '
        'CargosDataGridView
        '
        Me.CargosDataGridView.AutoGenerateColumns = False
        Me.CargosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CargosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.CargosDataGridView.DataSource = Me.CargosBindingSource
        Me.CargosDataGridView.Location = New System.Drawing.Point(381, 70)
        Me.CargosDataGridView.Name = "CargosDataGridView"
        Me.CargosDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.CargosDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "codcargo"
        Me.DataGridViewTextBoxColumn1.HeaderText = "codcargo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Cargo"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Cargo"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(606, 358)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(75, 23)
        Me.Button10.TabIndex = 22
        Me.Button10.Text = "Regresar a Menu"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(336, 358)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(75, 23)
        Me.Button9.TabIndex = 21
        Me.Button9.Text = "Eliminar"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(255, 358)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(75, 23)
        Me.Button8.TabIndex = 20
        Me.Button8.Text = "Buscar"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(174, 358)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 23)
        Me.Button7.TabIndex = 19
        Me.Button7.Text = "Actualizar"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(93, 358)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 18
        Me.Button6.Text = "Guardar"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(12, 358)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 17
        Me.Button5.Text = "Nuevo"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(255, 329)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 16
        Me.Button4.Text = "Ultimo"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(174, 329)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "Siguiente"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(93, 329)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Anterior"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 329)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Primero"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PartidosToolStripMenuItem, Me.LugaresToolStripMenuItem, Me.OtrosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(701, 24)
        Me.MenuStrip1.TabIndex = 23
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PartidosToolStripMenuItem
        '
        Me.PartidosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PartidosPolititcosToolStripMenuItem, Me.CandidatosToolStripMenuItem})
        Me.PartidosToolStripMenuItem.Name = "PartidosToolStripMenuItem"
        Me.PartidosToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.PartidosToolStripMenuItem.Text = "Partidos"
        '
        'PartidosPolititcosToolStripMenuItem
        '
        Me.PartidosPolititcosToolStripMenuItem.Name = "PartidosPolititcosToolStripMenuItem"
        Me.PartidosPolititcosToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.PartidosPolititcosToolStripMenuItem.Text = "Partidos Polititcos"
        '
        'CandidatosToolStripMenuItem
        '
        Me.CandidatosToolStripMenuItem.Name = "CandidatosToolStripMenuItem"
        Me.CandidatosToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.CandidatosToolStripMenuItem.Text = "Candidatos"
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
        Me.OtrosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PadronToolStripMenuItem, Me.VotosToolStripMenuItem, Me.UsuariosToolStripMenuItem, Me.MenuPrincipalToolStripMenuItem})
        Me.OtrosToolStripMenuItem.Name = "OtrosToolStripMenuItem"
        Me.OtrosToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.OtrosToolStripMenuItem.Text = "Otros"
        '
        'PadronToolStripMenuItem
        '
        Me.PadronToolStripMenuItem.Name = "PadronToolStripMenuItem"
        Me.PadronToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.PadronToolStripMenuItem.Text = "Padron"
        '
        'VotosToolStripMenuItem
        '
        Me.VotosToolStripMenuItem.Name = "VotosToolStripMenuItem"
        Me.VotosToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.VotosToolStripMenuItem.Text = "Votos"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.UsuariosToolStripMenuItem.Text = "Usuarios"
        '
        'MenuPrincipalToolStripMenuItem
        '
        Me.MenuPrincipalToolStripMenuItem.Name = "MenuPrincipalToolStripMenuItem"
        Me.MenuPrincipalToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.MenuPrincipalToolStripMenuItem.Text = "Menu Principal"
        '
        'CodcargoTextBox
        '
        Me.CodcargoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CargosBindingSource, "codcargo", True))
        Me.CodcargoTextBox.Location = New System.Drawing.Point(108, 163)
        Me.CodcargoTextBox.Name = "CodcargoTextBox"
        Me.CodcargoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CodcargoTextBox.TabIndex = 24
        '
        'CargoTextBox
        '
        Me.CargoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CargosBindingSource, "Cargo", True))
        Me.CargoTextBox.Location = New System.Drawing.Point(108, 189)
        Me.CargoTextBox.Name = "CargoTextBox"
        Me.CargoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CargoTextBox.TabIndex = 25
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(417, 345)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(75, 36)
        Me.Button11.TabIndex = 27
        Me.Button11.Text = "Salir de Buscar"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Cargos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(701, 401)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(CargoLabel)
        Me.Controls.Add(Me.CargoTextBox)
        Me.Controls.Add(CodcargoLabel)
        Me.Controls.Add(Me.CodcargoTextBox)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CargosDataGridView)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Cargos"
        Me.Text = "Cargos"
        CType(Me.TSEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CargosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CargosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TSEDataSet As Votaciones.TSEDataSet
    Friend WithEvents CargosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CargosTableAdapter As Votaciones.TSEDataSetTableAdapters.CargosTableAdapter
    Friend WithEvents TableAdapterManager As Votaciones.TSEDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CargosDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents PartidosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PartidosPolititcosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CandidatosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LugaresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DepartamentosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MunicipiosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OtrosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PadronToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VotosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuPrincipalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CodcargoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CargoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button11 As System.Windows.Forms.Button
End Class
