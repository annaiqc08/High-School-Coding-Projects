Public Class Form1
    Public punteo, conteo, correctas, incorrectas, tiempos1, tiempos2, tiempos3, tiempos4, i, a, b, c, pulsar As Integer
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        rbr1_1.Checked = False
        rbr1_2.Checked = False
        rbr1_3.Checked = False
        rbr2_1.Checked = False
        rbr2_2.Checked = False
        rbr2_3.Checked = False
        rbr3_1.Checked = False
        rbr3_2.Checked = False
        rbr3_3.Checked = False
        tiempo1.Interval = 100
        tiempo1.Start()
        tiempos1 = 30
    End Sub

    Private Sub rbr1_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbr1_1.Click
        pulsar = pulsar + 1
        If pulsar = 3 Then
            btsiguiente1.Visible = True
        End If
        rbr1_2.Enabled = False
        rbr1_3.Enabled = False
        lblcorrecta1_1.Visible = True
    End Sub

    Private Sub rbr1_2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbr1_2.Click
        pulsar = pulsar + 1
        If pulsar = 3 Then
            btsiguiente1.Visible = True
        End If
        rbr1_1.Enabled = False
        rbr1_3.Enabled = False
        lblincorrecta1_2.Visible = True
    End Sub

    Private Sub rbr1_3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbr1_3.Click
        pulsar = pulsar + 1
        If pulsar = 3 Then
            btsiguiente1.Visible = True
        End If
        rbr1_1.Enabled = False
        rbr1_2.Enabled = False
        lblincorrecta1_3.Visible = True
    End Sub

    Private Sub rbr2_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbr2_1.Click
        pulsar = pulsar + 1
        If pulsar = 3 Then
            btsiguiente1.Visible = True
        End If
        rbr2_2.Enabled = False
        rbr2_3.Enabled = False
        lblincorrecta2_1.Visible = True
    End Sub

    Private Sub rbr2_2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbr2_2.Click
        pulsar = pulsar + 1
        If pulsar = 3 Then
            btsiguiente1.Visible = True
        End If
        rbr2_1.Enabled = False
        rbr2_3.Enabled = False
        lblincorrecta2_2.Visible = True
    End Sub

    Private Sub rbr2_3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbr2_3.Click
        rbr2_1.Enabled = False
        rbr2_2.Enabled = False
        lblcorrecta2_3.Visible = True
    End Sub

    Private Sub rbr3_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbr3_1.Click
        pulsar = pulsar + 1
        If pulsar = 3 Then
            btsiguiente1.Visible = True
        End If
        rbr3_2.Enabled = False
        rbr3_3.Enabled = False
        lblincorrecta3_1.Visible = True
    End Sub

    Private Sub rbr3_2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbr3_2.Click
        pulsar = pulsar + 1
        If pulsar = 3 Then
            btsiguiente1.Visible = True
        End If
        rbr3_1.Enabled = False
        rbr3_3.Enabled = False
        lblcorrecta3_2.Visible = True
    End Sub

    Private Sub rbr3_3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbr3_3.Click
        pulsar = pulsar + 1
        If pulsar = 3 Then
            btsiguiente1.Visible = True
        End If
        rbr3_1.Enabled = False
        rbr3_2.Enabled = False
        lblincorrecta3_3.Visible = True
    End Sub

    Private Sub btsiguiente1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btsiguiente1.Click
        If rbr1_1.Checked = True Then
            punteo = punteo + 5
        End If
        If rbr2_3.Checked = True Then
            punteo = punteo + 5
        End If
        If rbr3_2.Checked = True Then
            punteo = punteo + 5
        End If
        conteo = punteo
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub tiempo1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tiempo1.Tick
        If tiempos1 > -1 Then
            Label4.Text = tiempos1
            tiempos1 = tiempos1 - 1
        Else
            For i = 1 To 3
                gbrespuesta1.Controls("rbr1_" & i).Enabled = False
                gbrespuesta2.Controls("rbr2_" & i).Enabled = False
                gbrespuesta3.Controls("rbr3_" & i).Enabled = False
            Next
            tiempo1.Stop()
            tiempos1 = 30
            MsgBox("Tiempo Expirado")
        End If
    End Sub
End Class
