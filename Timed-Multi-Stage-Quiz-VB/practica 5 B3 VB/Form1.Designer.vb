<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.gbrespuesta1 = New System.Windows.Forms.GroupBox()
        Me.lblincorrecta1_3 = New System.Windows.Forms.Label()
        Me.lblincorrecta1_2 = New System.Windows.Forms.Label()
        Me.lblcorrecta1_1 = New System.Windows.Forms.Label()
        Me.rbr1_3 = New System.Windows.Forms.RadioButton()
        Me.rbr1_2 = New System.Windows.Forms.RadioButton()
        Me.rbr1_1 = New System.Windows.Forms.RadioButton()
        Me.gbrespuesta2 = New System.Windows.Forms.GroupBox()
        Me.lblcorrecta2_3 = New System.Windows.Forms.Label()
        Me.lblincorrecta2_2 = New System.Windows.Forms.Label()
        Me.lblincorrecta2_1 = New System.Windows.Forms.Label()
        Me.rbr2_3 = New System.Windows.Forms.RadioButton()
        Me.rbr2_2 = New System.Windows.Forms.RadioButton()
        Me.rbr2_1 = New System.Windows.Forms.RadioButton()
        Me.gbrespuesta3 = New System.Windows.Forms.GroupBox()
        Me.lblincorrecta3_3 = New System.Windows.Forms.Label()
        Me.lblcorrecta3_2 = New System.Windows.Forms.Label()
        Me.lblincorrecta3_1 = New System.Windows.Forms.Label()
        Me.rbr3_3 = New System.Windows.Forms.RadioButton()
        Me.rbr3_2 = New System.Windows.Forms.RadioButton()
        Me.rbr3_1 = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btsiguiente1 = New System.Windows.Forms.Button()
        Me.tiempo1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.gbrespuesta1.SuspendLayout()
        Me.gbrespuesta2.SuspendLayout()
        Me.gbrespuesta3.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbrespuesta1
        '
        Me.gbrespuesta1.Controls.Add(Me.lblincorrecta1_3)
        Me.gbrespuesta1.Controls.Add(Me.lblincorrecta1_2)
        Me.gbrespuesta1.Controls.Add(Me.lblcorrecta1_1)
        Me.gbrespuesta1.Controls.Add(Me.rbr1_3)
        Me.gbrespuesta1.Controls.Add(Me.rbr1_2)
        Me.gbrespuesta1.Controls.Add(Me.rbr1_1)
        Me.gbrespuesta1.Location = New System.Drawing.Point(721, 12)
        Me.gbrespuesta1.Name = "gbrespuesta1"
        Me.gbrespuesta1.Size = New System.Drawing.Size(117, 98)
        Me.gbrespuesta1.TabIndex = 0
        Me.gbrespuesta1.TabStop = False
        Me.gbrespuesta1.Text = "Respuestas 1"
        '
        'lblincorrecta1_3
        '
        Me.lblincorrecta1_3.AutoSize = True
        Me.lblincorrecta1_3.Location = New System.Drawing.Point(59, 67)
        Me.lblincorrecta1_3.Name = "lblincorrecta1_3"
        Me.lblincorrecta1_3.Size = New System.Drawing.Size(55, 13)
        Me.lblincorrecta1_3.TabIndex = 5
        Me.lblincorrecta1_3.Text = "Incorrecta"
        Me.lblincorrecta1_3.Visible = False
        '
        'lblincorrecta1_2
        '
        Me.lblincorrecta1_2.AutoSize = True
        Me.lblincorrecta1_2.Location = New System.Drawing.Point(59, 44)
        Me.lblincorrecta1_2.Name = "lblincorrecta1_2"
        Me.lblincorrecta1_2.Size = New System.Drawing.Size(55, 13)
        Me.lblincorrecta1_2.TabIndex = 4
        Me.lblincorrecta1_2.Text = "Incorrecta"
        Me.lblincorrecta1_2.Visible = False
        '
        'lblcorrecta1_1
        '
        Me.lblcorrecta1_1.AutoSize = True
        Me.lblcorrecta1_1.Location = New System.Drawing.Point(59, 21)
        Me.lblcorrecta1_1.Name = "lblcorrecta1_1"
        Me.lblcorrecta1_1.Size = New System.Drawing.Size(47, 13)
        Me.lblcorrecta1_1.TabIndex = 3
        Me.lblcorrecta1_1.Text = "Correcta"
        Me.lblcorrecta1_1.Visible = False
        '
        'rbr1_3
        '
        Me.rbr1_3.AutoSize = True
        Me.rbr1_3.Checked = True
        Me.rbr1_3.Location = New System.Drawing.Point(6, 65)
        Me.rbr1_3.Name = "rbr1_3"
        Me.rbr1_3.Size = New System.Drawing.Size(51, 17)
        Me.rbr1_3.TabIndex = 2
        Me.rbr1_3.TabStop = True
        Me.rbr1_3.Text = "R1_3"
        Me.rbr1_3.UseVisualStyleBackColor = True
        '
        'rbr1_2
        '
        Me.rbr1_2.AutoSize = True
        Me.rbr1_2.Location = New System.Drawing.Point(6, 42)
        Me.rbr1_2.Name = "rbr1_2"
        Me.rbr1_2.Size = New System.Drawing.Size(51, 17)
        Me.rbr1_2.TabIndex = 1
        Me.rbr1_2.Text = "R1_2"
        Me.rbr1_2.UseVisualStyleBackColor = True
        '
        'rbr1_1
        '
        Me.rbr1_1.AutoSize = True
        Me.rbr1_1.Location = New System.Drawing.Point(6, 19)
        Me.rbr1_1.Name = "rbr1_1"
        Me.rbr1_1.Size = New System.Drawing.Size(51, 17)
        Me.rbr1_1.TabIndex = 0
        Me.rbr1_1.Text = "R1_1"
        Me.rbr1_1.UseVisualStyleBackColor = True
        '
        'gbrespuesta2
        '
        Me.gbrespuesta2.Controls.Add(Me.lblcorrecta2_3)
        Me.gbrespuesta2.Controls.Add(Me.lblincorrecta2_2)
        Me.gbrespuesta2.Controls.Add(Me.lblincorrecta2_1)
        Me.gbrespuesta2.Controls.Add(Me.rbr2_3)
        Me.gbrespuesta2.Controls.Add(Me.rbr2_2)
        Me.gbrespuesta2.Controls.Add(Me.rbr2_1)
        Me.gbrespuesta2.Location = New System.Drawing.Point(721, 116)
        Me.gbrespuesta2.Name = "gbrespuesta2"
        Me.gbrespuesta2.Size = New System.Drawing.Size(117, 98)
        Me.gbrespuesta2.TabIndex = 1
        Me.gbrespuesta2.TabStop = False
        Me.gbrespuesta2.Text = "Respuestas 2"
        '
        'lblcorrecta2_3
        '
        Me.lblcorrecta2_3.AutoSize = True
        Me.lblcorrecta2_3.Location = New System.Drawing.Point(59, 67)
        Me.lblcorrecta2_3.Name = "lblcorrecta2_3"
        Me.lblcorrecta2_3.Size = New System.Drawing.Size(47, 13)
        Me.lblcorrecta2_3.TabIndex = 5
        Me.lblcorrecta2_3.Text = "Correcta"
        Me.lblcorrecta2_3.Visible = False
        '
        'lblincorrecta2_2
        '
        Me.lblincorrecta2_2.AutoSize = True
        Me.lblincorrecta2_2.Location = New System.Drawing.Point(59, 44)
        Me.lblincorrecta2_2.Name = "lblincorrecta2_2"
        Me.lblincorrecta2_2.Size = New System.Drawing.Size(55, 13)
        Me.lblincorrecta2_2.TabIndex = 4
        Me.lblincorrecta2_2.Text = "Incorrecta"
        Me.lblincorrecta2_2.Visible = False
        '
        'lblincorrecta2_1
        '
        Me.lblincorrecta2_1.AutoSize = True
        Me.lblincorrecta2_1.Location = New System.Drawing.Point(59, 21)
        Me.lblincorrecta2_1.Name = "lblincorrecta2_1"
        Me.lblincorrecta2_1.Size = New System.Drawing.Size(55, 13)
        Me.lblincorrecta2_1.TabIndex = 3
        Me.lblincorrecta2_1.Text = "Incorrecta"
        Me.lblincorrecta2_1.Visible = False
        '
        'rbr2_3
        '
        Me.rbr2_3.AutoSize = True
        Me.rbr2_3.Checked = True
        Me.rbr2_3.Location = New System.Drawing.Point(6, 65)
        Me.rbr2_3.Name = "rbr2_3"
        Me.rbr2_3.Size = New System.Drawing.Size(51, 17)
        Me.rbr2_3.TabIndex = 2
        Me.rbr2_3.TabStop = True
        Me.rbr2_3.Text = "R2_3"
        Me.rbr2_3.UseVisualStyleBackColor = True
        '
        'rbr2_2
        '
        Me.rbr2_2.AutoSize = True
        Me.rbr2_2.Location = New System.Drawing.Point(6, 42)
        Me.rbr2_2.Name = "rbr2_2"
        Me.rbr2_2.Size = New System.Drawing.Size(51, 17)
        Me.rbr2_2.TabIndex = 1
        Me.rbr2_2.Text = "R2_2"
        Me.rbr2_2.UseVisualStyleBackColor = True
        '
        'rbr2_1
        '
        Me.rbr2_1.AutoSize = True
        Me.rbr2_1.Location = New System.Drawing.Point(6, 19)
        Me.rbr2_1.Name = "rbr2_1"
        Me.rbr2_1.Size = New System.Drawing.Size(51, 17)
        Me.rbr2_1.TabIndex = 0
        Me.rbr2_1.Text = "R2_1"
        Me.rbr2_1.UseVisualStyleBackColor = True
        '
        'gbrespuesta3
        '
        Me.gbrespuesta3.Controls.Add(Me.lblincorrecta3_3)
        Me.gbrespuesta3.Controls.Add(Me.lblcorrecta3_2)
        Me.gbrespuesta3.Controls.Add(Me.lblincorrecta3_1)
        Me.gbrespuesta3.Controls.Add(Me.rbr3_3)
        Me.gbrespuesta3.Controls.Add(Me.rbr3_2)
        Me.gbrespuesta3.Controls.Add(Me.rbr3_1)
        Me.gbrespuesta3.Location = New System.Drawing.Point(721, 220)
        Me.gbrespuesta3.Name = "gbrespuesta3"
        Me.gbrespuesta3.Size = New System.Drawing.Size(117, 98)
        Me.gbrespuesta3.TabIndex = 2
        Me.gbrespuesta3.TabStop = False
        Me.gbrespuesta3.Text = "Respuestas 3"
        '
        'lblincorrecta3_3
        '
        Me.lblincorrecta3_3.AutoSize = True
        Me.lblincorrecta3_3.Location = New System.Drawing.Point(59, 67)
        Me.lblincorrecta3_3.Name = "lblincorrecta3_3"
        Me.lblincorrecta3_3.Size = New System.Drawing.Size(55, 13)
        Me.lblincorrecta3_3.TabIndex = 5
        Me.lblincorrecta3_3.Text = "Incorrecta"
        Me.lblincorrecta3_3.Visible = False
        '
        'lblcorrecta3_2
        '
        Me.lblcorrecta3_2.AutoSize = True
        Me.lblcorrecta3_2.Location = New System.Drawing.Point(59, 44)
        Me.lblcorrecta3_2.Name = "lblcorrecta3_2"
        Me.lblcorrecta3_2.Size = New System.Drawing.Size(47, 13)
        Me.lblcorrecta3_2.TabIndex = 4
        Me.lblcorrecta3_2.Text = "Correcta"
        Me.lblcorrecta3_2.Visible = False
        '
        'lblincorrecta3_1
        '
        Me.lblincorrecta3_1.AutoSize = True
        Me.lblincorrecta3_1.Location = New System.Drawing.Point(59, 21)
        Me.lblincorrecta3_1.Name = "lblincorrecta3_1"
        Me.lblincorrecta3_1.Size = New System.Drawing.Size(55, 13)
        Me.lblincorrecta3_1.TabIndex = 3
        Me.lblincorrecta3_1.Text = "Incorrecta"
        Me.lblincorrecta3_1.Visible = False
        '
        'rbr3_3
        '
        Me.rbr3_3.AutoSize = True
        Me.rbr3_3.Checked = True
        Me.rbr3_3.Location = New System.Drawing.Point(6, 65)
        Me.rbr3_3.Name = "rbr3_3"
        Me.rbr3_3.Size = New System.Drawing.Size(51, 17)
        Me.rbr3_3.TabIndex = 2
        Me.rbr3_3.TabStop = True
        Me.rbr3_3.Text = "R3_3"
        Me.rbr3_3.UseVisualStyleBackColor = True
        '
        'rbr3_2
        '
        Me.rbr3_2.AutoSize = True
        Me.rbr3_2.Location = New System.Drawing.Point(6, 42)
        Me.rbr3_2.Name = "rbr3_2"
        Me.rbr3_2.Size = New System.Drawing.Size(51, 17)
        Me.rbr3_2.TabIndex = 1
        Me.rbr3_2.Text = "R3_2"
        Me.rbr3_2.UseVisualStyleBackColor = True
        '
        'rbr3_1
        '
        Me.rbr3_1.AutoSize = True
        Me.rbr3_1.Location = New System.Drawing.Point(6, 19)
        Me.rbr3_1.Name = "rbr3_1"
        Me.rbr3_1.Size = New System.Drawing.Size(51, 17)
        Me.rbr3_1.TabIndex = 0
        Me.rbr3_1.Text = "R3_1"
        Me.rbr3_1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "1. Pregunta 1 "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "2. Pregunta 2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 220)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "3. Pregunta 3"
        '
        'btsiguiente1
        '
        Me.btsiguiente1.Location = New System.Drawing.Point(744, 338)
        Me.btsiguiente1.Name = "btsiguiente1"
        Me.btsiguiente1.Size = New System.Drawing.Size(75, 23)
        Me.btsiguiente1.TabIndex = 6
        Me.btsiguiente1.Text = "Siguiente"
        Me.btsiguiente1.UseVisualStyleBackColor = True
        Me.btsiguiente1.Visible = False
        '
        'tiempo1
        '
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(563, 348)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Label4"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(608, 348)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Segundos"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(435, 348)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(122, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Tiempo para responder: "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(876, 388)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btsiguiente1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.gbrespuesta3)
        Me.Controls.Add(Me.gbrespuesta2)
        Me.Controls.Add(Me.gbrespuesta1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.gbrespuesta1.ResumeLayout(False)
        Me.gbrespuesta1.PerformLayout()
        Me.gbrespuesta2.ResumeLayout(False)
        Me.gbrespuesta2.PerformLayout()
        Me.gbrespuesta3.ResumeLayout(False)
        Me.gbrespuesta3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbrespuesta1 As System.Windows.Forms.GroupBox
    Friend WithEvents gbrespuesta2 As System.Windows.Forms.GroupBox
    Friend WithEvents gbrespuesta3 As System.Windows.Forms.GroupBox
    Friend WithEvents rbr1_3 As System.Windows.Forms.RadioButton
    Friend WithEvents rbr1_2 As System.Windows.Forms.RadioButton
    Friend WithEvents rbr1_1 As System.Windows.Forms.RadioButton
    Friend WithEvents rbr2_3 As System.Windows.Forms.RadioButton
    Friend WithEvents rbr2_2 As System.Windows.Forms.RadioButton
    Friend WithEvents rbr2_1 As System.Windows.Forms.RadioButton
    Friend WithEvents rbr3_3 As System.Windows.Forms.RadioButton
    Friend WithEvents rbr3_2 As System.Windows.Forms.RadioButton
    Friend WithEvents rbr3_1 As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btsiguiente1 As System.Windows.Forms.Button
    Friend WithEvents lblincorrecta1_3 As System.Windows.Forms.Label
    Friend WithEvents lblincorrecta1_2 As System.Windows.Forms.Label
    Friend WithEvents lblcorrecta1_1 As System.Windows.Forms.Label
    Friend WithEvents lblcorrecta2_3 As System.Windows.Forms.Label
    Friend WithEvents lblincorrecta2_2 As System.Windows.Forms.Label
    Friend WithEvents lblincorrecta2_1 As System.Windows.Forms.Label
    Friend WithEvents lblincorrecta3_3 As System.Windows.Forms.Label
    Friend WithEvents lblcorrecta3_2 As System.Windows.Forms.Label
    Friend WithEvents lblincorrecta3_1 As System.Windows.Forms.Label
    Friend WithEvents tiempo1 As System.Windows.Forms.Timer
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label

End Class
