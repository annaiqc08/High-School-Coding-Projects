Public Class form4

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        rbr10_1.Checked = False
        rbr10_2.Checked = False
        rbr10_3.Checked = False
        rbr11_1.Checked = False
        rbr11_2.Checked = False
        rbr11_3.Checked = False
        rbr12_1.Checked = False
        rbr12_2.Checked = False
        rbr12_3.Checked = False
        tiempo4.Interval = 100
        tiempo4.Start()
        Form1.tiempos4 = 30
    End Sub

    Private Sub rbr10_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbr10_1.Click
        If Form1.pulsar = 12 Then
            Button1.Visible = True
        End If
        rbr10_2.Enabled = False
        rbr10_3.Enabled = False
        lblcorrecta10_1.Visible = True
    End Sub

    Private Sub rbr10_2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbr10_2.Click
        If Form1.pulsar = 12 Then
            Button1.Visible = True
        End If
        rbr10_1.Enabled = False
        rbr10_3.Enabled = False
        lblincorrecta10_2.Visible = True
    End Sub

    Private Sub rbr10_3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbr10_3.Click
        If Form1.pulsar = 12 Then
            Button1.Visible = True
        End If
        rbr10_1.Enabled = False
        rbr10_2.Enabled = False
        lblincorrecta10_3.Visible = True
    End Sub

    Private Sub rbr11_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbr11_1.Click
        If Form1.pulsar = 12 Then
            Button1.Visible = True
        End If
        rbr11_2.Enabled = False
        rbr11_3.Enabled = False
        lblcorrecta11_1.Visible = True
    End Sub

    Private Sub rbr11_2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbr11_2.Click
        If Form1.pulsar = 12 Then
            Button1.Visible = True
        End If
        rbr11_1.Enabled = False
        rbr11_3.Enabled = False
        lblincorrecta11_2.Visible = True
    End Sub

    Private Sub rbr11_3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbr11_3.Click
        If Form1.pulsar = 12 Then
            Button1.Visible = True
        End If
        rbr11_1.Enabled = False
        rbr11_2.Enabled = False
        lblincorrecta11_3.Visible = True
    End Sub

    Private Sub rbr12_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbr12_1.Click
        If Form1.pulsar = 12 Then
            Button1.Visible = True
        End If
        rbr12_2.Enabled = False
        rbr12_3.Enabled = False
        lblcorrecta12_1.Visible = True
    End Sub

    Private Sub rbr12_2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbr12_2.Click
        If Form1.pulsar = 12 Then
            Button1.Visible = True
        End If
        rbr12_1.Enabled = False
        rbr12_3.Enabled = False
        lblincorrecta12_2.Visible = True
    End Sub

    Private Sub rbr12_3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbr12_3.Click
        If Form1.pulsar = 12 Then
            Button1.Visible = True
        End If
        rbr12_1.Enabled = False
        rbr12_2.Enabled = False
        lblincorrecta12_3.Visible = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If rbr10_1.Checked = True Then
            Form1.punteo = Form1.punteo + 5
        End If
        If rbr11_1.Checked = True Then
            Form1.punteo = Form1.punteo + 5
        End If
        If rbr12_1.Checked = True Then
            Form1.punteo = Form1.punteo + 5
        End If
        Form1.conteo = Form1.punteo
        Form1.correctas = Form1.punteo / 5
        txtcorrectas.Text = Form1.correctas
        Form1.incorrectas = 12 - Form1.correctas
        txtincorrectas.Text = Form1.incorrectas
        txtresultado.Text = Form1.conteo
        Button1.Enabled = False
    End Sub

    Private Sub tiempo4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tiempo4.Tick
        If Form1.tiempos4 > -1 Then
            Label4.Text = Form1.tiempos4
            Form1.tiempos4 = Form1.tiempos4 - 1
        Else
            For c = 1 To 3
                gbrespuesta10.Controls("rbr10_" & c).Enabled = False
                gbrespuesta11.Controls("rbr11_" & c).Enabled = False
                gbrespuesta12.Controls("rbr12_" & c).Enabled = False
            Next
            tiempo4.Stop()
            Form1.tiempos4 = 30
            MsgBox("Tiempo Expirado")
        End If
    End Sub
End Class