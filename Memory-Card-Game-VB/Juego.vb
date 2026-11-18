Public Class Juego
    Public imagen(8) As Image
    Public x, k, tarjeta, totnum, r, p As Integer
    Public aleat(8) As Boolean
    Private Sub Juego_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        imag0.Visible = False
        imag1.Visible = False
        imag2.Visible = False
        imag3.Visible = False
        imag4.Visible = False
        imag5.Visible = False
        imag6.Visible = False
        imag7.Visible = False
       
        imagen(0) = My.Resources.skip1
        imagen(1) = My.Resources.skip1_1
        imagen(2) = My.Resources.skip2
        imagen(3) = My.Resources.skip2_1
        imagen(4) = My.Resources.skip3
        imagen(5) = My.Resources.skip3_1
        imagen(6) = My.Resources.skip4
        imagen(7) = My.Resources.skip4_1

        ListBox1.Items.Clear()
        Dim Numero As Integer
        totnum = 7

        r = 0
        p = 0

        While r <= totnum
            Randomize()
            Numero = Int(Rnd() * 8)

            If comprepetido(Numero) = False Then
                ListBox1.Items.Add(Numero)
                aleat(p) = Numero
                r = r + 1
                p = p + 1

            End If
        End While



        For k = 0 To 7 Step 1
            Me.Controls("imagen" & k).BackgroundImage = imagen(aleat(k))
        Next




    End Sub
    Private Function comprepetido(ByVal numero As Integer) As Boolean
        Dim i As Integer
        For i = 0 To ListBox1.items.count() - 1
            ListBox1.SelectedIndex = i
            If ListBox1.Text = numero Then
                comprepetido = True
                Exit Function
            End If
        Next
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        imag0.Visible = True
        imag1.Visible = True
        imag2.Visible = True
        imag3.Visible = True
        imag4.Visible = True
        imag5.Visible = True
        imag6.Visible = True
        imag7.Visible = True
        port0.Visible = False
        port1.Visible = False
        port2.Visible = False
        port3.Visible = False
        port4.Visible = False
        port5.Visible = False
        port6.Visible = False
        port7.Visible = False
        Timer1.Start()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        End
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        tarjeta = tarjeta + 1
        Label1.Text = tarjeta
        If (tarjeta = 20) Then
            imag0.Visible = False
            imag1.Visible = False
            imag2.Visible = False
            imag3.Visible = False
            imag4.Visible = False
            imag5.Visible = False
            imag6.Visible = False
            imag7.Visible = False
            port0.Visible = True
            port1.Visible = True
            port2.Visible = True
            port3.Visible = True
            port4.Visible = True
            port5.Visible = True
            port6.Visible = True
            port7.Visible = True
            port0.Enabled = True
            port1.Enabled = True
            port2.Enabled = True
            port3.Enabled = True
            port4.Enabled = True
            port5.Enabled = True
            port6.Enabled = True
            port7.Enabled = True
            Button1.Enabled = False
            Timer1.Stop()
            Label1.Text = ""
        End If
    End Sub

    Private Sub port0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles port0.Click
        port0.Visible = False
        imag0.Visible = True
    End Sub

    Private Sub port1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles port1.Click
        port1.Visible = False
        imag1.Visible = True
    End Sub

    Private Sub port2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles port2.Click
        port2.Visible = False
        imag2.Visible = True
    End Sub

    Private Sub port3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles port3.Click
        port3.Visible = False
        imag3.Visible = True
    End Sub

    Private Sub port4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles port4.Click
        port4.Visible = False
        imag4.Visible = True
    End Sub

    Private Sub port5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles port5.Click
        port5.Visible = False
        imag5.Visible = True
    End Sub

    Private Sub port6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles port6.Click
        port6.Visible = False
        imag6.Visible = True
    End Sub

    Private Sub port7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles port7.Click
        port7.Visible = False
        imag7.Visible = True
    End Sub
End Class
