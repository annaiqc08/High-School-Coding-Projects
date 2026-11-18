<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Citas
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
        Dim CodclienteLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim CoddoctorLabel As System.Windows.Forms.Label
        Dim PoscitaLabel As System.Windows.Forms.Label
        Dim CodcitaLabel As System.Windows.Forms.Label
        Dim ApellidoLabel As System.Windows.Forms.Label
        Dim AsistenciaLabel As System.Windows.Forms.Label
        Dim CodempleadoLabel As System.Windows.Forms.Label
        Dim ObservacionesLabel As System.Windows.Forms.Label
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ClinicDataSet = New Clinic.clinicDataSet()
        Me.CitasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CitasTableAdapter = New Clinic.clinicDataSetTableAdapters.CitasTableAdapter()
        Me.TableAdapterManager = New Clinic.clinicDataSetTableAdapters.TableAdapterManager()
        Me.CitasDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodclienteTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.CoddoctorTextBox = New System.Windows.Forms.TextBox()
        Me.PoscitaCheckBox = New System.Windows.Forms.CheckBox()
        Me.CodcitaTextBox = New System.Windows.Forms.TextBox()
        Me.ApellidoTextBox = New System.Windows.Forms.TextBox()
        Me.AsistenciaCheckBox = New System.Windows.Forms.CheckBox()
        Me.CodempleadoTextBox = New System.Windows.Forms.TextBox()
        Me.ObservacionesTextBox = New System.Windows.Forms.TextBox()
        CodclienteLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        CoddoctorLabel = New System.Windows.Forms.Label()
        PoscitaLabel = New System.Windows.Forms.Label()
        CodcitaLabel = New System.Windows.Forms.Label()
        ApellidoLabel = New System.Windows.Forms.Label()
        AsistenciaLabel = New System.Windows.Forms.Label()
        CodempleadoLabel = New System.Windows.Forms.Label()
        ObservacionesLabel = New System.Windows.Forms.Label()
        CType(Me.ClinicDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CitasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CitasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button10
        '
        Me.Button10.Image = Global.Clinic.My.Resources.Resources.eliminar
        Me.Button10.Location = New System.Drawing.Point(460, 566)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(50, 48)
        Me.Button10.TabIndex = 35
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Image = Global.Clinic.My.Resources.Resources.insertar
        Me.Button9.Location = New System.Drawing.Point(404, 566)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(50, 48)
        Me.Button9.TabIndex = 34
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Image = Global.Clinic.My.Resources.Resources.actualizar
        Me.Button8.Location = New System.Drawing.Point(348, 566)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(50, 48)
        Me.Button8.TabIndex = 33
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Image = Global.Clinic.My.Resources.Resources.guardar
        Me.Button7.Location = New System.Drawing.Point(292, 566)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(50, 48)
        Me.Button7.TabIndex = 32
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Image = Global.Clinic.My.Resources.Resources.buscar
        Me.Button6.Location = New System.Drawing.Point(236, 566)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(50, 48)
        Me.Button6.TabIndex = 31
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Image = Global.Clinic.My.Resources.Resources.ultimo
        Me.Button5.Location = New System.Drawing.Point(180, 566)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(50, 48)
        Me.Button5.TabIndex = 30
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Image = Global.Clinic.My.Resources.Resources.siguiente
        Me.Button4.Location = New System.Drawing.Point(124, 566)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(50, 48)
        Me.Button4.TabIndex = 29
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Image = Global.Clinic.My.Resources.Resources.atras
        Me.Button3.Location = New System.Drawing.Point(68, 566)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(50, 48)
        Me.Button3.TabIndex = 28
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = Global.Clinic.My.Resources.Resources.primero
        Me.Button2.Location = New System.Drawing.Point(12, 566)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(50, 48)
        Me.Button2.TabIndex = 27
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(636, 566)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 25)
        Me.Button1.TabIndex = 36
        Me.Button1.Text = "Regresar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(310, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 39)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Citas"
        '
        'ClinicDataSet
        '
        Me.ClinicDataSet.DataSetName = "clinicDataSet"
        Me.ClinicDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CitasBindingSource
        '
        Me.CitasBindingSource.DataMember = "Citas"
        Me.CitasBindingSource.DataSource = Me.ClinicDataSet
        '
        'CitasTableAdapter
        '
        Me.CitasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CitasTableAdapter = Me.CitasTableAdapter
        Me.TableAdapterManager.empleadosTableAdapter = Nothing
        Me.TableAdapterManager.inventarioTableAdapter = Nothing
        Me.TableAdapterManager.medicosTableAdapter = Nothing
        Me.TableAdapterManager.pacientesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Clinic.clinicDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.ventasTableAdapter = Nothing
        '
        'CitasDataGridView
        '
        Me.CitasDataGridView.AutoGenerateColumns = False
        Me.CitasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CitasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn4, Me.DataGridViewCheckBoxColumn2, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.CitasDataGridView.DataSource = Me.CitasBindingSource
        Me.CitasDataGridView.Location = New System.Drawing.Point(12, 279)
        Me.CitasDataGridView.Name = "CitasDataGridView"
        Me.CitasDataGridView.Size = New System.Drawing.Size(745, 220)
        Me.CitasDataGridView.TabIndex = 38
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "codcliente"
        Me.DataGridViewTextBoxColumn1.HeaderText = "codcliente"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nombre"
        Me.DataGridViewTextBoxColumn2.HeaderText = "nombre"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "apellido"
        Me.DataGridViewTextBoxColumn3.HeaderText = "apellido"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "asistencia"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "asistencia"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "coddoctor"
        Me.DataGridViewTextBoxColumn4.HeaderText = "coddoctor"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.DataPropertyName = "poscita"
        Me.DataGridViewCheckBoxColumn2.HeaderText = "poscita"
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "codcita"
        Me.DataGridViewTextBoxColumn5.HeaderText = "codcita"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "codempleado"
        Me.DataGridViewTextBoxColumn6.HeaderText = "codempleado"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "observaciones"
        Me.DataGridViewTextBoxColumn7.HeaderText = "observaciones"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'CodclienteLabel
        '
        CodclienteLabel.AutoSize = True
        CodclienteLabel.Location = New System.Drawing.Point(9, 111)
        CodclienteLabel.Name = "CodclienteLabel"
        CodclienteLabel.Size = New System.Drawing.Size(59, 13)
        CodclienteLabel.TabIndex = 38
        CodclienteLabel.Text = "codcliente:"
        '
        'CodclienteTextBox
        '
        Me.CodclienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CitasBindingSource, "codcliente", True))
        Me.CodclienteTextBox.Location = New System.Drawing.Point(74, 108)
        Me.CodclienteTextBox.Name = "CodclienteTextBox"
        Me.CodclienteTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CodclienteTextBox.TabIndex = 39
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(23, 137)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(45, 13)
        NombreLabel.TabIndex = 39
        NombreLabel.Text = "nombre:"
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CitasBindingSource, "nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(74, 134)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(155, 20)
        Me.NombreTextBox.TabIndex = 40
        '
        'CoddoctorLabel
        '
        CoddoctorLabel.AutoSize = True
        CoddoctorLabel.Location = New System.Drawing.Point(234, 80)
        CoddoctorLabel.Name = "CoddoctorLabel"
        CoddoctorLabel.Size = New System.Drawing.Size(58, 13)
        CoddoctorLabel.TabIndex = 40
        CoddoctorLabel.Text = "coddoctor:"
        '
        'CoddoctorTextBox
        '
        Me.CoddoctorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CitasBindingSource, "coddoctor", True))
        Me.CoddoctorTextBox.Location = New System.Drawing.Point(298, 77)
        Me.CoddoctorTextBox.Name = "CoddoctorTextBox"
        Me.CoddoctorTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CoddoctorTextBox.TabIndex = 41
        '
        'PoscitaLabel
        '
        PoscitaLabel.AutoSize = True
        PoscitaLabel.Location = New System.Drawing.Point(248, 111)
        PoscitaLabel.Name = "PoscitaLabel"
        PoscitaLabel.Size = New System.Drawing.Size(44, 13)
        PoscitaLabel.TabIndex = 41
        PoscitaLabel.Text = "poscita:"
        '
        'PoscitaCheckBox
        '
        Me.PoscitaCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.CitasBindingSource, "poscita", True))
        Me.PoscitaCheckBox.Location = New System.Drawing.Point(298, 106)
        Me.PoscitaCheckBox.Name = "PoscitaCheckBox"
        Me.PoscitaCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.PoscitaCheckBox.TabIndex = 42
        Me.PoscitaCheckBox.Text = "CheckBox1"
        Me.PoscitaCheckBox.UseVisualStyleBackColor = True
        '
        'CodcitaLabel
        '
        CodcitaLabel.AutoSize = True
        CodcitaLabel.Location = New System.Drawing.Point(23, 80)
        CodcitaLabel.Name = "CodcitaLabel"
        CodcitaLabel.Size = New System.Drawing.Size(45, 13)
        CodcitaLabel.TabIndex = 42
        CodcitaLabel.Text = "codcita:"
        '
        'CodcitaTextBox
        '
        Me.CodcitaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CitasBindingSource, "codcita", True))
        Me.CodcitaTextBox.Location = New System.Drawing.Point(74, 77)
        Me.CodcitaTextBox.Name = "CodcitaTextBox"
        Me.CodcitaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CodcitaTextBox.TabIndex = 43
        '
        'ApellidoLabel
        '
        ApellidoLabel.AutoSize = True
        ApellidoLabel.Location = New System.Drawing.Point(22, 163)
        ApellidoLabel.Name = "ApellidoLabel"
        ApellidoLabel.Size = New System.Drawing.Size(46, 13)
        ApellidoLabel.TabIndex = 43
        ApellidoLabel.Text = "apellido:"
        '
        'ApellidoTextBox
        '
        Me.ApellidoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CitasBindingSource, "apellido", True))
        Me.ApellidoTextBox.Location = New System.Drawing.Point(74, 160)
        Me.ApellidoTextBox.Name = "ApellidoTextBox"
        Me.ApellidoTextBox.Size = New System.Drawing.Size(138, 20)
        Me.ApellidoTextBox.TabIndex = 44
        '
        'AsistenciaLabel
        '
        AsistenciaLabel.AutoSize = True
        AsistenciaLabel.Location = New System.Drawing.Point(235, 142)
        AsistenciaLabel.Name = "AsistenciaLabel"
        AsistenciaLabel.Size = New System.Drawing.Size(57, 13)
        AsistenciaLabel.TabIndex = 44
        AsistenciaLabel.Text = "asistencia:"
        '
        'AsistenciaCheckBox
        '
        Me.AsistenciaCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.CitasBindingSource, "asistencia", True))
        Me.AsistenciaCheckBox.Location = New System.Drawing.Point(298, 137)
        Me.AsistenciaCheckBox.Name = "AsistenciaCheckBox"
        Me.AsistenciaCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.AsistenciaCheckBox.TabIndex = 45
        Me.AsistenciaCheckBox.Text = "CheckBox1"
        Me.AsistenciaCheckBox.UseVisualStyleBackColor = True
        '
        'CodempleadoLabel
        '
        CodempleadoLabel.AutoSize = True
        CodempleadoLabel.Location = New System.Drawing.Point(218, 170)
        CodempleadoLabel.Name = "CodempleadoLabel"
        CodempleadoLabel.Size = New System.Drawing.Size(74, 13)
        CodempleadoLabel.TabIndex = 45
        CodempleadoLabel.Text = "codempleado:"
        '
        'CodempleadoTextBox
        '
        Me.CodempleadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CitasBindingSource, "codempleado", True))
        Me.CodempleadoTextBox.Location = New System.Drawing.Point(298, 167)
        Me.CodempleadoTextBox.Name = "CodempleadoTextBox"
        Me.CodempleadoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CodempleadoTextBox.TabIndex = 46
        '
        'ObservacionesLabel
        '
        ObservacionesLabel.AutoSize = True
        ObservacionesLabel.Location = New System.Drawing.Point(422, 64)
        ObservacionesLabel.Name = "ObservacionesLabel"
        ObservacionesLabel.Size = New System.Drawing.Size(79, 13)
        ObservacionesLabel.TabIndex = 46
        ObservacionesLabel.Text = "observaciones:"
        '
        'ObservacionesTextBox
        '
        Me.ObservacionesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CitasBindingSource, "observaciones", True))
        Me.ObservacionesTextBox.Location = New System.Drawing.Point(425, 80)
        Me.ObservacionesTextBox.Multiline = True
        Me.ObservacionesTextBox.Name = "ObservacionesTextBox"
        Me.ObservacionesTextBox.Size = New System.Drawing.Size(284, 143)
        Me.ObservacionesTextBox.TabIndex = 47
        '
        'Citas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(955, 634)
        Me.Controls.Add(ObservacionesLabel)
        Me.Controls.Add(Me.ObservacionesTextBox)
        Me.Controls.Add(CodempleadoLabel)
        Me.Controls.Add(Me.CodempleadoTextBox)
        Me.Controls.Add(AsistenciaLabel)
        Me.Controls.Add(Me.AsistenciaCheckBox)
        Me.Controls.Add(ApellidoLabel)
        Me.Controls.Add(Me.ApellidoTextBox)
        Me.Controls.Add(CodcitaLabel)
        Me.Controls.Add(Me.CodcitaTextBox)
        Me.Controls.Add(PoscitaLabel)
        Me.Controls.Add(Me.PoscitaCheckBox)
        Me.Controls.Add(CoddoctorLabel)
        Me.Controls.Add(Me.CoddoctorTextBox)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(CodclienteLabel)
        Me.Controls.Add(Me.CodclienteTextBox)
        Me.Controls.Add(Me.CitasDataGridView)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Name = "Citas"
        Me.Text = "Citas"
        CType(Me.ClinicDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CitasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CitasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ClinicDataSet As Clinic.clinicDataSet
    Friend WithEvents CitasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CitasTableAdapter As Clinic.clinicDataSetTableAdapters.CitasTableAdapter
    Friend WithEvents TableAdapterManager As Clinic.clinicDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CitasDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodclienteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NombreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CoddoctorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PoscitaCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents CodcitaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ApellidoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AsistenciaCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents CodempleadoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ObservacionesTextBox As System.Windows.Forms.TextBox
End Class
