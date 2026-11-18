<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Juego
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.port0 = New System.Windows.Forms.PictureBox()
        Me.imag7 = New System.Windows.Forms.PictureBox()
        Me.imag6 = New System.Windows.Forms.PictureBox()
        Me.imag5 = New System.Windows.Forms.PictureBox()
        Me.imag4 = New System.Windows.Forms.PictureBox()
        Me.imag3 = New System.Windows.Forms.PictureBox()
        Me.imag2 = New System.Windows.Forms.PictureBox()
        Me.imag1 = New System.Windows.Forms.PictureBox()
        Me.imag0 = New System.Windows.Forms.PictureBox()
        Me.port1 = New System.Windows.Forms.PictureBox()
        Me.port3 = New System.Windows.Forms.PictureBox()
        Me.port2 = New System.Windows.Forms.PictureBox()
        Me.port4 = New System.Windows.Forms.PictureBox()
        Me.port5 = New System.Windows.Forms.PictureBox()
        Me.port6 = New System.Windows.Forms.PictureBox()
        Me.port7 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        CType(Me.port0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imag7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imag6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imag5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imag4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imag3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imag2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imag1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imag0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.port1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.port3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.port2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.port4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.port5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.port6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.port7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(567, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Iniciar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(567, 41)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Reiniciar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(567, 70)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Cancelar"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(567, 99)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 11
        Me.Button4.Text = "Salir"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'port0
        '
        Me.port0.Enabled = False
        Me.port0.Image = Global.JuegoMemoria.My.Resources.Resources.portada
        Me.port0.Location = New System.Drawing.Point(12, 12)
        Me.port0.Name = "port0"
        Me.port0.Size = New System.Drawing.Size(125, 175)
        Me.port0.TabIndex = 12
        Me.port0.TabStop = False
        '
        'imag7
        '
        Me.imag7.Location = New System.Drawing.Point(405, 193)
        Me.imag7.Name = "imag7"
        Me.imag7.Size = New System.Drawing.Size(125, 175)
        Me.imag7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imag7.TabIndex = 7
        Me.imag7.TabStop = False
        '
        'imag6
        '
        Me.imag6.Location = New System.Drawing.Point(274, 193)
        Me.imag6.Name = "imag6"
        Me.imag6.Size = New System.Drawing.Size(125, 175)
        Me.imag6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imag6.TabIndex = 6
        Me.imag6.TabStop = False
        '
        'imag5
        '
        Me.imag5.Location = New System.Drawing.Point(143, 193)
        Me.imag5.Name = "imag5"
        Me.imag5.Size = New System.Drawing.Size(125, 175)
        Me.imag5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imag5.TabIndex = 5
        Me.imag5.TabStop = False
        '
        'imag4
        '
        Me.imag4.Location = New System.Drawing.Point(12, 193)
        Me.imag4.Name = "imag4"
        Me.imag4.Size = New System.Drawing.Size(125, 175)
        Me.imag4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imag4.TabIndex = 4
        Me.imag4.TabStop = False
        '
        'imag3
        '
        Me.imag3.Location = New System.Drawing.Point(405, 12)
        Me.imag3.Name = "imag3"
        Me.imag3.Size = New System.Drawing.Size(125, 175)
        Me.imag3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imag3.TabIndex = 3
        Me.imag3.TabStop = False
        '
        'imag2
        '
        Me.imag2.Location = New System.Drawing.Point(274, 12)
        Me.imag2.Name = "imag2"
        Me.imag2.Size = New System.Drawing.Size(125, 175)
        Me.imag2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imag2.TabIndex = 2
        Me.imag2.TabStop = False
        '
        'imag1
        '
        Me.imag1.Location = New System.Drawing.Point(143, 12)
        Me.imag1.Name = "imag1"
        Me.imag1.Size = New System.Drawing.Size(125, 175)
        Me.imag1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imag1.TabIndex = 1
        Me.imag1.TabStop = False
        '
        'imag0
        '
        Me.imag0.Location = New System.Drawing.Point(12, 12)
        Me.imag0.Name = "imag0"
        Me.imag0.Size = New System.Drawing.Size(125, 175)
        Me.imag0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imag0.TabIndex = 0
        Me.imag0.TabStop = False
        '
        'port1
        '
        Me.port1.Enabled = False
        Me.port1.Image = Global.JuegoMemoria.My.Resources.Resources.portada
        Me.port1.Location = New System.Drawing.Point(143, 9)
        Me.port1.Name = "port1"
        Me.port1.Size = New System.Drawing.Size(125, 178)
        Me.port1.TabIndex = 13
        Me.port1.TabStop = False
        '
        'port3
        '
        Me.port3.Enabled = False
        Me.port3.Image = Global.JuegoMemoria.My.Resources.Resources.portada
        Me.port3.Location = New System.Drawing.Point(405, 12)
        Me.port3.Name = "port3"
        Me.port3.Size = New System.Drawing.Size(125, 175)
        Me.port3.TabIndex = 14
        Me.port3.TabStop = False
        '
        'port2
        '
        Me.port2.Enabled = False
        Me.port2.Image = Global.JuegoMemoria.My.Resources.Resources.portada
        Me.port2.Location = New System.Drawing.Point(274, 9)
        Me.port2.Name = "port2"
        Me.port2.Size = New System.Drawing.Size(125, 178)
        Me.port2.TabIndex = 15
        Me.port2.TabStop = False
        '
        'port4
        '
        Me.port4.Enabled = False
        Me.port4.Image = Global.JuegoMemoria.My.Resources.Resources.portada
        Me.port4.Location = New System.Drawing.Point(12, 193)
        Me.port4.Name = "port4"
        Me.port4.Size = New System.Drawing.Size(125, 178)
        Me.port4.TabIndex = 16
        Me.port4.TabStop = False
        '
        'port5
        '
        Me.port5.Enabled = False
        Me.port5.Image = Global.JuegoMemoria.My.Resources.Resources.portada
        Me.port5.Location = New System.Drawing.Point(143, 193)
        Me.port5.Name = "port5"
        Me.port5.Size = New System.Drawing.Size(125, 178)
        Me.port5.TabIndex = 17
        Me.port5.TabStop = False
        '
        'port6
        '
        Me.port6.Enabled = False
        Me.port6.Image = Global.JuegoMemoria.My.Resources.Resources.portada
        Me.port6.Location = New System.Drawing.Point(274, 193)
        Me.port6.Name = "port6"
        Me.port6.Size = New System.Drawing.Size(125, 178)
        Me.port6.TabIndex = 18
        Me.port6.TabStop = False
        '
        'port7
        '
        Me.port7.Enabled = False
        Me.port7.Image = Global.JuegoMemoria.My.Resources.Resources.portada
        Me.port7.Location = New System.Drawing.Point(405, 193)
        Me.port7.Name = "port7"
        Me.port7.Size = New System.Drawing.Size(125, 178)
        Me.port7.TabIndex = 19
        Me.port7.TabStop = False
        '
        'Timer1
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(615, 134)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(10, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = " "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(564, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Tiempo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(564, 159)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Aciertos:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(618, 159)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(10, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = " "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(564, 184)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Fallos:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(602, 184)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(10, 13)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = " "
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(564, 233)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(36, 30)
        Me.ListBox1.TabIndex = 26
        Me.ListBox1.Visible = False
        '
        'Juego
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(654, 411)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.port7)
        Me.Controls.Add(Me.port6)
        Me.Controls.Add(Me.port5)
        Me.Controls.Add(Me.port4)
        Me.Controls.Add(Me.port2)
        Me.Controls.Add(Me.port3)
        Me.Controls.Add(Me.port1)
        Me.Controls.Add(Me.port0)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.imag7)
        Me.Controls.Add(Me.imag6)
        Me.Controls.Add(Me.imag5)
        Me.Controls.Add(Me.imag4)
        Me.Controls.Add(Me.imag3)
        Me.Controls.Add(Me.imag2)
        Me.Controls.Add(Me.imag1)
        Me.Controls.Add(Me.imag0)
        Me.Name = "Juego"
        Me.Text = "Juego"
        CType(Me.port0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imag7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imag6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imag5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imag4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imag3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imag2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imag1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imag0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.port1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.port3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.port2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.port4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.port5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.port6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.port7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents imag0 As System.Windows.Forms.PictureBox
    Friend WithEvents imag1 As System.Windows.Forms.PictureBox
    Friend WithEvents imag2 As System.Windows.Forms.PictureBox
    Friend WithEvents imag3 As System.Windows.Forms.PictureBox
    Friend WithEvents imag4 As System.Windows.Forms.PictureBox
    Friend WithEvents imag5 As System.Windows.Forms.PictureBox
    Friend WithEvents imag6 As System.Windows.Forms.PictureBox
    Friend WithEvents imag7 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents port0 As System.Windows.Forms.PictureBox
    Friend WithEvents port1 As System.Windows.Forms.PictureBox
    Friend WithEvents port3 As System.Windows.Forms.PictureBox
    Friend WithEvents port2 As System.Windows.Forms.PictureBox
    Friend WithEvents port4 As System.Windows.Forms.PictureBox
    Friend WithEvents port5 As System.Windows.Forms.PictureBox
    Friend WithEvents port6 As System.Windows.Forms.PictureBox
    Friend WithEvents port7 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
End Class
