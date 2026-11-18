<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clientes
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
        Dim CodpacienteLabel As System.Windows.Forms.Label
        Dim FechaingresoLabel As System.Windows.Forms.Label
        Dim FechasalidaLabel As System.Windows.Forms.Label
        Dim CodmedicoLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim ApellidoLabel As System.Windows.Forms.Label
        Dim DireccionLabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Dim CelularLabel As System.Windows.Forms.Label
        Dim PesoLabel As System.Windows.Forms.Label
        Dim AlturaLabel As System.Windows.Forms.Label
        Dim IMCLabel As System.Windows.Forms.Label
        Dim AlergiasLabel As System.Windows.Forms.Label
        Dim HoracitaLabel As System.Windows.Forms.Label
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
        Me.PacientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PacientesTableAdapter = New Clinic.clinicDataSetTableAdapters.pacientesTableAdapter()
        Me.TableAdapterManager = New Clinic.clinicDataSetTableAdapters.TableAdapterManager()
        Me.PacientesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodpacienteTextBox = New System.Windows.Forms.TextBox()
        Me.FechaingresoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.FechasalidaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.CodmedicoTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.ApellidoTextBox = New System.Windows.Forms.TextBox()
        Me.DireccionTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonoTextBox = New System.Windows.Forms.TextBox()
        Me.CelularTextBox = New System.Windows.Forms.TextBox()
        Me.PesoTextBox = New System.Windows.Forms.TextBox()
        Me.AlturaTextBox = New System.Windows.Forms.TextBox()
        Me.IMCTextBox = New System.Windows.Forms.TextBox()
        Me.AlergiasTextBox = New System.Windows.Forms.TextBox()
        Me.HoracitaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        CodpacienteLabel = New System.Windows.Forms.Label()
        FechaingresoLabel = New System.Windows.Forms.Label()
        FechasalidaLabel = New System.Windows.Forms.Label()
        CodmedicoLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        ApellidoLabel = New System.Windows.Forms.Label()
        DireccionLabel = New System.Windows.Forms.Label()
        TelefonoLabel = New System.Windows.Forms.Label()
        CelularLabel = New System.Windows.Forms.Label()
        PesoLabel = New System.Windows.Forms.Label()
        AlturaLabel = New System.Windows.Forms.Label()
        IMCLabel = New System.Windows.Forms.Label()
        AlergiasLabel = New System.Windows.Forms.Label()
        HoracitaLabel = New System.Windows.Forms.Label()
        CType(Me.ClinicDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PacientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PacientesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CodpacienteLabel
        '
        CodpacienteLabel.AutoSize = True
        CodpacienteLabel.Location = New System.Drawing.Point(9, 91)
        CodpacienteLabel.Name = "CodpacienteLabel"
        CodpacienteLabel.Size = New System.Drawing.Size(69, 13)
        CodpacienteLabel.TabIndex = 38
        CodpacienteLabel.Text = "codpaciente:"
        '
        'FechaingresoLabel
        '
        FechaingresoLabel.AutoSize = True
        FechaingresoLabel.Location = New System.Drawing.Point(239, 115)
        FechaingresoLabel.Name = "FechaingresoLabel"
        FechaingresoLabel.Size = New System.Drawing.Size(71, 13)
        FechaingresoLabel.TabIndex = 39
        FechaingresoLabel.Text = "fechaingreso:"
        '
        'FechasalidaLabel
        '
        FechasalidaLabel.AutoSize = True
        FechasalidaLabel.Location = New System.Drawing.Point(246, 140)
        FechasalidaLabel.Name = "FechasalidaLabel"
        FechasalidaLabel.Size = New System.Drawing.Size(64, 13)
        FechasalidaLabel.TabIndex = 40
        FechasalidaLabel.Text = "fechasalida:"
        '
        'CodmedicoLabel
        '
        CodmedicoLabel.AutoSize = True
        CodmedicoLabel.Location = New System.Drawing.Point(248, 224)
        CodmedicoLabel.Name = "CodmedicoLabel"
        CodmedicoLabel.Size = New System.Drawing.Size(62, 13)
        CodmedicoLabel.TabIndex = 41
        CodmedicoLabel.Text = "codmedico:"
        '
        'Button10
        '
        Me.Button10.Image = Global.Clinic.My.Resources.Resources.eliminar
        Me.Button10.Location = New System.Drawing.Point(460, 573)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(50, 48)
        Me.Button10.TabIndex = 35
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Image = Global.Clinic.My.Resources.Resources.insertar
        Me.Button9.Location = New System.Drawing.Point(404, 573)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(50, 48)
        Me.Button9.TabIndex = 34
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Image = Global.Clinic.My.Resources.Resources.actualizar
        Me.Button8.Location = New System.Drawing.Point(348, 573)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(50, 48)
        Me.Button8.TabIndex = 33
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Image = Global.Clinic.My.Resources.Resources.guardar
        Me.Button7.Location = New System.Drawing.Point(292, 573)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(50, 48)
        Me.Button7.TabIndex = 32
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Image = Global.Clinic.My.Resources.Resources.buscar
        Me.Button6.Location = New System.Drawing.Point(236, 573)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(50, 48)
        Me.Button6.TabIndex = 31
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Image = Global.Clinic.My.Resources.Resources.ultimo
        Me.Button5.Location = New System.Drawing.Point(180, 573)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(50, 48)
        Me.Button5.TabIndex = 30
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Image = Global.Clinic.My.Resources.Resources.siguiente
        Me.Button4.Location = New System.Drawing.Point(124, 573)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(50, 48)
        Me.Button4.TabIndex = 29
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Image = Global.Clinic.My.Resources.Resources.atras
        Me.Button3.Location = New System.Drawing.Point(68, 573)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(50, 48)
        Me.Button3.TabIndex = 28
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = Global.Clinic.My.Resources.Resources.primero
        Me.Button2.Location = New System.Drawing.Point(12, 573)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(50, 48)
        Me.Button2.TabIndex = 27
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(614, 573)
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
        Me.Label2.Location = New System.Drawing.Point(355, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(143, 39)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Clientes"
        '
        'ClinicDataSet
        '
        Me.ClinicDataSet.DataSetName = "clinicDataSet"
        Me.ClinicDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PacientesBindingSource
        '
        Me.PacientesBindingSource.DataMember = "pacientes"
        Me.PacientesBindingSource.DataSource = Me.ClinicDataSet
        '
        'PacientesTableAdapter
        '
        Me.PacientesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CitasTableAdapter = Nothing
        Me.TableAdapterManager.empleadosTableAdapter = Nothing
        Me.TableAdapterManager.inventarioTableAdapter = Nothing
        Me.TableAdapterManager.medicosTableAdapter = Nothing
        Me.TableAdapterManager.pacientesTableAdapter = Me.PacientesTableAdapter
        Me.TableAdapterManager.UpdateOrder = Clinic.clinicDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.ventasTableAdapter = Nothing
        '
        'PacientesDataGridView
        '
        Me.PacientesDataGridView.AutoGenerateColumns = False
        Me.PacientesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PacientesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14})
        Me.PacientesDataGridView.DataSource = Me.PacientesBindingSource
        Me.PacientesDataGridView.Location = New System.Drawing.Point(12, 326)
        Me.PacientesDataGridView.Name = "PacientesDataGridView"
        Me.PacientesDataGridView.Size = New System.Drawing.Size(742, 220)
        Me.PacientesDataGridView.TabIndex = 38
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "codpaciente"
        Me.DataGridViewTextBoxColumn1.HeaderText = "codpaciente"
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
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "direccion"
        Me.DataGridViewTextBoxColumn4.HeaderText = "direccion"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "telefono"
        Me.DataGridViewTextBoxColumn5.HeaderText = "telefono"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "celular"
        Me.DataGridViewTextBoxColumn6.HeaderText = "celular"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "peso"
        Me.DataGridViewTextBoxColumn7.HeaderText = "peso"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "altura"
        Me.DataGridViewTextBoxColumn8.HeaderText = "altura"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "IMC"
        Me.DataGridViewTextBoxColumn9.HeaderText = "IMC"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "fechaingreso"
        Me.DataGridViewTextBoxColumn10.HeaderText = "fechaingreso"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "fechasalida"
        Me.DataGridViewTextBoxColumn11.HeaderText = "fechasalida"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "alergias"
        Me.DataGridViewTextBoxColumn12.HeaderText = "alergias"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "codmedico"
        Me.DataGridViewTextBoxColumn13.HeaderText = "codmedico"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "horacita"
        Me.DataGridViewTextBoxColumn14.HeaderText = "horacita"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'CodpacienteTextBox
        '
        Me.CodpacienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "codpaciente", True))
        Me.CodpacienteTextBox.Location = New System.Drawing.Point(84, 88)
        Me.CodpacienteTextBox.Name = "CodpacienteTextBox"
        Me.CodpacienteTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CodpacienteTextBox.TabIndex = 39
        '
        'FechaingresoDateTimePicker
        '
        Me.FechaingresoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PacientesBindingSource, "fechaingreso", True))
        Me.FechaingresoDateTimePicker.Location = New System.Drawing.Point(316, 111)
        Me.FechaingresoDateTimePicker.Name = "FechaingresoDateTimePicker"
        Me.FechaingresoDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.FechaingresoDateTimePicker.TabIndex = 40
        '
        'FechasalidaDateTimePicker
        '
        Me.FechasalidaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PacientesBindingSource, "fechasalida", True))
        Me.FechasalidaDateTimePicker.Location = New System.Drawing.Point(316, 136)
        Me.FechasalidaDateTimePicker.Name = "FechasalidaDateTimePicker"
        Me.FechasalidaDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.FechasalidaDateTimePicker.TabIndex = 41
        '
        'CodmedicoTextBox
        '
        Me.CodmedicoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "codmedico", True))
        Me.CodmedicoTextBox.Location = New System.Drawing.Point(316, 221)
        Me.CodmedicoTextBox.Name = "CodmedicoTextBox"
        Me.CodmedicoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CodmedicoTextBox.TabIndex = 42
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(33, 117)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(45, 13)
        NombreLabel.TabIndex = 42
        NombreLabel.Text = "nombre:"
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(84, 114)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NombreTextBox.TabIndex = 43
        '
        'ApellidoLabel
        '
        ApellidoLabel.AutoSize = True
        ApellidoLabel.Location = New System.Drawing.Point(32, 143)
        ApellidoLabel.Name = "ApellidoLabel"
        ApellidoLabel.Size = New System.Drawing.Size(46, 13)
        ApellidoLabel.TabIndex = 43
        ApellidoLabel.Text = "apellido:"
        '
        'ApellidoTextBox
        '
        Me.ApellidoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "apellido", True))
        Me.ApellidoTextBox.Location = New System.Drawing.Point(84, 140)
        Me.ApellidoTextBox.Name = "ApellidoTextBox"
        Me.ApellidoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ApellidoTextBox.TabIndex = 44
        '
        'DireccionLabel
        '
        DireccionLabel.AutoSize = True
        DireccionLabel.Location = New System.Drawing.Point(25, 169)
        DireccionLabel.Name = "DireccionLabel"
        DireccionLabel.Size = New System.Drawing.Size(53, 13)
        DireccionLabel.TabIndex = 44
        DireccionLabel.Text = "direccion:"
        '
        'DireccionTextBox
        '
        Me.DireccionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "direccion", True))
        Me.DireccionTextBox.Location = New System.Drawing.Point(84, 166)
        Me.DireccionTextBox.Name = "DireccionTextBox"
        Me.DireccionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DireccionTextBox.TabIndex = 45
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.Location = New System.Drawing.Point(30, 195)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(48, 13)
        TelefonoLabel.TabIndex = 45
        TelefonoLabel.Text = "telefono:"
        '
        'TelefonoTextBox
        '
        Me.TelefonoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "telefono", True))
        Me.TelefonoTextBox.Location = New System.Drawing.Point(84, 192)
        Me.TelefonoTextBox.Name = "TelefonoTextBox"
        Me.TelefonoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TelefonoTextBox.TabIndex = 46
        '
        'CelularLabel
        '
        CelularLabel.AutoSize = True
        CelularLabel.Location = New System.Drawing.Point(37, 221)
        CelularLabel.Name = "CelularLabel"
        CelularLabel.Size = New System.Drawing.Size(41, 13)
        CelularLabel.TabIndex = 46
        CelularLabel.Text = "celular:"
        '
        'CelularTextBox
        '
        Me.CelularTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "celular", True))
        Me.CelularTextBox.Location = New System.Drawing.Point(84, 218)
        Me.CelularTextBox.Name = "CelularTextBox"
        Me.CelularTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CelularTextBox.TabIndex = 47
        '
        'PesoLabel
        '
        PesoLabel.AutoSize = True
        PesoLabel.Location = New System.Drawing.Point(45, 247)
        PesoLabel.Name = "PesoLabel"
        PesoLabel.Size = New System.Drawing.Size(33, 13)
        PesoLabel.TabIndex = 47
        PesoLabel.Text = "peso:"
        '
        'PesoTextBox
        '
        Me.PesoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "peso", True))
        Me.PesoTextBox.Location = New System.Drawing.Point(84, 244)
        Me.PesoTextBox.Name = "PesoTextBox"
        Me.PesoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PesoTextBox.TabIndex = 48
        '
        'AlturaLabel
        '
        AlturaLabel.AutoSize = True
        AlturaLabel.Location = New System.Drawing.Point(42, 273)
        AlturaLabel.Name = "AlturaLabel"
        AlturaLabel.Size = New System.Drawing.Size(36, 13)
        AlturaLabel.TabIndex = 48
        AlturaLabel.Text = "altura:"
        '
        'AlturaTextBox
        '
        Me.AlturaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "altura", True))
        Me.AlturaTextBox.Location = New System.Drawing.Point(84, 270)
        Me.AlturaTextBox.Name = "AlturaTextBox"
        Me.AlturaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AlturaTextBox.TabIndex = 49
        '
        'IMCLabel
        '
        IMCLabel.AutoSize = True
        IMCLabel.Location = New System.Drawing.Point(281, 91)
        IMCLabel.Name = "IMCLabel"
        IMCLabel.Size = New System.Drawing.Size(29, 13)
        IMCLabel.TabIndex = 49
        IMCLabel.Text = "IMC:"
        '
        'IMCTextBox
        '
        Me.IMCTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "IMC", True))
        Me.IMCTextBox.Location = New System.Drawing.Point(316, 88)
        Me.IMCTextBox.Name = "IMCTextBox"
        Me.IMCTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IMCTextBox.TabIndex = 50
        '
        'AlergiasLabel
        '
        AlergiasLabel.AutoSize = True
        AlergiasLabel.Location = New System.Drawing.Point(264, 165)
        AlergiasLabel.Name = "AlergiasLabel"
        AlergiasLabel.Size = New System.Drawing.Size(46, 13)
        AlergiasLabel.TabIndex = 50
        AlergiasLabel.Text = "alergias:"
        '
        'AlergiasTextBox
        '
        Me.AlergiasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "alergias", True))
        Me.AlergiasTextBox.Location = New System.Drawing.Point(316, 162)
        Me.AlergiasTextBox.Name = "AlergiasTextBox"
        Me.AlergiasTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AlergiasTextBox.TabIndex = 51
        '
        'HoracitaLabel
        '
        HoracitaLabel.AutoSize = True
        HoracitaLabel.Location = New System.Drawing.Point(262, 199)
        HoracitaLabel.Name = "HoracitaLabel"
        HoracitaLabel.Size = New System.Drawing.Size(48, 13)
        HoracitaLabel.TabIndex = 51
        HoracitaLabel.Text = "horacita:"
        '
        'HoracitaDateTimePicker
        '
        Me.HoracitaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PacientesBindingSource, "horacita", True))
        Me.HoracitaDateTimePicker.Location = New System.Drawing.Point(316, 195)
        Me.HoracitaDateTimePicker.Name = "HoracitaDateTimePicker"
        Me.HoracitaDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.HoracitaDateTimePicker.TabIndex = 52
        '
        'Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1001, 641)
        Me.Controls.Add(HoracitaLabel)
        Me.Controls.Add(Me.HoracitaDateTimePicker)
        Me.Controls.Add(AlergiasLabel)
        Me.Controls.Add(Me.AlergiasTextBox)
        Me.Controls.Add(IMCLabel)
        Me.Controls.Add(Me.IMCTextBox)
        Me.Controls.Add(AlturaLabel)
        Me.Controls.Add(Me.AlturaTextBox)
        Me.Controls.Add(PesoLabel)
        Me.Controls.Add(Me.PesoTextBox)
        Me.Controls.Add(CelularLabel)
        Me.Controls.Add(Me.CelularTextBox)
        Me.Controls.Add(TelefonoLabel)
        Me.Controls.Add(Me.TelefonoTextBox)
        Me.Controls.Add(DireccionLabel)
        Me.Controls.Add(Me.DireccionTextBox)
        Me.Controls.Add(ApellidoLabel)
        Me.Controls.Add(Me.ApellidoTextBox)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(CodmedicoLabel)
        Me.Controls.Add(Me.CodmedicoTextBox)
        Me.Controls.Add(FechasalidaLabel)
        Me.Controls.Add(Me.FechasalidaDateTimePicker)
        Me.Controls.Add(FechaingresoLabel)
        Me.Controls.Add(Me.FechaingresoDateTimePicker)
        Me.Controls.Add(CodpacienteLabel)
        Me.Controls.Add(Me.CodpacienteTextBox)
        Me.Controls.Add(Me.PacientesDataGridView)
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
        Me.Name = "Clientes"
        Me.Text = "Form2"
        CType(Me.ClinicDataSet, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PacientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PacientesTableAdapter As Clinic.clinicDataSetTableAdapters.pacientesTableAdapter
    Friend WithEvents TableAdapterManager As Clinic.clinicDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PacientesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodpacienteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FechaingresoDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents FechasalidaDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents CodmedicoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NombreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ApellidoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DireccionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TelefonoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CelularTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PesoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AlturaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IMCTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AlergiasTextBox As System.Windows.Forms.TextBox
    Friend WithEvents HoracitaDateTimePicker As System.Windows.Forms.DateTimePicker
End Class
