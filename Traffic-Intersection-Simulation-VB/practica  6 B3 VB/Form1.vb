Public Class Form1
    Public tiempos1, tiempos2, a, b As Integer
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        luzverde.Visible = False
        luzamarillo.Visible = False
        luzrojo.Visible = False
        luzverde2.Visible = False
        luzamarillo2.Visible = False
        luzrojo2.Visible = False
        tiempo1.Interval = 2000
        tiempo3.Interval = 3000

        carrito1.Location = New Point(10, 185)
        carrito2.Location = New Point(380, 5)
    End Sub

    Private Sub btencender_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btencender.Click
        luzverde.Visible = True
        tiempo1.Start()
        tiempo2.Start()
        luzrojo2.Visible = True
        tiempo3.Start()
        tiempo4.Start()
    End Sub

    Private Sub tiempo1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tiempo1.Tick
        If luzverde.Visible = True Then
            luzverde.Visible = False
            luzamarillo.Visible = True
            tiempo1.Interval = 1000
        Else
            If luzamarillo.Visible = True Then
                luzamarillo.Visible = False
                luzrojo.Visible = True
                tiempo1.Interval = 3000
            Else
                If luzrojo.Visible = True Then
                    luzrojo.Visible = False
                    luzverde.Visible = True
                    tiempo2.Start()
                    tiempo1.Interval = 2000
                End If
            End If
        End If
    End Sub

    Private Sub tiempo2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tiempo2.Tick
        a = a + 5
        carrito1.Location = New Point(10 + a, 185)
        If (luzamarillo.Visible = True) And
            (a > 300) And (a < 350) Then
            tiempo2.Stop()
        Else
            If luzrojo.Visible = True And
                (a <= 350) Then
                tiempo2.Stop()
            Else
                tiempo2.Start()
            End If
        End If
    End Sub

    Private Sub tiempo3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tiempo3.Tick
        If luzrojo2.Visible = True Then
            luzrojo2.Visible = False
            luzverde2.Visible = True
            tiempo4.Start()
            tiempo3.Interval = 2000
        Else
            If luzverde2.Visible = True Then
                luzverde2.Visible = False
                luzamarillo2.Visible = True
                tiempo3.Interval = 1000
            Else
                If luzamarillo2.Visible = True Then
                    luzamarillo2.Visible = False
                    luzrojo2.Visible = True
                    tiempo3.Interval = 3000
                End If
            End If
        End If
    End Sub

    Private Sub tiempo4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tiempo4.Tick
        b = b + 5
        carrito2.Location = New Point(380, b + 5)
        If (luzamarillo2.Visible = True) And
            (b > 50) And (b < 100) Then
            tiempo4.Stop()
        Else
            If (luzrojo2.Visible = True) And
                (b <= 100) Then
                tiempo4.Stop()
            Else
                tiempo4.Start()
            End If
        End If
    End Sub

    Private Sub btapagar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btapagar.Click
        tiempo1.Stop()
        tiempo2.Stop()
        tiempo3.Stop()
        tiempo4.Stop()
    End Sub

    Private Sub btsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btsalir.Click
        End
    End Sub
End Class
