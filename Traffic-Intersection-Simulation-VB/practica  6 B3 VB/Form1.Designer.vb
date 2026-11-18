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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.luzrojo2 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.luzamarillo2 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.luzverde2 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.LineShape8 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape7 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape6 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape5 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.luzrojo = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.luzamarillo = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.luzverde = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.btencender = New System.Windows.Forms.Button()
        Me.btapagar = New System.Windows.Forms.Button()
        Me.tiempo1 = New System.Windows.Forms.Timer(Me.components)
        Me.tiempo2 = New System.Windows.Forms.Timer(Me.components)
        Me.btsalir = New System.Windows.Forms.Button()
        Me.carrito1 = New System.Windows.Forms.PictureBox()
        Me.tiempo3 = New System.Windows.Forms.Timer(Me.components)
        Me.tiempo4 = New System.Windows.Forms.Timer(Me.components)
        Me.carrito2 = New System.Windows.Forms.PictureBox()
        CType(Me.carrito1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.carrito2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.luzrojo2, Me.luzamarillo2, Me.luzverde2, Me.LineShape8, Me.LineShape7, Me.LineShape6, Me.LineShape5, Me.LineShape4, Me.LineShape3, Me.LineShape2, Me.LineShape1, Me.luzrojo, Me.luzamarillo, Me.luzverde})
        Me.ShapeContainer1.Size = New System.Drawing.Size(807, 393)
        Me.ShapeContainer1.TabIndex = 0
        Me.ShapeContainer1.TabStop = False
        '
        'luzrojo2
        '
        Me.luzrojo2.BackColor = System.Drawing.Color.Red
        Me.luzrojo2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.luzrojo2.Location = New System.Drawing.Point(470, 260)
        Me.luzrojo2.Name = "luzrojo2"
        Me.luzrojo2.Size = New System.Drawing.Size(25, 25)
        Me.luzrojo2.Visible = False
        '
        'luzamarillo2
        '
        Me.luzamarillo2.BackColor = System.Drawing.Color.Yellow
        Me.luzamarillo2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.luzamarillo2.Location = New System.Drawing.Point(470, 290)
        Me.luzamarillo2.Name = "luzamarillo2"
        Me.luzamarillo2.Size = New System.Drawing.Size(25, 25)
        Me.luzamarillo2.Visible = False
        '
        'luzverde2
        '
        Me.luzverde2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.luzverde2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.luzverde2.Location = New System.Drawing.Point(470, 320)
        Me.luzverde2.Name = "luzverde2"
        Me.luzverde2.Size = New System.Drawing.Size(25, 25)
        Me.luzverde2.Visible = False
        '
        'LineShape8
        '
        Me.LineShape8.Name = "LineShape8"
        Me.LineShape8.X1 = 450
        Me.LineShape8.X2 = 450
        Me.LineShape8.Y1 = 250
        Me.LineShape8.Y2 = 400
        '
        'LineShape7
        '
        Me.LineShape7.Name = "LineShape7"
        Me.LineShape7.X1 = 350
        Me.LineShape7.X2 = 350
        Me.LineShape7.Y1 = 250
        Me.LineShape7.Y2 = 400
        '
        'LineShape6
        '
        Me.LineShape6.Name = "LineShape6"
        Me.LineShape6.X1 = 450
        Me.LineShape6.X2 = 450
        Me.LineShape6.Y1 = 0
        Me.LineShape6.Y2 = 150
        '
        'LineShape5
        '
        Me.LineShape5.Name = "LineShape5"
        Me.LineShape5.X1 = 350
        Me.LineShape5.X2 = 350
        Me.LineShape5.Y1 = 0
        Me.LineShape5.Y2 = 150
        '
        'LineShape4
        '
        Me.LineShape4.Name = "LineShape4"
        Me.LineShape4.X1 = 450
        Me.LineShape4.X2 = 810
        Me.LineShape4.Y1 = 250
        Me.LineShape4.Y2 = 250
        '
        'LineShape3
        '
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 450
        Me.LineShape3.X2 = 810
        Me.LineShape3.Y1 = 150
        Me.LineShape3.Y2 = 150
        '
        'LineShape2
        '
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 0
        Me.LineShape2.X2 = 350
        Me.LineShape2.Y1 = 250
        Me.LineShape2.Y2 = 250
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 0
        Me.LineShape1.X2 = 350
        Me.LineShape1.Y1 = 150
        Me.LineShape1.Y2 = 150
        '
        'luzrojo
        '
        Me.luzrojo.BackColor = System.Drawing.Color.Red
        Me.luzrojo.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.luzrojo.Location = New System.Drawing.Point(470, 55)
        Me.luzrojo.Name = "luzrojo"
        Me.luzrojo.Size = New System.Drawing.Size(25, 25)
        Me.luzrojo.Visible = False
        '
        'luzamarillo
        '
        Me.luzamarillo.BackColor = System.Drawing.Color.Yellow
        Me.luzamarillo.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.luzamarillo.Location = New System.Drawing.Point(470, 85)
        Me.luzamarillo.Name = "luzamarillo"
        Me.luzamarillo.Size = New System.Drawing.Size(25, 25)
        Me.luzamarillo.Visible = False
        '
        'luzverde
        '
        Me.luzverde.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.luzverde.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.luzverde.Location = New System.Drawing.Point(470, 115)
        Me.luzverde.Name = "luzverde"
        Me.luzverde.Size = New System.Drawing.Size(25, 25)
        Me.luzverde.Visible = False
        '
        'btencender
        '
        Me.btencender.Location = New System.Drawing.Point(732, 3)
        Me.btencender.Name = "btencender"
        Me.btencender.Size = New System.Drawing.Size(75, 23)
        Me.btencender.TabIndex = 1
        Me.btencender.Text = "Encender"
        Me.btencender.UseVisualStyleBackColor = True
        '
        'btapagar
        '
        Me.btapagar.Location = New System.Drawing.Point(732, 32)
        Me.btapagar.Name = "btapagar"
        Me.btapagar.Size = New System.Drawing.Size(75, 23)
        Me.btapagar.TabIndex = 2
        Me.btapagar.Text = "Apagar"
        Me.btapagar.UseVisualStyleBackColor = True
        '
        'tiempo1
        '
        '
        'tiempo2
        '
        '
        'btsalir
        '
        Me.btsalir.Location = New System.Drawing.Point(732, 61)
        Me.btsalir.Name = "btsalir"
        Me.btsalir.Size = New System.Drawing.Size(75, 23)
        Me.btsalir.TabIndex = 4
        Me.btsalir.Text = "Salir"
        Me.btsalir.UseVisualStyleBackColor = True
        '
        'carrito1
        '
        Me.carrito1.Image = CType(resources.GetObject("carrito1.Image"), System.Drawing.Image)
        Me.carrito1.InitialImage = Nothing
        Me.carrito1.Location = New System.Drawing.Point(0, 185)
        Me.carrito1.Name = "carrito1"
        Me.carrito1.Size = New System.Drawing.Size(50, 33)
        Me.carrito1.TabIndex = 5
        Me.carrito1.TabStop = False
        '
        'tiempo3
        '
        '
        'tiempo4
        '
        '
        'carrito2
        '
        Me.carrito2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.carrito2.Location = New System.Drawing.Point(380, 0)
        Me.carrito2.Name = "carrito2"
        Me.carrito2.Size = New System.Drawing.Size(37, 41)
        Me.carrito2.TabIndex = 6
        Me.carrito2.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(807, 393)
        Me.Controls.Add(Me.carrito2)
        Me.Controls.Add(Me.carrito1)
        Me.Controls.Add(Me.btsalir)
        Me.Controls.Add(Me.btapagar)
        Me.Controls.Add(Me.btencender)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.carrito1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.carrito2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents luzrojo As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents luzamarillo As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents luzverde As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents btencender As System.Windows.Forms.Button
    Friend WithEvents btapagar As System.Windows.Forms.Button
    Friend WithEvents tiempo1 As System.Windows.Forms.Timer
    Friend WithEvents tiempo2 As System.Windows.Forms.Timer
    Friend WithEvents btsalir As System.Windows.Forms.Button
    Friend WithEvents LineShape8 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape7 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape6 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape5 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape4 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents luzrojo2 As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents luzamarillo2 As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents luzverde2 As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents carrito1 As System.Windows.Forms.PictureBox
    Friend WithEvents tiempo3 As System.Windows.Forms.Timer
    Friend WithEvents tiempo4 As System.Windows.Forms.Timer
    Friend WithEvents carrito2 As System.Windows.Forms.PictureBox

End Class
