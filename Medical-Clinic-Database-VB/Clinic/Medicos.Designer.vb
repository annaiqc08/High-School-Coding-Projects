<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Medicos
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
        Dim CodmedicoLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim ApellidoLabel As System.Windows.Forms.Label
        Dim EspecialidadLabel As System.Windows.Forms.Label
        Dim HoraspordiaLabel As System.Windows.Forms.Label
        Dim CitasLabel As System.Windows.Forms.Label
        Dim CodclientesLabel As System.Windows.Forms.Label
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
        Me.MedicosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MedicosTableAdapter = New Clinic.clinicDataSetTableAdapters.medicosTableAdapter()
        Me.TableAdapterManager = New Clinic.clinicDataSetTableAdapters.TableAdapterManager()
        Me.MedicosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodmedicoTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.ApellidoTextBox = New System.Windows.Forms.TextBox()
        Me.EspecialidadTextBox = New System.Windows.Forms.TextBox()
        Me.HoraspordiaTextBox = New System.Windows.Forms.TextBox()
        Me.CitasTextBox = New System.Windows.Forms.TextBox()
        Me.CodclientesTextBox = New System.Windows.Forms.TextBox()
        Me.CitasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CitasTableAdapter = New Clinic.clinicDataSetTableAdapters.CitasTableAdapter()
        Me.CitasDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PacientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PacientesTableAdapter = New Clinic.clinicDataSetTableAdapters.pacientesTableAdapter()
        Me.PacientesDataGridView = New System.Windows.Forms.DataGridView()
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
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CodmedicoLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        ApellidoLabel = New System.Windows.Forms.Label()
        EspecialidadLabel = New System.Windows.Forms.Label()
        HoraspordiaLabel = New System.Windows.Forms.Label()
        CitasLabel = New System.Windows.Forms.Label()
        CodclientesLabel = New System.Windows.Forms.Label()
        CType(Me.ClinicDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MedicosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MedicosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CitasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CitasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PacientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PacientesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CodmedicoLabel
        '
        CodmedicoLabel.AutoSize = True
        CodmedicoLabel.Location = New System.Drawing.Point(15, 93)
        CodmedicoLabel.Name = "CodmedicoLabel"
        CodmedicoLabel.Size = New System.Drawing.Size(62, 13)
        CodmedicoLabel.TabIndex = 38
        CodmedicoLabel.Text = "codmedico:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(32, 119)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(45, 13)
        NombreLabel.TabIndex = 39
        NombreLabel.Text = "nombre:"
        '
        'ApellidoLabel
        '
        ApellidoLabel.AutoSize = True
        ApellidoLabel.Location = New System.Drawing.Point(31, 145)
        ApellidoLabel.Name = "ApellidoLabel"
        ApellidoLabel.Size = New System.Drawing.Size(46, 13)
        ApellidoLabel.TabIndex = 40
        ApellidoLabel.Text = "apellido:"
        '
        'Button10
        '
        Me.Button10.Image = Global.Clinic.My.Resources.Resources.eliminar
        Me.Button10.Location = New System.Drawing.Point(460, 545)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(50, 48)
        Me.Button10.TabIndex = 35
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Image = Global.Clinic.My.Resources.Resources.insertar
        Me.Button9.Location = New System.Drawing.Point(404, 545)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(50, 48)
        Me.Button9.TabIndex = 34
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Image = Global.Clinic.My.Resources.Resources.actualizar
        Me.Button8.Location = New System.Drawing.Point(348, 545)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(50, 48)
        Me.Button8.TabIndex = 33
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Image = Global.Clinic.My.Resources.Resources.guardar
        Me.Button7.Location = New System.Drawing.Point(292, 545)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(50, 48)
        Me.Button7.TabIndex = 32
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Image = Global.Clinic.My.Resources.Resources.buscar
        Me.Button6.Location = New System.Drawing.Point(236, 545)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(50, 48)
        Me.Button6.TabIndex = 31
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Image = Global.Clinic.My.Resources.Resources.ultimo
        Me.Button5.Location = New System.Drawing.Point(180, 545)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(50, 48)
        Me.Button5.TabIndex = 30
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Image = Global.Clinic.My.Resources.Resources.siguiente
        Me.Button4.Location = New System.Drawing.Point(124, 545)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(50, 48)
        Me.Button4.TabIndex = 29
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Image = Global.Clinic.My.Resources.Resources.atras
        Me.Button3.Location = New System.Drawing.Point(68, 545)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(50, 48)
        Me.Button3.TabIndex = 28
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = Global.Clinic.My.Resources.Resources.primero
        Me.Button2.Location = New System.Drawing.Point(12, 545)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(50, 48)
        Me.Button2.TabIndex = 27
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(645, 545)
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
        Me.Label2.Location = New System.Drawing.Point(206, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 39)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Medicos"
        '
        'ClinicDataSet
        '
        Me.ClinicDataSet.DataSetName = "clinicDataSet"
        Me.ClinicDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MedicosBindingSource
        '
        Me.MedicosBindingSource.DataMember = "medicos"
        Me.MedicosBindingSource.DataSource = Me.ClinicDataSet
        '
        'MedicosTableAdapter
        '
        Me.MedicosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CitasTableAdapter = Nothing
        Me.TableAdapterManager.empleadosTableAdapter = Nothing
        Me.TableAdapterManager.inventarioTableAdapter = Nothing
        Me.TableAdapterManager.medicosTableAdapter = Me.MedicosTableAdapter
        Me.TableAdapterManager.pacientesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Clinic.clinicDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.ventasTableAdapter = Nothing
        '
        'MedicosDataGridView
        '
        Me.MedicosDataGridView.AutoGenerateColumns = False
        Me.MedicosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MedicosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.MedicosDataGridView.DataSource = Me.MedicosBindingSource
        Me.MedicosDataGridView.Location = New System.Drawing.Point(12, 295)
        Me.MedicosDataGridView.Name = "MedicosDataGridView"
        Me.MedicosDataGridView.Size = New System.Drawing.Size(745, 220)
        Me.MedicosDataGridView.TabIndex = 38
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "codmedico"
        Me.DataGridViewTextBoxColumn1.HeaderText = "codmedico"
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
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "especialidad"
        Me.DataGridViewTextBoxColumn4.HeaderText = "especialidad"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "horaspordia"
        Me.DataGridViewTextBoxColumn5.HeaderText = "horaspordia"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "citas"
        Me.DataGridViewTextBoxColumn6.HeaderText = "citas"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "codclientes"
        Me.DataGridViewTextBoxColumn7.HeaderText = "codclientes"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'CodmedicoTextBox
        '
        Me.CodmedicoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MedicosBindingSource, "codmedico", True))
        Me.CodmedicoTextBox.Location = New System.Drawing.Point(83, 90)
        Me.CodmedicoTextBox.Name = "CodmedicoTextBox"
        Me.CodmedicoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CodmedicoTextBox.TabIndex = 39
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MedicosBindingSource, "nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(83, 116)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NombreTextBox.TabIndex = 40
        '
        'ApellidoTextBox
        '
        Me.ApellidoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MedicosBindingSource, "apellido", True))
        Me.ApellidoTextBox.Location = New System.Drawing.Point(83, 142)
        Me.ApellidoTextBox.Name = "ApellidoTextBox"
        Me.ApellidoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ApellidoTextBox.TabIndex = 41
        '
        'EspecialidadLabel
        '
        EspecialidadLabel.AutoSize = True
        EspecialidadLabel.Location = New System.Drawing.Point(8, 171)
        EspecialidadLabel.Name = "EspecialidadLabel"
        EspecialidadLabel.Size = New System.Drawing.Size(69, 13)
        EspecialidadLabel.TabIndex = 41
        EspecialidadLabel.Text = "especialidad:"
        '
        'EspecialidadTextBox
        '
        Me.EspecialidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MedicosBindingSource, "especialidad", True))
        Me.EspecialidadTextBox.Location = New System.Drawing.Point(83, 168)
        Me.EspecialidadTextBox.Name = "EspecialidadTextBox"
        Me.EspecialidadTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EspecialidadTextBox.TabIndex = 42
        '
        'HoraspordiaLabel
        '
        HoraspordiaLabel.AutoSize = True
        HoraspordiaLabel.Location = New System.Drawing.Point(12, 197)
        HoraspordiaLabel.Name = "HoraspordiaLabel"
        HoraspordiaLabel.Size = New System.Drawing.Size(65, 13)
        HoraspordiaLabel.TabIndex = 42
        HoraspordiaLabel.Text = "horaspordia:"
        '
        'HoraspordiaTextBox
        '
        Me.HoraspordiaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MedicosBindingSource, "horaspordia", True))
        Me.HoraspordiaTextBox.Location = New System.Drawing.Point(83, 194)
        Me.HoraspordiaTextBox.Name = "HoraspordiaTextBox"
        Me.HoraspordiaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.HoraspordiaTextBox.TabIndex = 43
        '
        'CitasLabel
        '
        CitasLabel.AutoSize = True
        CitasLabel.Location = New System.Drawing.Point(382, 89)
        CitasLabel.Name = "CitasLabel"
        CitasLabel.Size = New System.Drawing.Size(32, 13)
        CitasLabel.TabIndex = 43
        CitasLabel.Text = "citas:"
        '
        'CitasTextBox
        '
        Me.CitasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MedicosBindingSource, "citas", True))
        Me.CitasTextBox.Location = New System.Drawing.Point(420, 86)
        Me.CitasTextBox.Name = "CitasTextBox"
        Me.CitasTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CitasTextBox.TabIndex = 44
        '
        'CodclientesLabel
        '
        CodclientesLabel.AutoSize = True
        CodclientesLabel.Location = New System.Drawing.Point(350, 115)
        CodclientesLabel.Name = "CodclientesLabel"
        CodclientesLabel.Size = New System.Drawing.Size(64, 13)
        CodclientesLabel.TabIndex = 44
        CodclientesLabel.Text = "codclientes:"
        '
        'CodclientesTextBox
        '
        Me.CodclientesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MedicosBindingSource, "codclientes", True))
        Me.CodclientesTextBox.Location = New System.Drawing.Point(420, 112)
        Me.CodclientesTextBox.Name = "CodclientesTextBox"
        Me.CodclientesTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CodclientesTextBox.TabIndex = 45
        '
        'CitasBindingSource
        '
        Me.CitasBindingSource.DataMember = "medicosCitas"
        Me.CitasBindingSource.DataSource = Me.MedicosBindingSource
        '
        'CitasTableAdapter
        '
        Me.CitasTableAdapter.ClearBeforeFill = True
        '
        'CitasDataGridView
        '
        Me.CitasDataGridView.AutoGenerateColumns = False
        Me.CitasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CitasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn11, Me.DataGridViewCheckBoxColumn2, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14})
        Me.CitasDataGridView.DataSource = Me.CitasBindingSource
        Me.CitasDataGridView.Location = New System.Drawing.Point(642, 44)
        Me.CitasDataGridView.Name = "CitasDataGridView"
        Me.CitasDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.CitasDataGridView.TabIndex = 45
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "codcliente"
        Me.DataGridViewTextBoxColumn8.HeaderText = "codcliente"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "nombre"
        Me.DataGridViewTextBoxColumn9.HeaderText = "nombre"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "apellido"
        Me.DataGridViewTextBoxColumn10.HeaderText = "apellido"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "asistencia"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "asistencia"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "coddoctor"
        Me.DataGridViewTextBoxColumn11.HeaderText = "coddoctor"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.DataPropertyName = "poscita"
        Me.DataGridViewCheckBoxColumn2.HeaderText = "poscita"
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "codcita"
        Me.DataGridViewTextBoxColumn12.HeaderText = "codcita"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "codempleado"
        Me.DataGridViewTextBoxColumn13.HeaderText = "codempleado"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "observaciones"
        Me.DataGridViewTextBoxColumn14.HeaderText = "observaciones"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'PacientesBindingSource
        '
        Me.PacientesBindingSource.DataMember = "medicospacientes"
        Me.PacientesBindingSource.DataSource = Me.MedicosBindingSource
        '
        'PacientesTableAdapter
        '
        Me.PacientesTableAdapter.ClearBeforeFill = True
        '
        'PacientesDataGridView
        '
        Me.PacientesDataGridView.AutoGenerateColumns = False
        Me.PacientesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PacientesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn25, Me.DataGridViewTextBoxColumn26, Me.DataGridViewTextBoxColumn27, Me.DataGridViewTextBoxColumn28})
        Me.PacientesDataGridView.DataSource = Me.PacientesBindingSource
        Me.PacientesDataGridView.Location = New System.Drawing.Point(847, 351)
        Me.PacientesDataGridView.Name = "PacientesDataGridView"
        Me.PacientesDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.PacientesDataGridView.TabIndex = 45
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "codpaciente"
        Me.DataGridViewTextBoxColumn15.HeaderText = "codpaciente"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "nombre"
        Me.DataGridViewTextBoxColumn16.HeaderText = "nombre"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "apellido"
        Me.DataGridViewTextBoxColumn17.HeaderText = "apellido"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "direccion"
        Me.DataGridViewTextBoxColumn18.HeaderText = "direccion"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "telefono"
        Me.DataGridViewTextBoxColumn19.HeaderText = "telefono"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "celular"
        Me.DataGridViewTextBoxColumn20.HeaderText = "celular"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "peso"
        Me.DataGridViewTextBoxColumn21.HeaderText = "peso"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "altura"
        Me.DataGridViewTextBoxColumn22.HeaderText = "altura"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "IMC"
        Me.DataGridViewTextBoxColumn23.HeaderText = "IMC"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "fechaingreso"
        Me.DataGridViewTextBoxColumn24.HeaderText = "fechaingreso"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "fechasalida"
        Me.DataGridViewTextBoxColumn25.HeaderText = "fechasalida"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "alergias"
        Me.DataGridViewTextBoxColumn26.HeaderText = "alergias"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "codmedico"
        Me.DataGridViewTextBoxColumn27.HeaderText = "codmedico"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "horacita"
        Me.DataGridViewTextBoxColumn28.HeaderText = "horacita"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        '
        'Medicos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1167, 613)
        Me.Controls.Add(Me.PacientesDataGridView)
        Me.Controls.Add(Me.CitasDataGridView)
        Me.Controls.Add(CodclientesLabel)
        Me.Controls.Add(Me.CodclientesTextBox)
        Me.Controls.Add(CitasLabel)
        Me.Controls.Add(Me.CitasTextBox)
        Me.Controls.Add(HoraspordiaLabel)
        Me.Controls.Add(Me.HoraspordiaTextBox)
        Me.Controls.Add(EspecialidadLabel)
        Me.Controls.Add(Me.EspecialidadTextBox)
        Me.Controls.Add(ApellidoLabel)
        Me.Controls.Add(Me.ApellidoTextBox)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(CodmedicoLabel)
        Me.Controls.Add(Me.CodmedicoTextBox)
        Me.Controls.Add(Me.MedicosDataGridView)
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
        Me.Name = "Medicos"
        Me.Text = "Medicos"
        CType(Me.ClinicDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MedicosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MedicosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CitasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CitasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PacientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PacientesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents MedicosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MedicosTableAdapter As Clinic.clinicDataSetTableAdapters.medicosTableAdapter
    Friend WithEvents TableAdapterManager As Clinic.clinicDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MedicosDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodmedicoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NombreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ApellidoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EspecialidadTextBox As System.Windows.Forms.TextBox
    Friend WithEvents HoraspordiaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CitasTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CodclientesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CitasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CitasTableAdapter As Clinic.clinicDataSetTableAdapters.CitasTableAdapter
    Friend WithEvents CitasDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PacientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PacientesTableAdapter As Clinic.clinicDataSetTableAdapters.pacientesTableAdapter
    Friend WithEvents PacientesDataGridView As System.Windows.Forms.DataGridView
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
    Friend WithEvents DataGridViewTextBoxColumn25 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
