<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gbrespuesta4 = New System.Windows.Forms.GroupBox()
        Me.lblincorrecta4_3 = New System.Windows.Forms.Label()
        Me.lblcorrecta4_2 = New System.Windows.Forms.Label()
        Me.lblincorrecta4_1 = New System.Windows.Forms.Label()
        Me.rbr4_3 = New System.Windows.Forms.RadioButton()
        Me.rbr4_2 = New System.Windows.Forms.RadioButton()
        Me.rbr4_1 = New System.Windows.Forms.RadioButton()
        Me.gbrespuesta5 = New System.Windows.Forms.GroupBox()
        Me.lblincorrecta5_3 = New System.Windows.Forms.Label()
        Me.lblincorrecta5_2 = New System.Windows.Forms.Label()
        Me.lblcorrecta5_1 = New System.Windows.Forms.Label()
        Me.rbr5_3 = New System.Windows.Forms.RadioButton()
        Me.rbr5_2 = New System.Windows.Forms.RadioButton()
        Me.rbr5_1 = New System.Windows.Forms.RadioButton()
        Me.gbrespuesta6 = New System.Windows.Forms.GroupBox()
        Me.lblincorrecta6_3 = New System.Windows.Forms.Label()
        Me.lblcorrecta6_2 = New System.Windows.Forms.Label()
        Me.lblincorrecta6_1 = New System.Windows.Forms.Label()
        Me.rbr6_3 = New System.Windows.Forms.RadioButton()
        Me.rbr6_2 = New System.Windows.Forms.RadioButton()
        Me.rbr6_1 = New System.Windows.Forms.RadioButton()
        Me.btsiguiente2 = New System.Windows.Forms.Button()
        Me.tiempo2 = New System.Windows.Forms.Timer(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.gbrespuesta4.SuspendLayout()
        Me.gbrespuesta5.SuspendLayout()
        Me.gbrespuesta6.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "4. Pregunta 4"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "5. Pregunta 5"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 202)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "6. Pregunta 6"
        '
        'gbrespuesta4
        '
        Me.gbrespuesta4.Controls.Add(Me.lblincorrecta4_3)
        Me.gbrespuesta4.Controls.Add(Me.lblcorrecta4_2)
        Me.gbrespuesta4.Controls.Add(Me.lblincorrecta4_1)
        Me.gbrespuesta4.Controls.Add(Me.rbr4_3)
        Me.gbrespuesta4.Controls.Add(Me.rbr4_2)
        Me.gbrespuesta4.Controls.Add(Me.rbr4_1)
        Me.gbrespuesta4.Location = New System.Drawing.Point(728, 12)
        Me.gbrespuesta4.Name = "gbrespuesta4"
        Me.gbrespuesta4.Size = New System.Drawing.Size(121, 88)
        Me.gbrespuesta4.TabIndex = 3
        Me.gbrespuesta4.TabStop = False
        Me.gbrespuesta4.Text = "Respuestas 4"
        '
        'lblincorrecta4_3
        '
        Me.lblincorrecta4_3.AutoSize = True
        Me.lblincorrecta4_3.Location = New System.Drawing.Point(63, 67)
        Me.lblincorrecta4_3.Name = "lblincorrecta4_3"
        Me.lblincorrecta4_3.Size = New System.Drawing.Size(55, 13)
        Me.lblincorrecta4_3.TabIndex = 5
        Me.lblincorrecta4_3.Text = "Incorrecta"
        Me.lblincorrecta4_3.Visible = False
        '
        'lblcorrecta4_2
        '
        Me.lblcorrecta4_2.AutoSize = True
        Me.lblcorrecta4_2.Location = New System.Drawing.Point(63, 44)
        Me.lblcorrecta4_2.Name = "lblcorrecta4_2"
        Me.lblcorrecta4_2.Size = New System.Drawing.Size(47, 13)
        Me.lblcorrecta4_2.TabIndex = 4
        Me.lblcorrecta4_2.Text = "Correcta"
        Me.lblcorrecta4_2.Visible = False
        '
        'lblincorrecta4_1
        '
        Me.lblincorrecta4_1.AutoSize = True
        Me.lblincorrecta4_1.Location = New System.Drawing.Point(63, 21)
        Me.lblincorrecta4_1.Name = "lblincorrecta4_1"
        Me.lblincorrecta4_1.Size = New System.Drawing.Size(55, 13)
        Me.lblincorrecta4_1.TabIndex = 3
        Me.lblincorrecta4_1.Text = "Incorrecta"
        Me.lblincorrecta4_1.Visible = False
        '
        'rbr4_3
        '
        Me.rbr4_3.AutoSize = True
        Me.rbr4_3.Checked = True
        Me.rbr4_3.Location = New System.Drawing.Point(6, 65)
        Me.rbr4_3.Name = "rbr4_3"
        Me.rbr4_3.Size = New System.Drawing.Size(51, 17)
        Me.rbr4_3.TabIndex = 2
        Me.rbr4_3.TabStop = True
        Me.rbr4_3.Text = "R4_3"
        Me.rbr4_3.UseVisualStyleBackColor = True
        '
        'rbr4_2
        '
        Me.rbr4_2.AutoSize = True
        Me.rbr4_2.Location = New System.Drawing.Point(6, 42)
        Me.rbr4_2.Name = "rbr4_2"
        Me.rbr4_2.Size = New System.Drawing.Size(51, 17)
        Me.rbr4_2.TabIndex = 1
        Me.rbr4_2.Text = "R4_2"
        Me.rbr4_2.UseVisualStyleBackColor = True
        '
        'rbr4_1
        '
        Me.rbr4_1.AutoSize = True
        Me.rbr4_1.Location = New System.Drawing.Point(6, 19)
        Me.rbr4_1.Name = "rbr4_1"
        Me.rbr4_1.Size = New System.Drawing.Size(51, 17)
        Me.rbr4_1.TabIndex = 0
        Me.rbr4_1.Text = "R4_1"
        Me.rbr4_1.UseVisualStyleBackColor = True
        '
        'gbrespuesta5
        '
        Me.gbrespuesta5.Controls.Add(Me.lblincorrecta5_3)
        Me.gbrespuesta5.Controls.Add(Me.lblincorrecta5_2)
        Me.gbrespuesta5.Controls.Add(Me.lblcorrecta5_1)
        Me.gbrespuesta5.Controls.Add(Me.rbr5_3)
        Me.gbrespuesta5.Controls.Add(Me.rbr5_2)
        Me.gbrespuesta5.Controls.Add(Me.rbr5_1)
        Me.gbrespuesta5.Location = New System.Drawing.Point(728, 106)
        Me.gbrespuesta5.Name = "gbrespuesta5"
        Me.gbrespuesta5.Size = New System.Drawing.Size(121, 90)
        Me.gbrespuesta5.TabIndex = 4
        Me.gbrespuesta5.TabStop = False
        Me.gbrespuesta5.Text = "Respuestas 5"
        '
        'lblincorrecta5_3
        '
        Me.lblincorrecta5_3.AutoSize = True
        Me.lblincorrecta5_3.Location = New System.Drawing.Point(63, 67)
        Me.lblincorrecta5_3.Name = "lblincorrecta5_3"
        Me.lblincorrecta5_3.Size = New System.Drawing.Size(55, 13)
        Me.lblincorrecta5_3.TabIndex = 5
        Me.lblincorrecta5_3.Text = "Incorrecta"
        Me.lblincorrecta5_3.Visible = False
        '
        'lblincorrecta5_2
        '
        Me.lblincorrecta5_2.AutoSize = True
        Me.lblincorrecta5_2.Location = New System.Drawing.Point(63, 44)
        Me.lblincorrecta5_2.Name = "lblincorrecta5_2"
        Me.lblincorrecta5_2.Size = New System.Drawing.Size(55, 13)
        Me.lblincorrecta5_2.TabIndex = 4
        Me.lblincorrecta5_2.Text = "Incorrecta"
        Me.lblincorrecta5_2.Visible = False
        '
        'lblcorrecta5_1
        '
        Me.lblcorrecta5_1.AutoSize = True
        Me.lblcorrecta5_1.Location = New System.Drawing.Point(63, 21)
        Me.lblcorrecta5_1.Name = "lblcorrecta5_1"
        Me.lblcorrecta5_1.Size = New System.Drawing.Size(47, 13)
        Me.lblcorrecta5_1.TabIndex = 3
        Me.lblcorrecta5_1.Text = "Correcta"
        Me.lblcorrecta5_1.Visible = False
        '
        'rbr5_3
        '
        Me.rbr5_3.AutoSize = True
        Me.rbr5_3.Checked = True
        Me.rbr5_3.Location = New System.Drawing.Point(6, 65)
        Me.rbr5_3.Name = "rbr5_3"
        Me.rbr5_3.Size = New System.Drawing.Size(51, 17)
        Me.rbr5_3.TabIndex = 2
        Me.rbr5_3.TabStop = True
        Me.rbr5_3.Text = "R5_3"
        Me.rbr5_3.UseVisualStyleBackColor = True
        '
        'rbr5_2
        '
        Me.rbr5_2.AutoSize = True
        Me.rbr5_2.Location = New System.Drawing.Point(6, 42)
        Me.rbr5_2.Name = "rbr5_2"
        Me.rbr5_2.Size = New System.Drawing.Size(51, 17)
        Me.rbr5_2.TabIndex = 1
        Me.rbr5_2.Text = "R5_2"
        Me.rbr5_2.UseVisualStyleBackColor = True
        '
        'rbr5_1
        '
        Me.rbr5_1.AutoSize = True
        Me.rbr5_1.Location = New System.Drawing.Point(6, 19)
        Me.rbr5_1.Name = "rbr5_1"
        Me.rbr5_1.Size = New System.Drawing.Size(51, 17)
        Me.rbr5_1.TabIndex = 0
        Me.rbr5_1.Text = "R5_1"
        Me.rbr5_1.UseVisualStyleBackColor = True
        '
        'gbrespuesta6
        '
        Me.gbrespuesta6.Controls.Add(Me.lblincorrecta6_3)
        Me.gbrespuesta6.Controls.Add(Me.lblcorrecta6_2)
        Me.gbrespuesta6.Controls.Add(Me.lblincorrecta6_1)
        Me.gbrespuesta6.Controls.Add(Me.rbr6_3)
        Me.gbrespuesta6.Controls.Add(Me.rbr6_2)
        Me.gbrespuesta6.Controls.Add(Me.rbr6_1)
        Me.gbrespuesta6.Location = New System.Drawing.Point(728, 202)
        Me.gbrespuesta6.Name = "gbrespuesta6"
        Me.gbrespuesta6.Size = New System.Drawing.Size(121, 86)
        Me.gbrespuesta6.TabIndex = 5
        Me.gbrespuesta6.TabStop = False
        Me.gbrespuesta6.Text = "Respuestas 6"
        '
        'lblincorrecta6_3
        '
        Me.lblincorrecta6_3.AutoSize = True
        Me.lblincorrecta6_3.Location = New System.Drawing.Point(63, 63)
        Me.lblincorrecta6_3.Name = "lblincorrecta6_3"
        Me.lblincorrecta6_3.Size = New System.Drawing.Size(55, 13)
        Me.lblincorrecta6_3.TabIndex = 5
        Me.lblincorrecta6_3.Text = "Incorrecta"
        Me.lblincorrecta6_3.Visible = False
        '
        'lblcorrecta6_2
        '
        Me.lblcorrecta6_2.AutoSize = True
        Me.lblcorrecta6_2.Location = New System.Drawing.Point(63, 40)
        Me.lblcorrecta6_2.Name = "lblcorrecta6_2"
        Me.lblcorrecta6_2.Size = New System.Drawing.Size(47, 13)
        Me.lblcorrecta6_2.TabIndex = 4
        Me.lblcorrecta6_2.Text = "Correcta"
        Me.lblcorrecta6_2.Visible = False
        '
        'lblincorrecta6_1
        '
        Me.lblincorrecta6_1.AutoSize = True
        Me.lblincorrecta6_1.Location = New System.Drawing.Point(63, 17)
        Me.lblincorrecta6_1.Name = "lblincorrecta6_1"
        Me.lblincorrecta6_1.Size = New System.Drawing.Size(55, 13)
        Me.lblincorrecta6_1.TabIndex = 3
        Me.lblincorrecta6_1.Text = "Incorrecta"
        Me.lblincorrecta6_1.Visible = False
        '
        'rbr6_3
        '
        Me.rbr6_3.AutoSize = True
        Me.rbr6_3.Checked = True
        Me.rbr6_3.Location = New System.Drawing.Point(6, 61)
        Me.rbr6_3.Name = "rbr6_3"
        Me.rbr6_3.Size = New System.Drawing.Size(51, 17)
        Me.rbr6_3.TabIndex = 2
        Me.rbr6_3.TabStop = True
        Me.rbr6_3.Text = "R6_3"
        Me.rbr6_3.UseVisualStyleBackColor = True
        '
        'rbr6_2
        '
        Me.rbr6_2.AutoSize = True
        Me.rbr6_2.Location = New System.Drawing.Point(6, 38)
        Me.rbr6_2.Name = "rbr6_2"
        Me.rbr6_2.Size = New System.Drawing.Size(51, 17)
        Me.rbr6_2.TabIndex = 1
        Me.rbr6_2.Text = "R6_2"
        Me.rbr6_2.UseVisualStyleBackColor = True
        '
        'rbr6_1
        '
        Me.rbr6_1.AutoSize = True
        Me.rbr6_1.Location = New System.Drawing.Point(6, 15)
        Me.rbr6_1.Name = "rbr6_1"
        Me.rbr6_1.Size = New System.Drawing.Size(51, 17)
        Me.rbr6_1.TabIndex = 0
        Me.rbr6_1.Text = "R6_1"
        Me.rbr6_1.UseVisualStyleBackColor = True
        '
        'btsiguiente2
        '
        Me.btsiguiente2.Location = New System.Drawing.Point(742, 314)
        Me.btsiguiente2.Name = "btsiguiente2"
        Me.btsiguiente2.Size = New System.Drawing.Size(75, 23)
        Me.btsiguiente2.TabIndex = 6
        Me.btsiguiente2.Text = "Siguiente"
        Me.btsiguiente2.UseVisualStyleBackColor = True
        Me.btsiguiente2.Visible = False
        '
        'tiempo2
        '
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(547, 335)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Label4"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(592, 335)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Segundos"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(422, 335)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Tiempo para responder:"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(878, 386)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btsiguiente2)
        Me.Controls.Add(Me.gbrespuesta6)
        Me.Controls.Add(Me.gbrespuesta5)
        Me.Controls.Add(Me.gbrespuesta4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.gbrespuesta4.ResumeLayout(False)
        Me.gbrespuesta4.PerformLayout()
        Me.gbrespuesta5.ResumeLayout(False)
        Me.gbrespuesta5.PerformLayout()
        Me.gbrespuesta6.ResumeLayout(False)
        Me.gbrespuesta6.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents gbrespuesta4 As System.Windows.Forms.GroupBox
    Friend WithEvents gbrespuesta5 As System.Windows.Forms.GroupBox
    Friend WithEvents gbrespuesta6 As System.Windows.Forms.GroupBox
    Friend WithEvents rbr4_3 As System.Windows.Forms.RadioButton
    Friend WithEvents rbr4_2 As System.Windows.Forms.RadioButton
    Friend WithEvents rbr4_1 As System.Windows.Forms.RadioButton
    Friend WithEvents rbr5_3 As System.Windows.Forms.RadioButton
    Friend WithEvents rbr5_2 As System.Windows.Forms.RadioButton
    Friend WithEvents rbr5_1 As System.Windows.Forms.RadioButton
    Friend WithEvents rbr6_3 As System.Windows.Forms.RadioButton
    Friend WithEvents rbr6_2 As System.Windows.Forms.RadioButton
    Friend WithEvents rbr6_1 As System.Windows.Forms.RadioButton
    Friend WithEvents btsiguiente2 As System.Windows.Forms.Button
    Friend WithEvents lblincorrecta4_3 As System.Windows.Forms.Label
    Friend WithEvents lblcorrecta4_2 As System.Windows.Forms.Label
    Friend WithEvents lblincorrecta4_1 As System.Windows.Forms.Label
    Friend WithEvents lblincorrecta5_3 As System.Windows.Forms.Label
    Friend WithEvents lblincorrecta5_2 As System.Windows.Forms.Label
    Friend WithEvents lblcorrecta5_1 As System.Windows.Forms.Label
    Friend WithEvents lblincorrecta6_3 As System.Windows.Forms.Label
    Friend WithEvents lblcorrecta6_2 As System.Windows.Forms.Label
    Friend WithEvents lblincorrecta6_1 As System.Windows.Forms.Label
    Friend WithEvents tiempo2 As System.Windows.Forms.Timer
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
