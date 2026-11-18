<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.gbrespuesta7 = New System.Windows.Forms.GroupBox()
        Me.lblincorrecta7_3 = New System.Windows.Forms.Label()
        Me.lblincorrecta7_2 = New System.Windows.Forms.Label()
        Me.lblcorrecta7_1 = New System.Windows.Forms.Label()
        Me.rbr7_3 = New System.Windows.Forms.RadioButton()
        Me.rbr7_2 = New System.Windows.Forms.RadioButton()
        Me.rbr7_1 = New System.Windows.Forms.RadioButton()
        Me.gbrespuesta8 = New System.Windows.Forms.GroupBox()
        Me.lblincorrecta8_3 = New System.Windows.Forms.Label()
        Me.lblincorrecta8_2 = New System.Windows.Forms.Label()
        Me.lblcorrecta8_1 = New System.Windows.Forms.Label()
        Me.rbr8_3 = New System.Windows.Forms.RadioButton()
        Me.rbr8_2 = New System.Windows.Forms.RadioButton()
        Me.rbr8_1 = New System.Windows.Forms.RadioButton()
        Me.gbrespuesta9 = New System.Windows.Forms.GroupBox()
        Me.lblincorrecta9_3 = New System.Windows.Forms.Label()
        Me.lblincorrecta9_2 = New System.Windows.Forms.Label()
        Me.lblcorrecta9_1 = New System.Windows.Forms.Label()
        Me.rbr9_3 = New System.Windows.Forms.RadioButton()
        Me.rbr9_2 = New System.Windows.Forms.RadioButton()
        Me.rbr9_1 = New System.Windows.Forms.RadioButton()
        Me.btsiguiente3 = New System.Windows.Forms.Button()
        Me.tiempo3 = New System.Windows.Forms.Timer(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.gbrespuesta7.SuspendLayout()
        Me.gbrespuesta8.SuspendLayout()
        Me.gbrespuesta9.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "7. Pregunta 7"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "8. Pregunta 8"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 205)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "9. Pregunta 9"
        '
        'gbrespuesta7
        '
        Me.gbrespuesta7.Controls.Add(Me.lblincorrecta7_3)
        Me.gbrespuesta7.Controls.Add(Me.lblincorrecta7_2)
        Me.gbrespuesta7.Controls.Add(Me.lblcorrecta7_1)
        Me.gbrespuesta7.Controls.Add(Me.rbr7_3)
        Me.gbrespuesta7.Controls.Add(Me.rbr7_2)
        Me.gbrespuesta7.Controls.Add(Me.rbr7_1)
        Me.gbrespuesta7.Location = New System.Drawing.Point(737, 12)
        Me.gbrespuesta7.Name = "gbrespuesta7"
        Me.gbrespuesta7.Size = New System.Drawing.Size(122, 88)
        Me.gbrespuesta7.TabIndex = 3
        Me.gbrespuesta7.TabStop = False
        Me.gbrespuesta7.Text = "Respuestas 7"
        '
        'lblincorrecta7_3
        '
        Me.lblincorrecta7_3.AutoSize = True
        Me.lblincorrecta7_3.Location = New System.Drawing.Point(63, 65)
        Me.lblincorrecta7_3.Name = "lblincorrecta7_3"
        Me.lblincorrecta7_3.Size = New System.Drawing.Size(55, 13)
        Me.lblincorrecta7_3.TabIndex = 5
        Me.lblincorrecta7_3.Text = "Incorrecta"
        Me.lblincorrecta7_3.Visible = False
        '
        'lblincorrecta7_2
        '
        Me.lblincorrecta7_2.AutoSize = True
        Me.lblincorrecta7_2.Location = New System.Drawing.Point(63, 42)
        Me.lblincorrecta7_2.Name = "lblincorrecta7_2"
        Me.lblincorrecta7_2.Size = New System.Drawing.Size(55, 13)
        Me.lblincorrecta7_2.TabIndex = 4
        Me.lblincorrecta7_2.Text = "Incorrecta"
        Me.lblincorrecta7_2.Visible = False
        '
        'lblcorrecta7_1
        '
        Me.lblcorrecta7_1.AutoSize = True
        Me.lblcorrecta7_1.Location = New System.Drawing.Point(63, 21)
        Me.lblcorrecta7_1.Name = "lblcorrecta7_1"
        Me.lblcorrecta7_1.Size = New System.Drawing.Size(47, 13)
        Me.lblcorrecta7_1.TabIndex = 3
        Me.lblcorrecta7_1.Text = "Correcta"
        Me.lblcorrecta7_1.Visible = False
        '
        'rbr7_3
        '
        Me.rbr7_3.AutoSize = True
        Me.rbr7_3.Checked = True
        Me.rbr7_3.Location = New System.Drawing.Point(6, 63)
        Me.rbr7_3.Name = "rbr7_3"
        Me.rbr7_3.Size = New System.Drawing.Size(51, 17)
        Me.rbr7_3.TabIndex = 2
        Me.rbr7_3.TabStop = True
        Me.rbr7_3.Text = "R7_3"
        Me.rbr7_3.UseVisualStyleBackColor = True
        '
        'rbr7_2
        '
        Me.rbr7_2.AutoSize = True
        Me.rbr7_2.Location = New System.Drawing.Point(6, 40)
        Me.rbr7_2.Name = "rbr7_2"
        Me.rbr7_2.Size = New System.Drawing.Size(51, 17)
        Me.rbr7_2.TabIndex = 1
        Me.rbr7_2.Text = "R7_2"
        Me.rbr7_2.UseVisualStyleBackColor = True
        '
        'rbr7_1
        '
        Me.rbr7_1.AutoSize = True
        Me.rbr7_1.Location = New System.Drawing.Point(6, 19)
        Me.rbr7_1.Name = "rbr7_1"
        Me.rbr7_1.Size = New System.Drawing.Size(51, 17)
        Me.rbr7_1.TabIndex = 0
        Me.rbr7_1.Text = "R7_1"
        Me.rbr7_1.UseVisualStyleBackColor = True
        '
        'gbrespuesta8
        '
        Me.gbrespuesta8.Controls.Add(Me.lblincorrecta8_3)
        Me.gbrespuesta8.Controls.Add(Me.lblincorrecta8_2)
        Me.gbrespuesta8.Controls.Add(Me.lblcorrecta8_1)
        Me.gbrespuesta8.Controls.Add(Me.rbr8_3)
        Me.gbrespuesta8.Controls.Add(Me.rbr8_2)
        Me.gbrespuesta8.Controls.Add(Me.rbr8_1)
        Me.gbrespuesta8.Location = New System.Drawing.Point(737, 106)
        Me.gbrespuesta8.Name = "gbrespuesta8"
        Me.gbrespuesta8.Size = New System.Drawing.Size(122, 93)
        Me.gbrespuesta8.TabIndex = 4
        Me.gbrespuesta8.TabStop = False
        Me.gbrespuesta8.Text = "Respuestas 8"
        '
        'lblincorrecta8_3
        '
        Me.lblincorrecta8_3.AutoSize = True
        Me.lblincorrecta8_3.Location = New System.Drawing.Point(63, 69)
        Me.lblincorrecta8_3.Name = "lblincorrecta8_3"
        Me.lblincorrecta8_3.Size = New System.Drawing.Size(55, 13)
        Me.lblincorrecta8_3.TabIndex = 5
        Me.lblincorrecta8_3.Text = "Incorrecta"
        Me.lblincorrecta8_3.Visible = False
        '
        'lblincorrecta8_2
        '
        Me.lblincorrecta8_2.AutoSize = True
        Me.lblincorrecta8_2.Location = New System.Drawing.Point(63, 44)
        Me.lblincorrecta8_2.Name = "lblincorrecta8_2"
        Me.lblincorrecta8_2.Size = New System.Drawing.Size(55, 13)
        Me.lblincorrecta8_2.TabIndex = 4
        Me.lblincorrecta8_2.Text = "Incorrecta"
        Me.lblincorrecta8_2.Visible = False
        '
        'lblcorrecta8_1
        '
        Me.lblcorrecta8_1.AutoSize = True
        Me.lblcorrecta8_1.Location = New System.Drawing.Point(63, 21)
        Me.lblcorrecta8_1.Name = "lblcorrecta8_1"
        Me.lblcorrecta8_1.Size = New System.Drawing.Size(47, 13)
        Me.lblcorrecta8_1.TabIndex = 3
        Me.lblcorrecta8_1.Text = "Correcta"
        Me.lblcorrecta8_1.Visible = False
        '
        'rbr8_3
        '
        Me.rbr8_3.AutoSize = True
        Me.rbr8_3.Checked = True
        Me.rbr8_3.Location = New System.Drawing.Point(6, 67)
        Me.rbr8_3.Name = "rbr8_3"
        Me.rbr8_3.Size = New System.Drawing.Size(51, 17)
        Me.rbr8_3.TabIndex = 2
        Me.rbr8_3.TabStop = True
        Me.rbr8_3.Text = "R8_3"
        Me.rbr8_3.UseVisualStyleBackColor = True
        '
        'rbr8_2
        '
        Me.rbr8_2.AutoSize = True
        Me.rbr8_2.Location = New System.Drawing.Point(6, 42)
        Me.rbr8_2.Name = "rbr8_2"
        Me.rbr8_2.Size = New System.Drawing.Size(51, 17)
        Me.rbr8_2.TabIndex = 1
        Me.rbr8_2.Text = "R8_2"
        Me.rbr8_2.UseVisualStyleBackColor = True
        '
        'rbr8_1
        '
        Me.rbr8_1.AutoSize = True
        Me.rbr8_1.Location = New System.Drawing.Point(6, 19)
        Me.rbr8_1.Name = "rbr8_1"
        Me.rbr8_1.Size = New System.Drawing.Size(51, 17)
        Me.rbr8_1.TabIndex = 0
        Me.rbr8_1.Text = "R8_1"
        Me.rbr8_1.UseVisualStyleBackColor = True
        '
        'gbrespuesta9
        '
        Me.gbrespuesta9.Controls.Add(Me.lblincorrecta9_3)
        Me.gbrespuesta9.Controls.Add(Me.lblincorrecta9_2)
        Me.gbrespuesta9.Controls.Add(Me.lblcorrecta9_1)
        Me.gbrespuesta9.Controls.Add(Me.rbr9_3)
        Me.gbrespuesta9.Controls.Add(Me.rbr9_2)
        Me.gbrespuesta9.Controls.Add(Me.rbr9_1)
        Me.gbrespuesta9.Location = New System.Drawing.Point(737, 205)
        Me.gbrespuesta9.Name = "gbrespuesta9"
        Me.gbrespuesta9.Size = New System.Drawing.Size(122, 90)
        Me.gbrespuesta9.TabIndex = 5
        Me.gbrespuesta9.TabStop = False
        Me.gbrespuesta9.Text = "Respuestas 9"
        '
        'lblincorrecta9_3
        '
        Me.lblincorrecta9_3.AutoSize = True
        Me.lblincorrecta9_3.Location = New System.Drawing.Point(63, 67)
        Me.lblincorrecta9_3.Name = "lblincorrecta9_3"
        Me.lblincorrecta9_3.Size = New System.Drawing.Size(55, 13)
        Me.lblincorrecta9_3.TabIndex = 5
        Me.lblincorrecta9_3.Text = "Incorrecta"
        Me.lblincorrecta9_3.Visible = False
        '
        'lblincorrecta9_2
        '
        Me.lblincorrecta9_2.AutoSize = True
        Me.lblincorrecta9_2.Location = New System.Drawing.Point(63, 44)
        Me.lblincorrecta9_2.Name = "lblincorrecta9_2"
        Me.lblincorrecta9_2.Size = New System.Drawing.Size(55, 13)
        Me.lblincorrecta9_2.TabIndex = 4
        Me.lblincorrecta9_2.Text = "Incorrecta"
        Me.lblincorrecta9_2.Visible = False
        '
        'lblcorrecta9_1
        '
        Me.lblcorrecta9_1.AutoSize = True
        Me.lblcorrecta9_1.Location = New System.Drawing.Point(63, 21)
        Me.lblcorrecta9_1.Name = "lblcorrecta9_1"
        Me.lblcorrecta9_1.Size = New System.Drawing.Size(47, 13)
        Me.lblcorrecta9_1.TabIndex = 3
        Me.lblcorrecta9_1.Text = "Correcta"
        Me.lblcorrecta9_1.Visible = False
        '
        'rbr9_3
        '
        Me.rbr9_3.AutoSize = True
        Me.rbr9_3.Checked = True
        Me.rbr9_3.Location = New System.Drawing.Point(6, 65)
        Me.rbr9_3.Name = "rbr9_3"
        Me.rbr9_3.Size = New System.Drawing.Size(51, 17)
        Me.rbr9_3.TabIndex = 2
        Me.rbr9_3.TabStop = True
        Me.rbr9_3.Text = "R9_3"
        Me.rbr9_3.UseVisualStyleBackColor = True
        '
        'rbr9_2
        '
        Me.rbr9_2.AutoSize = True
        Me.rbr9_2.Location = New System.Drawing.Point(6, 42)
        Me.rbr9_2.Name = "rbr9_2"
        Me.rbr9_2.Size = New System.Drawing.Size(51, 17)
        Me.rbr9_2.TabIndex = 1
        Me.rbr9_2.Text = "R9_2"
        Me.rbr9_2.UseVisualStyleBackColor = True
        '
        'rbr9_1
        '
        Me.rbr9_1.AutoSize = True
        Me.rbr9_1.Location = New System.Drawing.Point(6, 19)
        Me.rbr9_1.Name = "rbr9_1"
        Me.rbr9_1.Size = New System.Drawing.Size(51, 17)
        Me.rbr9_1.TabIndex = 0
        Me.rbr9_1.Text = "R9_1"
        Me.rbr9_1.UseVisualStyleBackColor = True
        '
        'btsiguiente3
        '
        Me.btsiguiente3.Location = New System.Drawing.Point(757, 313)
        Me.btsiguiente3.Name = "btsiguiente3"
        Me.btsiguiente3.Size = New System.Drawing.Size(75, 23)
        Me.btsiguiente3.TabIndex = 6
        Me.btsiguiente3.Text = "Siguiente"
        Me.btsiguiente3.UseVisualStyleBackColor = True
        Me.btsiguiente3.Visible = False
        '
        'tiempo3
        '
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(595, 313)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Label4"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(640, 313)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Label5"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(550, 313)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Tiempo para responder:"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(892, 377)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btsiguiente3)
        Me.Controls.Add(Me.gbrespuesta9)
        Me.Controls.Add(Me.gbrespuesta8)
        Me.Controls.Add(Me.gbrespuesta7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.gbrespuesta7.ResumeLayout(False)
        Me.gbrespuesta7.PerformLayout()
        Me.gbrespuesta8.ResumeLayout(False)
        Me.gbrespuesta8.PerformLayout()
        Me.gbrespuesta9.ResumeLayout(False)
        Me.gbrespuesta9.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents gbrespuesta7 As System.Windows.Forms.GroupBox
    Friend WithEvents gbrespuesta8 As System.Windows.Forms.GroupBox
    Friend WithEvents gbrespuesta9 As System.Windows.Forms.GroupBox
    Friend WithEvents rbr7_3 As System.Windows.Forms.RadioButton
    Friend WithEvents rbr7_2 As System.Windows.Forms.RadioButton
    Friend WithEvents rbr7_1 As System.Windows.Forms.RadioButton
    Friend WithEvents rbr8_3 As System.Windows.Forms.RadioButton
    Friend WithEvents rbr8_2 As System.Windows.Forms.RadioButton
    Friend WithEvents rbr8_1 As System.Windows.Forms.RadioButton
    Friend WithEvents rbr9_3 As System.Windows.Forms.RadioButton
    Friend WithEvents rbr9_2 As System.Windows.Forms.RadioButton
    Friend WithEvents rbr9_1 As System.Windows.Forms.RadioButton
    Friend WithEvents btsiguiente3 As System.Windows.Forms.Button
    Friend WithEvents lblincorrecta7_3 As System.Windows.Forms.Label
    Friend WithEvents lblincorrecta7_2 As System.Windows.Forms.Label
    Friend WithEvents lblcorrecta7_1 As System.Windows.Forms.Label
    Friend WithEvents lblincorrecta8_3 As System.Windows.Forms.Label
    Friend WithEvents lblincorrecta8_2 As System.Windows.Forms.Label
    Friend WithEvents lblcorrecta8_1 As System.Windows.Forms.Label
    Friend WithEvents lblincorrecta9_3 As System.Windows.Forms.Label
    Friend WithEvents lblincorrecta9_2 As System.Windows.Forms.Label
    Friend WithEvents lblcorrecta9_1 As System.Windows.Forms.Label
    Friend WithEvents tiempo3 As System.Windows.Forms.Timer
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
