<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inventario
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
        Dim CodproductoLabel As System.Windows.Forms.Label
        Dim FechaingresoLabel As System.Windows.Forms.Label
        Dim FechasalidaLabel As System.Windows.Forms.Label
        Dim ExistenciaLabel As System.Windows.Forms.Label
        Dim CodinventarioLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim IngresosLabel As System.Windows.Forms.Label
        Dim EgresosLabel As System.Windows.Forms.Label
        Dim PreciocostoLabel As System.Windows.Forms.Label
        Dim PrecioventaLabel As System.Windows.Forms.Label
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
        Me.InventarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InventarioTableAdapter = New Clinic.clinicDataSetTableAdapters.inventarioTableAdapter()
        Me.TableAdapterManager = New Clinic.clinicDataSetTableAdapters.TableAdapterManager()
        Me.VentasTableAdapter = New Clinic.clinicDataSetTableAdapters.ventasTableAdapter()
        Me.InventarioDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VentasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CodproductoTextBox = New System.Windows.Forms.TextBox()
        Me.FechaingresoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.FechasalidaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ExistenciaTextBox = New System.Windows.Forms.TextBox()
        Me.CodinventarioTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.IngresosTextBox = New System.Windows.Forms.TextBox()
        Me.EgresosTextBox = New System.Windows.Forms.TextBox()
        Me.PreciocostoTextBox = New System.Windows.Forms.TextBox()
        Me.PrecioventaTextBox = New System.Windows.Forms.TextBox()
        Me.VentasDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        CodproductoLabel = New System.Windows.Forms.Label()
        FechaingresoLabel = New System.Windows.Forms.Label()
        FechasalidaLabel = New System.Windows.Forms.Label()
        ExistenciaLabel = New System.Windows.Forms.Label()
        CodinventarioLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        IngresosLabel = New System.Windows.Forms.Label()
        EgresosLabel = New System.Windows.Forms.Label()
        PreciocostoLabel = New System.Windows.Forms.Label()
        PrecioventaLabel = New System.Windows.Forms.Label()
        CType(Me.ClinicDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventarioDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CodproductoLabel
        '
        CodproductoLabel.AutoSize = True
        CodproductoLabel.Location = New System.Drawing.Point(370, 129)
        CodproductoLabel.Name = "CodproductoLabel"
        CodproductoLabel.Size = New System.Drawing.Size(70, 13)
        CodproductoLabel.TabIndex = 38
        CodproductoLabel.Text = "codproducto:"
        '
        'FechaingresoLabel
        '
        FechaingresoLabel.AutoSize = True
        FechaingresoLabel.Location = New System.Drawing.Point(369, 78)
        FechaingresoLabel.Name = "FechaingresoLabel"
        FechaingresoLabel.Size = New System.Drawing.Size(71, 13)
        FechaingresoLabel.TabIndex = 39
        FechaingresoLabel.Text = "fechaingreso:"
        '
        'FechasalidaLabel
        '
        FechasalidaLabel.AutoSize = True
        FechasalidaLabel.Location = New System.Drawing.Point(376, 104)
        FechasalidaLabel.Name = "FechasalidaLabel"
        FechasalidaLabel.Size = New System.Drawing.Size(64, 13)
        FechasalidaLabel.TabIndex = 40
        FechasalidaLabel.Text = "fechasalida:"
        '
        'ExistenciaLabel
        '
        ExistenciaLabel.AutoSize = True
        ExistenciaLabel.Location = New System.Drawing.Point(27, 185)
        ExistenciaLabel.Name = "ExistenciaLabel"
        ExistenciaLabel.Size = New System.Drawing.Size(57, 13)
        ExistenciaLabel.TabIndex = 41
        ExistenciaLabel.Text = "existencia:"
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
        Me.Button1.Location = New System.Drawing.Point(597, 569)
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
        Me.Label2.Location = New System.Drawing.Point(269, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(169, 39)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Inventario"
        '
        'ClinicDataSet
        '
        Me.ClinicDataSet.DataSetName = "clinicDataSet"
        Me.ClinicDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'InventarioBindingSource
        '
        Me.InventarioBindingSource.DataMember = "inventario"
        Me.InventarioBindingSource.DataSource = Me.ClinicDataSet
        '
        'InventarioTableAdapter
        '
        Me.InventarioTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CitasTableAdapter = Nothing
        Me.TableAdapterManager.empleadosTableAdapter = Nothing
        Me.TableAdapterManager.inventarioTableAdapter = Me.InventarioTableAdapter
        Me.TableAdapterManager.medicosTableAdapter = Nothing
        Me.TableAdapterManager.pacientesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Clinic.clinicDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.ventasTableAdapter = Me.VentasTableAdapter
        '
        'VentasTableAdapter
        '
        Me.VentasTableAdapter.ClearBeforeFill = True
        '
        'InventarioDataGridView
        '
        Me.InventarioDataGridView.AutoGenerateColumns = False
        Me.InventarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.InventarioDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.InventarioDataGridView.DataSource = Me.InventarioBindingSource
        Me.InventarioDataGridView.Location = New System.Drawing.Point(12, 317)
        Me.InventarioDataGridView.Name = "InventarioDataGridView"
        Me.InventarioDataGridView.Size = New System.Drawing.Size(634, 220)
        Me.InventarioDataGridView.TabIndex = 38
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "codinventario"
        Me.DataGridViewTextBoxColumn1.HeaderText = "codinventario"
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
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ingresos"
        Me.DataGridViewTextBoxColumn3.HeaderText = "ingresos"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "egresos"
        Me.DataGridViewTextBoxColumn4.HeaderText = "egresos"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "existencia"
        Me.DataGridViewTextBoxColumn5.HeaderText = "existencia"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "preciocosto"
        Me.DataGridViewTextBoxColumn6.HeaderText = "preciocosto"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "precioventa"
        Me.DataGridViewTextBoxColumn7.HeaderText = "precioventa"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "fechaingreso"
        Me.DataGridViewTextBoxColumn8.HeaderText = "fechaingreso"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "fechasalida"
        Me.DataGridViewTextBoxColumn9.HeaderText = "fechasalida"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'VentasBindingSource
        '
        Me.VentasBindingSource.DataMember = "inventarioventas"
        Me.VentasBindingSource.DataSource = Me.InventarioBindingSource
        '
        'CodproductoTextBox
        '
        Me.CodproductoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentasBindingSource, "codproducto", True))
        Me.CodproductoTextBox.Location = New System.Drawing.Point(446, 126)
        Me.CodproductoTextBox.Name = "CodproductoTextBox"
        Me.CodproductoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CodproductoTextBox.TabIndex = 39
        '
        'FechaingresoDateTimePicker
        '
        Me.FechaingresoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.InventarioBindingSource, "fechaingreso", True))
        Me.FechaingresoDateTimePicker.Location = New System.Drawing.Point(446, 74)
        Me.FechaingresoDateTimePicker.Name = "FechaingresoDateTimePicker"
        Me.FechaingresoDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.FechaingresoDateTimePicker.TabIndex = 40
        '
        'FechasalidaDateTimePicker
        '
        Me.FechasalidaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.InventarioBindingSource, "fechasalida", True))
        Me.FechasalidaDateTimePicker.Location = New System.Drawing.Point(446, 100)
        Me.FechasalidaDateTimePicker.Name = "FechasalidaDateTimePicker"
        Me.FechasalidaDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.FechasalidaDateTimePicker.TabIndex = 41
        '
        'ExistenciaTextBox
        '
        Me.ExistenciaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InventarioBindingSource, "existencia", True))
        Me.ExistenciaTextBox.Location = New System.Drawing.Point(90, 182)
        Me.ExistenciaTextBox.Name = "ExistenciaTextBox"
        Me.ExistenciaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ExistenciaTextBox.TabIndex = 42
        '
        'CodinventarioLabel
        '
        CodinventarioLabel.AutoSize = True
        CodinventarioLabel.Location = New System.Drawing.Point(10, 81)
        CodinventarioLabel.Name = "CodinventarioLabel"
        CodinventarioLabel.Size = New System.Drawing.Size(74, 13)
        CodinventarioLabel.TabIndex = 42
        CodinventarioLabel.Text = "codinventario:"
        '
        'CodinventarioTextBox
        '
        Me.CodinventarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InventarioBindingSource, "codinventario", True))
        Me.CodinventarioTextBox.Location = New System.Drawing.Point(90, 78)
        Me.CodinventarioTextBox.Name = "CodinventarioTextBox"
        Me.CodinventarioTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CodinventarioTextBox.TabIndex = 43
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(39, 107)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(45, 13)
        NombreLabel.TabIndex = 43
        NombreLabel.Text = "nombre:"
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InventarioBindingSource, "nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(90, 104)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NombreTextBox.TabIndex = 44
        '
        'IngresosLabel
        '
        IngresosLabel.AutoSize = True
        IngresosLabel.Location = New System.Drawing.Point(35, 133)
        IngresosLabel.Name = "IngresosLabel"
        IngresosLabel.Size = New System.Drawing.Size(49, 13)
        IngresosLabel.TabIndex = 44
        IngresosLabel.Text = "ingresos:"
        '
        'IngresosTextBox
        '
        Me.IngresosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InventarioBindingSource, "ingresos", True))
        Me.IngresosTextBox.Location = New System.Drawing.Point(90, 130)
        Me.IngresosTextBox.Name = "IngresosTextBox"
        Me.IngresosTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IngresosTextBox.TabIndex = 45
        '
        'EgresosLabel
        '
        EgresosLabel.AutoSize = True
        EgresosLabel.Location = New System.Drawing.Point(37, 159)
        EgresosLabel.Name = "EgresosLabel"
        EgresosLabel.Size = New System.Drawing.Size(47, 13)
        EgresosLabel.TabIndex = 45
        EgresosLabel.Text = "egresos:"
        '
        'EgresosTextBox
        '
        Me.EgresosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InventarioBindingSource, "egresos", True))
        Me.EgresosTextBox.Location = New System.Drawing.Point(90, 156)
        Me.EgresosTextBox.Name = "EgresosTextBox"
        Me.EgresosTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EgresosTextBox.TabIndex = 46
        '
        'PreciocostoLabel
        '
        PreciocostoLabel.AutoSize = True
        PreciocostoLabel.Location = New System.Drawing.Point(19, 211)
        PreciocostoLabel.Name = "PreciocostoLabel"
        PreciocostoLabel.Size = New System.Drawing.Size(65, 13)
        PreciocostoLabel.TabIndex = 46
        PreciocostoLabel.Text = "preciocosto:"
        '
        'PreciocostoTextBox
        '
        Me.PreciocostoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InventarioBindingSource, "preciocosto", True))
        Me.PreciocostoTextBox.Location = New System.Drawing.Point(90, 208)
        Me.PreciocostoTextBox.Name = "PreciocostoTextBox"
        Me.PreciocostoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PreciocostoTextBox.TabIndex = 47
        '
        'PrecioventaLabel
        '
        PrecioventaLabel.AutoSize = True
        PrecioventaLabel.Location = New System.Drawing.Point(18, 237)
        PrecioventaLabel.Name = "PrecioventaLabel"
        PrecioventaLabel.Size = New System.Drawing.Size(66, 13)
        PrecioventaLabel.TabIndex = 47
        PrecioventaLabel.Text = "precioventa:"
        '
        'PrecioventaTextBox
        '
        Me.PrecioventaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InventarioBindingSource, "precioventa", True))
        Me.PrecioventaTextBox.Location = New System.Drawing.Point(90, 234)
        Me.PrecioventaTextBox.Name = "PrecioventaTextBox"
        Me.PrecioventaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PrecioventaTextBox.TabIndex = 48
        '
        'VentasDataGridView
        '
        Me.VentasDataGridView.AutoGenerateColumns = False
        Me.VentasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VentasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22})
        Me.VentasDataGridView.DataSource = Me.VentasBindingSource
        Me.VentasDataGridView.Location = New System.Drawing.Point(652, 317)
        Me.VentasDataGridView.Name = "VentasDataGridView"
        Me.VentasDataGridView.Size = New System.Drawing.Size(406, 220)
        Me.VentasDataGridView.TabIndex = 48
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "codventa"
        Me.DataGridViewTextBoxColumn10.HeaderText = "codventa"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "codproducto"
        Me.DataGridViewTextBoxColumn11.HeaderText = "codproducto"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "nombre"
        Me.DataGridViewTextBoxColumn12.HeaderText = "nombre"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "apellido"
        Me.DataGridViewTextBoxColumn13.HeaderText = "apellido"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Nit"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Nit"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "producto"
        Me.DataGridViewTextBoxColumn15.HeaderText = "producto"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "cantidad"
        Me.DataGridViewTextBoxColumn16.HeaderText = "cantidad"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "precio"
        Me.DataGridViewTextBoxColumn17.HeaderText = "precio"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "codfactura"
        Me.DataGridViewTextBoxColumn18.HeaderText = "codfactura"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "fechaegreso"
        Me.DataGridViewTextBoxColumn19.HeaderText = "fechaegreso"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "existencia"
        Me.DataGridViewTextBoxColumn20.HeaderText = "existencia"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "codempleado"
        Me.DataGridViewTextBoxColumn21.HeaderText = "codempleado"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "codcliente"
        Me.DataGridViewTextBoxColumn22.HeaderText = "codcliente"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        '
        'Inventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1078, 637)
        Me.Controls.Add(Me.VentasDataGridView)
        Me.Controls.Add(PrecioventaLabel)
        Me.Controls.Add(Me.PrecioventaTextBox)
        Me.Controls.Add(PreciocostoLabel)
        Me.Controls.Add(Me.PreciocostoTextBox)
        Me.Controls.Add(EgresosLabel)
        Me.Controls.Add(Me.EgresosTextBox)
        Me.Controls.Add(IngresosLabel)
        Me.Controls.Add(Me.IngresosTextBox)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(CodinventarioLabel)
        Me.Controls.Add(Me.CodinventarioTextBox)
        Me.Controls.Add(ExistenciaLabel)
        Me.Controls.Add(Me.ExistenciaTextBox)
        Me.Controls.Add(FechasalidaLabel)
        Me.Controls.Add(Me.FechasalidaDateTimePicker)
        Me.Controls.Add(FechaingresoLabel)
        Me.Controls.Add(Me.FechaingresoDateTimePicker)
        Me.Controls.Add(CodproductoLabel)
        Me.Controls.Add(Me.CodproductoTextBox)
        Me.Controls.Add(Me.InventarioDataGridView)
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
        Me.Name = "Inventario"
        Me.Text = "Inventario"
        CType(Me.ClinicDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventarioDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents InventarioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents InventarioTableAdapter As Clinic.clinicDataSetTableAdapters.inventarioTableAdapter
    Friend WithEvents TableAdapterManager As Clinic.clinicDataSetTableAdapters.TableAdapterManager
    Friend WithEvents InventarioDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VentasTableAdapter As Clinic.clinicDataSetTableAdapters.ventasTableAdapter
    Friend WithEvents VentasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CodproductoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FechaingresoDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents FechasalidaDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ExistenciaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CodinventarioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NombreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IngresosTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EgresosTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PreciocostoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PrecioventaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents VentasDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
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
End Class
