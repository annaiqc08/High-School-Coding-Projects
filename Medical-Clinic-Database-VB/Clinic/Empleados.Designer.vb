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
        Dim CodempleadoLabel As System.Windows.Forms.Label
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
        Me.EmpleadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpleadosTableAdapter = New Clinic.clinicDataSetTableAdapters.empleadosTableAdapter()
        Me.TableAdapterManager = New Clinic.clinicDataSetTableAdapters.TableAdapterManager()
        Me.EmpleadosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodempleadoTextBox = New System.Windows.Forms.TextBox()
        Me.CitasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CitasTableAdapter = New Clinic.clinicDataSetTableAdapters.CitasTableAdapter()
        Me.CitasDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VentasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VentasTableAdapter = New Clinic.clinicDataSetTableAdapters.ventasTableAdapter()
        Me.VentasDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CodempleadoLabel = New System.Windows.Forms.Label()
        CType(Me.ClinicDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CitasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CitasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button10
        '
        Me.Button10.Image = Global.Clinic.My.Resources.Resources.eliminar
        Me.Button10.Location = New System.Drawing.Point(460, 569)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(50, 48)
        Me.Button10.TabIndex = 35
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Image = Global.Clinic.My.Resources.Resources.insertar
        Me.Button9.Location = New System.Drawing.Point(404, 569)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(50, 48)
        Me.Button9.TabIndex = 34
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Image = Global.Clinic.My.Resources.Resources.actualizar
        Me.Button8.Location = New System.Drawing.Point(348, 569)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(50, 48)
        Me.Button8.TabIndex = 33
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Image = Global.Clinic.My.Resources.Resources.guardar
        Me.Button7.Location = New System.Drawing.Point(292, 569)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(50, 48)
        Me.Button7.TabIndex = 32
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Image = Global.Clinic.My.Resources.Resources.buscar
        Me.Button6.Location = New System.Drawing.Point(236, 569)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(50, 48)
        Me.Button6.TabIndex = 31
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Image = Global.Clinic.My.Resources.Resources.ultimo
        Me.Button5.Location = New System.Drawing.Point(180, 569)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(50, 48)
        Me.Button5.TabIndex = 30
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Image = Global.Clinic.My.Resources.Resources.siguiente
        Me.Button4.Location = New System.Drawing.Point(124, 569)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(50, 48)
        Me.Button4.TabIndex = 29
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Image = Global.Clinic.My.Resources.Resources.atras
        Me.Button3.Location = New System.Drawing.Point(68, 569)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(50, 48)
        Me.Button3.TabIndex = 28
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = Global.Clinic.My.Resources.Resources.primero
        Me.Button2.Location = New System.Drawing.Point(12, 569)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(50, 48)
        Me.Button2.TabIndex = 27
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(582, 569)
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
        Me.Label2.Location = New System.Drawing.Point(285, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(191, 39)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Empleados"
        '
        'ClinicDataSet
        '
        Me.ClinicDataSet.DataSetName = "clinicDataSet"
        Me.ClinicDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmpleadosBindingSource
        '
        Me.EmpleadosBindingSource.DataMember = "empleados"
        Me.EmpleadosBindingSource.DataSource = Me.ClinicDataSet
        '
        'EmpleadosTableAdapter
        '
        Me.EmpleadosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CitasTableAdapter = Me.CitasTableAdapter
        Me.TableAdapterManager.empleadosTableAdapter = Me.EmpleadosTableAdapter
        Me.TableAdapterManager.inventarioTableAdapter = Nothing
        Me.TableAdapterManager.medicosTableAdapter = Nothing
        Me.TableAdapterManager.pacientesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Clinic.clinicDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.ventasTableAdapter = Me.VentasTableAdapter
        '
        'EmpleadosDataGridView
        '
        Me.EmpleadosDataGridView.AutoGenerateColumns = False
        Me.EmpleadosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EmpleadosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.EmpleadosDataGridView.DataSource = Me.EmpleadosBindingSource
        Me.EmpleadosDataGridView.Location = New System.Drawing.Point(12, 92)
        Me.EmpleadosDataGridView.Name = "EmpleadosDataGridView"
        Me.EmpleadosDataGridView.Size = New System.Drawing.Size(442, 220)
        Me.EmpleadosDataGridView.TabIndex = 38
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "codempleado"
        Me.DataGridViewTextBoxColumn1.HeaderText = "codempleado"
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
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "turno"
        Me.DataGridViewTextBoxColumn4.HeaderText = "turno"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'CodempleadoLabel
        '
        CodempleadoLabel.AutoSize = True
        CodempleadoLabel.Location = New System.Drawing.Point(71, 69)
        CodempleadoLabel.Name = "CodempleadoLabel"
        CodempleadoLabel.Size = New System.Drawing.Size(74, 13)
        CodempleadoLabel.TabIndex = 38
        CodempleadoLabel.Text = "codempleado:"
        '
        'CodempleadoTextBox
        '
        Me.CodempleadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "codempleado", True))
        Me.CodempleadoTextBox.Location = New System.Drawing.Point(151, 66)
        Me.CodempleadoTextBox.Name = "CodempleadoTextBox"
        Me.CodempleadoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CodempleadoTextBox.TabIndex = 39
        '
        'CitasBindingSource
        '
        Me.CitasBindingSource.DataMember = "empleadosCitas"
        Me.CitasBindingSource.DataSource = Me.EmpleadosBindingSource
        '
        'CitasTableAdapter
        '
        Me.CitasTableAdapter.ClearBeforeFill = True
        '
        'CitasDataGridView
        '
        Me.CitasDataGridView.AutoGenerateColumns = False
        Me.CitasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CitasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn8, Me.DataGridViewCheckBoxColumn2, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11})
        Me.CitasDataGridView.DataSource = Me.CitasBindingSource
        Me.CitasDataGridView.Location = New System.Drawing.Point(460, 92)
        Me.CitasDataGridView.Name = "CitasDataGridView"
        Me.CitasDataGridView.Size = New System.Drawing.Size(394, 220)
        Me.CitasDataGridView.TabIndex = 39
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "codcliente"
        Me.DataGridViewTextBoxColumn5.HeaderText = "codcliente"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "nombre"
        Me.DataGridViewTextBoxColumn6.HeaderText = "nombre"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "apellido"
        Me.DataGridViewTextBoxColumn7.HeaderText = "apellido"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "asistencia"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "asistencia"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "coddoctor"
        Me.DataGridViewTextBoxColumn8.HeaderText = "coddoctor"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.DataPropertyName = "poscita"
        Me.DataGridViewCheckBoxColumn2.HeaderText = "poscita"
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "codcita"
        Me.DataGridViewTextBoxColumn9.HeaderText = "codcita"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "codempleado"
        Me.DataGridViewTextBoxColumn10.HeaderText = "codempleado"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "observaciones"
        Me.DataGridViewTextBoxColumn11.HeaderText = "observaciones"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'VentasBindingSource
        '
        Me.VentasBindingSource.DataMember = "empleadosventas"
        Me.VentasBindingSource.DataSource = Me.EmpleadosBindingSource
        '
        'VentasTableAdapter
        '
        Me.VentasTableAdapter.ClearBeforeFill = True
        '
        'VentasDataGridView
        '
        Me.VentasDataGridView.AutoGenerateColumns = False
        Me.VentasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VentasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24})
        Me.VentasDataGridView.DataSource = Me.VentasBindingSource
        Me.VentasDataGridView.Location = New System.Drawing.Point(12, 318)
        Me.VentasDataGridView.Name = "VentasDataGridView"
        Me.VentasDataGridView.Size = New System.Drawing.Size(842, 220)
        Me.VentasDataGridView.TabIndex = 39
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "codventa"
        Me.DataGridViewTextBoxColumn12.HeaderText = "codventa"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "codproducto"
        Me.DataGridViewTextBoxColumn13.HeaderText = "codproducto"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "nombre"
        Me.DataGridViewTextBoxColumn14.HeaderText = "nombre"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "apellido"
        Me.DataGridViewTextBoxColumn15.HeaderText = "apellido"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "Nit"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Nit"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "producto"
        Me.DataGridViewTextBoxColumn17.HeaderText = "producto"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "cantidad"
        Me.DataGridViewTextBoxColumn18.HeaderText = "cantidad"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "precio"
        Me.DataGridViewTextBoxColumn19.HeaderText = "precio"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "codfactura"
        Me.DataGridViewTextBoxColumn20.HeaderText = "codfactura"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "fechaegreso"
        Me.DataGridViewTextBoxColumn21.HeaderText = "fechaegreso"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "existencia"
        Me.DataGridViewTextBoxColumn22.HeaderText = "existencia"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "codempleado"
        Me.DataGridViewTextBoxColumn23.HeaderText = "codempleado"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "codcliente"
        Me.DataGridViewTextBoxColumn24.HeaderText = "codcliente"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        '
        'Empleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(911, 648)
        Me.Controls.Add(Me.VentasDataGridView)
        Me.Controls.Add(Me.CitasDataGridView)
        Me.Controls.Add(CodempleadoLabel)
        Me.Controls.Add(Me.CodempleadoTextBox)
        Me.Controls.Add(Me.EmpleadosDataGridView)
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
        Me.Name = "Empleados"
        Me.Text = "Empleados"
        CType(Me.ClinicDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CitasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CitasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents EmpleadosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmpleadosTableAdapter As Clinic.clinicDataSetTableAdapters.empleadosTableAdapter
    Friend WithEvents TableAdapterManager As Clinic.clinicDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EmpleadosDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CitasTableAdapter As Clinic.clinicDataSetTableAdapters.CitasTableAdapter
    Friend WithEvents CodempleadoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CitasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VentasTableAdapter As Clinic.clinicDataSetTableAdapters.ventasTableAdapter
    Friend WithEvents CitasDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VentasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VentasDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
