<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Votos
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
        Dim CodvotosLabel As System.Windows.Forms.Label
        Dim CodpartidoLabel As System.Windows.Forms.Label
        Dim CodmunicipioLabel As System.Windows.Forms.Label
        Dim CoddepartamLabel As System.Windows.Forms.Label
        Dim CodcandidatoLabel As System.Windows.Forms.Label
        Dim VotosLabel As System.Windows.Forms.Label
        Me.TSEDataSet = New Votaciones.TSEDataSet()
        Me.VotosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VotosTableAdapter = New Votaciones.TSEDataSetTableAdapters.VotosTableAdapter()
        Me.TableAdapterManager = New Votaciones.TSEDataSetTableAdapters.TableAdapterManager()
        Me.VotosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.PartidosPoliticosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CandidatosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CargosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LugaresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DepartamentosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MunicipiosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OtrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PadronToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuPrincipalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CodvotosTextBox = New System.Windows.Forms.TextBox()
        Me.CodpartidoTextBox = New System.Windows.Forms.TextBox()
        Me.CodmunicipioTextBox = New System.Windows.Forms.TextBox()
        Me.CoddepartamTextBox = New System.Windows.Forms.TextBox()
        Me.CodcandidatoTextBox = New System.Windows.Forms.TextBox()
        Me.VotosTextBox = New System.Windows.Forms.TextBox()
        Me.Button11 = New System.Windows.Forms.Button()
        CodvotosLabel = New System.Windows.Forms.Label()
        CodpartidoLabel = New System.Windows.Forms.Label()
        CodmunicipioLabel = New System.Windows.Forms.Label()
        CoddepartamLabel = New System.Windows.Forms.Label()
        CodcandidatoLabel = New System.Windows.Forms.Label()
        VotosLabel = New System.Windows.Forms.Label()
        CType(Me.TSEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VotosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VotosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CodvotosLabel
        '
        CodvotosLabel.AutoSize = True
        CodvotosLabel.Location = New System.Drawing.Point(41, 69)
        CodvotosLabel.Name = "CodvotosLabel"
        CodvotosLabel.Size = New System.Drawing.Size(54, 13)
        CodvotosLabel.TabIndex = 23
        CodvotosLabel.Text = "codvotos:"
        '
        'CodpartidoLabel
        '
        CodpartidoLabel.AutoSize = True
        CodpartidoLabel.Location = New System.Drawing.Point(34, 95)
        CodpartidoLabel.Name = "CodpartidoLabel"
        CodpartidoLabel.Size = New System.Drawing.Size(61, 13)
        CodpartidoLabel.TabIndex = 24
        CodpartidoLabel.Text = "Codpartido:"
        '
        'CodmunicipioLabel
        '
        CodmunicipioLabel.AutoSize = True
        CodmunicipioLabel.Location = New System.Drawing.Point(22, 121)
        CodmunicipioLabel.Name = "CodmunicipioLabel"
        CodmunicipioLabel.Size = New System.Drawing.Size(73, 13)
        CodmunicipioLabel.TabIndex = 25
        CodmunicipioLabel.Text = "Codmunicipio:"
        '
        'CoddepartamLabel
        '
        CoddepartamLabel.AutoSize = True
        CoddepartamLabel.Location = New System.Drawing.Point(22, 147)
        CoddepartamLabel.Name = "CoddepartamLabel"
        CoddepartamLabel.Size = New System.Drawing.Size(73, 13)
        CoddepartamLabel.TabIndex = 26
        CoddepartamLabel.Text = "Coddepartam:"
        '
        'CodcandidatoLabel
        '
        CodcandidatoLabel.AutoSize = True
        CodcandidatoLabel.Location = New System.Drawing.Point(19, 173)
        CodcandidatoLabel.Name = "CodcandidatoLabel"
        CodcandidatoLabel.Size = New System.Drawing.Size(76, 13)
        CodcandidatoLabel.TabIndex = 27
        CodcandidatoLabel.Text = "Codcandidato:"
        '
        'VotosLabel
        '
        VotosLabel.AutoSize = True
        VotosLabel.Location = New System.Drawing.Point(58, 199)
        VotosLabel.Name = "VotosLabel"
        VotosLabel.Size = New System.Drawing.Size(37, 13)
        VotosLabel.TabIndex = 28
        VotosLabel.Text = "Votos:"
        '
        'TSEDataSet
        '
        Me.TSEDataSet.DataSetName = "TSEDataSet"
        Me.TSEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VotosBindingSource
        '
        Me.VotosBindingSource.DataMember = "Votos"
        Me.VotosBindingSource.DataSource = Me.TSEDataSet
        '
        'VotosTableAdapter
        '
        Me.VotosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CandidatosTableAdapter = Nothing
        Me.TableAdapterManager.CargosTableAdapter = Nothing
        Me.TableAdapterManager.DepartamentosTableAdapter = Nothing
        Me.TableAdapterManager.MunicipiosTableAdapter = Nothing
        Me.TableAdapterManager.PadronTableAdapter = Nothing
        Me.TableAdapterManager.PartidosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Votaciones.TSEDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuariosTableAdapter = Nothing
        Me.TableAdapterManager.VotosTableAdapter = Me.VotosTableAdapter
        '
        'VotosDataGridView
        '
        Me.VotosDataGridView.AutoGenerateColumns = False
        Me.VotosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VotosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.VotosDataGridView.DataSource = Me.VotosBindingSource
        Me.VotosDataGridView.Location = New System.Drawing.Point(381, 80)
        Me.VotosDataGridView.Name = "VotosDataGridView"
        Me.VotosDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.VotosDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Codpartido"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Codpartido"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Codmunicipio"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Codmunicipio"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Coddepartam"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Coddepartam"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Codcandidato"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Codcandidato"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Votos"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Votos"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(606, 355)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(75, 23)
        Me.Button10.TabIndex = 22
        Me.Button10.Text = "Regresar a Menu"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(336, 355)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(75, 23)
        Me.Button9.TabIndex = 21
        Me.Button9.Text = "Eliminar"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(255, 355)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(75, 23)
        Me.Button8.TabIndex = 20
        Me.Button8.Text = "Buscar"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(174, 355)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 23)
        Me.Button7.TabIndex = 19
        Me.Button7.Text = "Actualizar"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(93, 355)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 18
        Me.Button6.Text = "Guardar"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(12, 355)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 17
        Me.Button5.Text = "Nuevo"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(255, 326)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 16
        Me.Button4.Text = "Ultimo"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(174, 326)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "Siguiente"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(93, 326)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Anterior"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 326)
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
        Me.OtrosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PadronToolStripMenuItem, Me.UsuariosToolStripMenuItem, Me.MenuPrincipalToolStripMenuItem})
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
        'CodvotosTextBox
        '
        Me.CodvotosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VotosBindingSource, "codvotos", True))
        Me.CodvotosTextBox.Location = New System.Drawing.Point(101, 66)
        Me.CodvotosTextBox.Name = "CodvotosTextBox"
        Me.CodvotosTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CodvotosTextBox.TabIndex = 24
        '
        'CodpartidoTextBox
        '
        Me.CodpartidoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VotosBindingSource, "Codpartido", True))
        Me.CodpartidoTextBox.Location = New System.Drawing.Point(101, 92)
        Me.CodpartidoTextBox.Name = "CodpartidoTextBox"
        Me.CodpartidoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CodpartidoTextBox.TabIndex = 25
        '
        'CodmunicipioTextBox
        '
        Me.CodmunicipioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VotosBindingSource, "Codmunicipio", True))
        Me.CodmunicipioTextBox.Location = New System.Drawing.Point(101, 118)
        Me.CodmunicipioTextBox.Name = "CodmunicipioTextBox"
        Me.CodmunicipioTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CodmunicipioTextBox.TabIndex = 26
        '
        'CoddepartamTextBox
        '
        Me.CoddepartamTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VotosBindingSource, "Coddepartam", True))
        Me.CoddepartamTextBox.Location = New System.Drawing.Point(101, 144)
        Me.CoddepartamTextBox.Name = "CoddepartamTextBox"
        Me.CoddepartamTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CoddepartamTextBox.TabIndex = 27
        '
        'CodcandidatoTextBox
        '
        Me.CodcandidatoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VotosBindingSource, "Codcandidato", True))
        Me.CodcandidatoTextBox.Location = New System.Drawing.Point(101, 170)
        Me.CodcandidatoTextBox.Name = "CodcandidatoTextBox"
        Me.CodcandidatoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CodcandidatoTextBox.TabIndex = 28
        '
        'VotosTextBox
        '
        Me.VotosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VotosBindingSource, "Votos", True))
        Me.VotosTextBox.Location = New System.Drawing.Point(101, 196)
        Me.VotosTextBox.Name = "VotosTextBox"
        Me.VotosTextBox.Size = New System.Drawing.Size(100, 20)
        Me.VotosTextBox.TabIndex = 29
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(417, 342)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(75, 36)
        Me.Button11.TabIndex = 30
        Me.Button11.Text = "Salir de Buscar"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Votos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(701, 398)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(VotosLabel)
        Me.Controls.Add(Me.VotosTextBox)
        Me.Controls.Add(CodcandidatoLabel)
        Me.Controls.Add(Me.CodcandidatoTextBox)
        Me.Controls.Add(CoddepartamLabel)
        Me.Controls.Add(Me.CoddepartamTextBox)
        Me.Controls.Add(CodmunicipioLabel)
        Me.Controls.Add(Me.CodmunicipioTextBox)
        Me.Controls.Add(CodpartidoLabel)
        Me.Controls.Add(Me.CodpartidoTextBox)
        Me.Controls.Add(CodvotosLabel)
        Me.Controls.Add(Me.CodvotosTextBox)
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
        Me.Controls.Add(Me.VotosDataGridView)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Votos"
        Me.Text = "Votos"
        CType(Me.TSEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VotosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VotosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TSEDataSet As Votaciones.TSEDataSet
    Friend WithEvents VotosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VotosTableAdapter As Votaciones.TSEDataSetTableAdapters.VotosTableAdapter
    Friend WithEvents TableAdapterManager As Votaciones.TSEDataSetTableAdapters.TableAdapterManager
    Friend WithEvents VotosDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
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
    Friend WithEvents PartidosPoliticosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CandidatosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CargosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LugaresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DepartamentosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MunicipiosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OtrosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PadronToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuPrincipalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CodvotosTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CodpartidoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CodmunicipioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CoddepartamTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CodcandidatoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents VotosTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button11 As System.Windows.Forms.Button
End Class
