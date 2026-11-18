Public Class Form2
    Public i As Integer

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Form1.ultimo = Form1.ldescripcion.Items.Count - 1
        Form1.ultimo = Form1.lvalor.Items.Count - 1

        For i = 0 To Form1.ultimo
            ldescripcion2.Items.Add(Form1.ldescripcion.Items(i))
            lvalor2.Items.Add(Form1.lvalor.Items(i))
        Next
        txtotal2.Text = Form1.txttotal.Text
    End Sub

    Private Sub btsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btsalir.Click
        MsgBox("Gracias por su preferencia. Vuelva pronto!")
        End
    End Sub
End Class